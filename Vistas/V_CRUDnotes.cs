using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_CRUDnotes : Form
    {
        private string idActividad;
        private string idProyecto;        
        private string idNota;
        private string nota;
        private byte[] imagen;
        private int type;

        public V_CRUDnotes(string idActividad, string idProyecto, string idNota, string nota, byte[] imagen, int type)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            this.idProyecto = idProyecto;
            this.idNota = idNota;        
            this.nota = nota;
            this.imagen = imagen;
            this.type = type;

            this.txtIDproyect.Text = idProyecto;
            this.txtIDActivity.Text = idActividad;   
            this.txtIDNota.Text = idNota;
            this.txtNote.Text = nota;
                     
            cargartipo(type);
        }
    
        private void cargartipo(int type)
        {
            if (type == 0)
            {
                this.Text = "Agregar Nota";
                this.Baceptar.Text = "Agregar";
                this.txtIDNota.Visible = false;
                label1.Visible = false;
            }
            else if (type == 1)
            {
                this.Text = "Editar Nota";
                this.Lbl_Notas.Text = "Modifique la Nota";
                this.Baceptar.Text = "Editar";
                using (var ms = new System.IO.MemoryStream(imagen))
                {
                    PBimagen.Image = Image.FromStream(ms);
                }
            }
            else
            {
                this.Text = "Ver Nota";
                this.Lbl_Notas.Text = "Ver Nota";
                this.Baceptar.Text = "Ampliar Imagen";
                this.Bcancelar.Text = "Cerrar";
                this.txtNote.ReadOnly = true;                
                this.BuploadImg.Visible = false;
                using (var ms = new System.IO.MemoryStream(imagen))
                {
                    PBimagen.Image = Image.FromStream(ms);
                }
            }

        }
        private void BuploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.png;*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PBimagen.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Baceptar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("La nota no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir imagen a bytes
            byte[] imagenBytes = null;
            if (PBimagen.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PBimagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }
            }
            if (type == 0)
            {                
                GuardarNota(txtNote.Text, imagenBytes);
            }
            else if (type == 1)
            {
                ModificarNota(idNota, txtNote.Text, imagenBytes);
            }
            else
            {
                AmpliarImagen(PBimagen);
            }
        }
        private void AmpliarImagen(PictureBox PBimagen)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Imagen FROM Notes WHERE Id_Nota = @IdNota";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdNota", idNota);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {                            
                            byte[] imagenBytes = reader["Imagen"] as byte[];                                                       
                            if (imagenBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(ms);
                                    Form imagenForm = new Form
                                    {
                                        Text = "Imagen de la Nota",
                                        Size = new Size(650, 650),
                                        StartPosition = FormStartPosition.CenterScreen
                                    };

                                    PictureBox pictureBox = new PictureBox
                                    {
                                        Image = imagen,
                                        SizeMode = PictureBoxSizeMode.Zoom,
                                        Dock = DockStyle.Fill
                                    };

                                    imagenForm.Controls.Add(pictureBox);
                                    imagenForm.ShowDialog();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la imagen seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void GuardarNota(string nota, byte[] imagen)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                INSERT INTO Notes (Id_Nota, Id_Activity, Id_Proyecto, Nota, Imagen, Cuando)
                VALUES (@IdNota, @IdActivity, @IdProyecto, @Nota, @Imagen, @Cuando)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdNota", GenerarIdNota());
                        command.Parameters.AddWithValue("@IdActivity", idActividad);
                        command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                        command.Parameters.AddWithValue("@Nota", nota);
                        command.Parameters.AddWithValue("@Imagen", (object)imagen ?? DBNull.Value);                        
                        command.Parameters.AddWithValue("@Cuando", DateTime.Now);                        

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Nota guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ModificarNota(string idNota, string nota, byte[] imagen)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
        UPDATE Notes
        SET Nota = @NuevaNota, Imagen = @NuevaImagen
        WHERE Id_Nota = @IdNota";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdNota", idNota);
                        command.Parameters.AddWithValue("@NuevaNota", nota);
                        command.Parameters.AddWithValue("@NuevaImagen", (object)imagen ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Cuando", DateTime.Now);

                        connection.Open();
                        int filasAfectadas = command.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Nota modificada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la nota especificada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la nota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GenerarIdNota()
        {
            // Genera un nuevo ID único para la nota
            string nuevoId = "N1001"; // ID inicial si no hay notas en la tabla
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT TOP 1 Id_Nota FROM Notes ORDER BY Id_Nota DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string ultimoId = result.ToString();
                        int numeroActual = int.Parse(ultimoId.Substring(1)); // Extrae el número quitando "N"
                        int nuevoNumero = numeroActual + 1;
                        nuevoId = "N" + nuevoNumero.ToString("D4"); // Formatea el nuevo ID
                    }
                }
            }
            return nuevoId;
        }
    }
}
