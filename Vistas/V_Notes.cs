using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_Notes : Form
    {
        private string idActividad;
        private string idProyecto;
        private int estadoTipo;

        public V_Notes(string idActividad, string idProyecto, int estadoTipo)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            this.idProyecto = idProyecto;
            this.estadoTipo = estadoTipo;
            CargarNotasActividad();
            ConfigurarTabla();
            accesoButtons(estadoTipo);
        }

        private void accesoButtons(int estadoTipo)
        {
            if (estadoTipo == 1)
            {         
                BmodifNote.Enabled = false;
                BmodifNote.BackColor = Color.Gray;                         
            }
        }
        public void CargarNotasActividad(string filtro = "")
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
        SELECT 
            Id_Nota AS [ID Nota],
            Id_Proyecto AS [ID Proyecto],
            Id_Activity AS [ID Actividad],
            Nota AS [Nota],
            Cuando AS [Fecha]
        FROM Notes
        WHERE Id_Activity = @IdActividad
            AND (
                Id_Nota LIKE @Filtro OR
                Id_Proyecto LIKE @Filtro OR
                Id_Activity LIKE @Filtro OR
                Nota LIKE @Filtro OR
                CONVERT(VARCHAR, Cuando, 120) LIKE @Filtro
            )
        ORDER BY Id_Nota DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdActividad", idActividad);
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable notesDataTable = new DataTable();
                    dataAdapter.Fill(notesDataTable);

                    tablaNotes.DataSource = notesDataTable;
                }
            }
        }

        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            tablaNotes.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            tablaNotes.DefaultCellStyle.Font = new Font("Arial", 14);
            tablaNotes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15, FontStyle.Bold);

            // Centrar el texto de las celdas de identificadores
            tablaNotes.Columns["ID Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaNotes.Columns["ID Proyecto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaNotes.Columns["ID Actividad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear a la izquierda la columna de "Nota"
            tablaNotes.Columns["Nota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tablaNotes.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centrar el texto de los encabezados
            tablaNotes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            tablaNotes.Columns["ID Nota"].HeaderText = "ID Nota";
            tablaNotes.Columns["ID Proyecto"].HeaderText = "ID Proyecto";
            tablaNotes.Columns["ID Actividad"].HeaderText = "ID Actividad";
            tablaNotes.Columns["Nota"].HeaderText = "Nota";
            tablaNotes.Columns["Fecha"].HeaderText = "Fecha";

            // Habilitar scroll automático
            tablaNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaNotes.ScrollBars = ScrollBars.Both;

            tablaNotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaNotes.RowHeadersVisible = false;
            tablaNotes.ReadOnly = true;
            tablaNotes.AllowUserToAddRows = false;

            // Configuración de colores
            tablaNotes.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            tablaNotes.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            tablaNotes.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            tablaNotes.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            tablaNotes.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            tablaNotes.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }


        private void BagregarNote_Click(object sender, EventArgs e)
        {
            V_CRUDnotes addNotes = new V_CRUDnotes(idActividad, idProyecto, null, "", null, 0);
            addNotes.ShowDialog();
            CargarNotasActividad();
        }

        private void BverNote_Click(object sender, EventArgs e)
        {
            string idProyecto = tablaNotes.SelectedRows[0].Cells["ID Proyecto"].Value.ToString();
            string idActividad = tablaNotes.SelectedRows[0].Cells["ID Actividad"].Value.ToString();
            string idNota = tablaNotes.SelectedRows[0].Cells["ID Nota"].Value.ToString();
            string nota = tablaNotes.SelectedRows[0].Cells["Nota"].Value.ToString();
            byte[] imagen = ObtenerImagen(idNota);

            V_CRUDnotes crudNotes = new V_CRUDnotes(idActividad, idProyecto, idNota, nota, imagen, 2);
            crudNotes.ShowDialog();            
        }

        private void ObtenerNota(string idNota)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Nota, Imagen FROM Notes WHERE Id_Nota = @IdNota";

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
                            string textoNota = reader["Nota"].ToString();
                            byte[] imagenBytes = reader["Imagen"] as byte[];

                            // Mostrar texto en un MessageBox
                            MessageBox.Show(textoNota, "Texto de la Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Mostrar imagen (si existe)
                            if (imagenBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imagenBytes))
                                {
                                    Image imagen = Image.FromStream(ms);
                                    Form imagenForm = new Form
                                    {
                                        Text = "Imagen de la Nota",
                                        Size = new Size(500, 500),
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
                            MessageBox.Show("No se encontró la nota seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BmodifNote_Click(object sender, EventArgs e)
        {
            string idProyecto = tablaNotes.SelectedRows[0].Cells["ID Proyecto"].Value.ToString();
            string idActividad = tablaNotes.SelectedRows[0].Cells["ID Actividad"].Value.ToString();
            string idNota = tablaNotes.SelectedRows[0].Cells["ID Nota"].Value.ToString();
            string nota = tablaNotes.SelectedRows[0].Cells["Nota"].Value.ToString();
            byte[] imagen = ObtenerImagen(idNota);

            V_CRUDnotes crudNotes = new V_CRUDnotes(idActividad, idProyecto, idNota, nota, imagen, 1);
            crudNotes.ShowDialog();
            CargarNotasActividad();
        }
        private byte[] ObtenerImagen(string idNota)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Imagen FROM Notes WHERE Id_Nota = @IdNota";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdNota", idNota);

                        connection.Open();
                        object resultado = command.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            return (byte[])resultado;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la imagen o está vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
