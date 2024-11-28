    using System;
    using System.Configuration;
using System.Data;
using System.Data.SqlClient;
    using System.Windows.Forms;

    namespace Vistas
    {
        public partial class V_CRUD_Add_Act : Form
        {
        private DataTable DataTable;
            private string idProyecto;

            public V_CRUD_Add_Act(string idProyecto)
            {
                InitializeComponent();
                this.idProyecto = idProyecto; // Almacena el ID del proyecto
                txtProyecto.Text = idProyecto; // Opcional: Mostrar el ID en un campo de texto para referencia
                txtProyecto.Enabled = false;  // Deshabilita el campo para que no se pueda editar
                LlenarComboBoxEmpleados();
                LlenarComboBoxEmpleadosProveedor();
            }
        private void LlenarComboBoxEmpleados()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Emp, Nom_Emp FROM Empleados WHERE LifeOrDie = 1 AND Id_Permits = 4";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                DataRow defaultRow = dataTable.NewRow();
                defaultRow["Id_Emp"] = DBNull.Value;
                defaultRow["Nom_Emp"] = "SELECCIONE EMPLEADO";
                dataTable.Rows.InsertAt(defaultRow, 0);

                BoxEmpleado.DataSource = dataTable;
                BoxEmpleado.DisplayMember = "Nom_Emp";
                BoxEmpleado.ValueMember = "Id_Emp";
            }
        }
        private void LlenarComboBoxEmpleadosProveedor()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT Id_Emp_Prov, Nom_Emp_Prov FROM EmpleadosProveedor WHERE LifeOrDie = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Agregar fila por defecto
                DataRow defaultRow = dataTable.NewRow();
                defaultRow["Id_Emp_Prov"] = DBNull.Value;
                defaultRow["Nom_Emp_Prov"] = "SELECCIONE EMPLEADO PROVEEDOR";
                dataTable.Rows.InsertAt(defaultRow, 0);

                // Configurar el ComboBox
                BoxEmpProv.DataSource = dataTable;
                BoxEmpProv.DisplayMember = "Nom_Emp_Prov"; // Nombre del empleado proveedor
                BoxEmpProv.ValueMember = "Id_Emp_Prov";   // ID del empleado proveedor
            }
        }

        private void Btn_Asignar_Act1_Click(object sender, EventArgs e)
            {
                if (ValidarCampos())
                {
                    AgregarActividad();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void Btn_Cancelar_Act1_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private bool ValidarCampos()
            {
                // Valida que los campos requeridos no estén vacíos
                return !string.IsNullOrWhiteSpace(txtNombreAct.Text)
                    && !string.IsNullOrWhiteSpace(BoxEmpleado.SelectedValue?.ToString())
                    && !string.IsNullOrWhiteSpace(BoxEmpProv.SelectedValue?.ToString())
                    && !string.IsNullOrWhiteSpace(txtDescripAct.Text);
        }

        private void AgregarActividad()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string query = @"
            INSERT INTO Actividad (Id_Activity, Id_Proyecto, Nombre_Activity, Id_Emp, Id_Emp_Prov, Descripcion, Id_SttProAct, Quien, Cuando, Dia_Inicio, activo)
            VALUES (@IdActividad, @IdProyecto, @NombreActividad, @IdEmpleado, @IdempProv, @Descripcion, @IdEstado, @Quien, @Cuando, @DiaInicio, @Active)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdActividad", GenerarIdActividad());
                        command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                        command.Parameters.AddWithValue("@NombreActividad", txtNombreAct.Text);
                        command.Parameters.AddWithValue("@IdEmpleado", BoxEmpleado.SelectedValue);
                        command.Parameters.AddWithValue("@IdempProv", BoxEmpProv.SelectedValue);
                        command.Parameters.AddWithValue("@Descripcion", txtDescripAct.Text);
                        command.Parameters.AddWithValue("@IdEstado", 1);
                        command.Parameters.AddWithValue("@Quien", Environment.UserName);
                        command.Parameters.AddWithValue("@Cuando", DateTime.Now);
                        command.Parameters.AddWithValue("@DiaInicio", DateTime.Now);
                        command.Parameters.AddWithValue("@Active", 1);

                    connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Actividad agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            private string GenerarIdActividad()
            {
                // Genera un nuevo ID único para la actividad
                string nuevoId = "ACT1001"; // ID inicial si no hay actividades en la tabla
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                string query = "SELECT TOP 1 Id_Activity FROM Actividad ORDER BY Id_Activity DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string ultimoId = result.ToString();
                            int numeroActual = int.Parse(ultimoId.Substring(3)); // Extrae el número quitando "ACT"
                            int nuevoNumero = numeroActual + 1;
                            nuevoId = "ACT" + nuevoNumero.ToString("D4"); // Formatea el nuevo ID
                        }
                    }
                }

                return nuevoId;
            }
        }
    }
