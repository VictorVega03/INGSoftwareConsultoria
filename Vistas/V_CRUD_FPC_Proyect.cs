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
    public partial class V_CRUD_FPC_Proyect : Form
    {
        private string idProyecto;
        private bool existeNota;
        private int tipo;
        private string id;
        public V_CRUD_FPC_Proyect(string idProyecto, int tipo)
        {
            InitializeComponent();            
            verificarTipo(idProyecto, tipo);
            this.idProyecto = idProyecto;
            id = idProyecto.ToString();
            LlenarComboBoxEstados();
        }
        private void verificarTipo(string idProyecto, int tipo)
        {
            if (tipo == 1)
            {
                this.Text = "Ver nota de Proyecto";
                Txt_Expl_FCP_Proyect.ReadOnly = true;
                Lbl_Text1.Text = "Nota de proyecto:";
                Lbl_Stts_FCP_Proyect.Visible = false;
                BoxEstado.Visible = false;
                Btn_Aceptar_FCP_Proyect.Visible = false;    
                ObtenerNota(idProyecto);
            }
        }
        private void ObtenerNota(string idProyecto)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT NoteProyect FROM Proyect WHERE Id_Proyecto = @IdProyecto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto);

                    connection.Open();
                    var result = command.ExecuteScalar();

                    if (result != null)
                    {
                        Txt_Expl_FCP_Proyect.Text = result.ToString();
                    }
                    else
                    {
                        Txt_Expl_FCP_Proyect.Text = "No se encontró una nota para este proyecto.";
                    }
                }
            }
        }

        private void LlenarComboBoxEstados()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_SttProAct, Name_SttProAct FROM StatusProAct WHERE Id_SttProAct IN (3,4)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asignar el DataTable como origen de datos del ComboBox
                BoxEstado.DataSource = dataTable;
                BoxEstado.DisplayMember = "Name_SttProAct"; // Mostrar nombre del estado
                BoxEstado.ValueMember = "Id_SttProAct";    // Guardar ID del estado                
            }
        }
        /*
        private void AgregarNota(string idProyecto)
        {
            // Validar que el campo de texto no esté vacío
            if (string.IsNullOrWhiteSpace(Txt_Expl_FCP_Proyect.Text))
            {                
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
        INSERT INTO ProyectNotes (Id_Proyecto, Nota, Cuando) 
        VALUES (@IdProyecto, @Nota, @Cuando)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros para evitar inyección SQL
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto); // ID del proyecto
                    command.Parameters.AddWithValue("@Nota", Txt_Expl_FCP_Proyect.Text); // Texto de la nota
                    //command.Parameters.AddWithValue("@Quien", Environment.UserName); // Usuario actual
                    command.Parameters.AddWithValue("@Cuando", DateTime.Now); // Fecha y hora actual                   

                    connection.Open();
                    command.ExecuteNonQuery();
                    existeNota = true;
                }
            }
        }
        */
        private void Btn_Aceptar_FCP_Proyect_Click(object sender, EventArgs e)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrWhiteSpace(Txt_Expl_FCP_Proyect.Text))
            {
                MessageBox.Show("Por favor, ingresa una explicación antes de finalizar o cancelar el proyecto.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Detener la ejecución si el texto está vacío
            }

            // Confirmar la acción
            DialogResult result = MessageBox.Show($"¿Estás seguro de Finalizar/Cancelar el proyecto {idProyecto}?",
                                                  "Confirmar Operación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Actualizar el campo LifeOrDie a 0
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string query = @"UPDATE Proyect SET LifeOrDie = 0, Id_SttProAct = @IdEstado, Dia_Termino = @DiaTermino, NoteProyect = @Nota WHERE Id_Proyecto = @IdProyecto";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                        command.Parameters.AddWithValue("@DiaTermino", DateTime.Now);
                        command.Parameters.AddWithValue("@IdEstado", BoxEstado.SelectedValue);
                        command.Parameters.AddWithValue("@Nota", Txt_Expl_FCP_Proyect.Text);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("El proyecto se guardó como Finalizado/Cancelado.");
                this.Close();
            }

        }

        private void Btn_Cancelar_FCP_Proyect_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
