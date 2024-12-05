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
    public partial class V_Proveedores : Form
    {
        private DataTable proveedoresDataTable;
        private V_NavBar NavBar;

        public V_Proveedores(V_NavBar MainNavBar)
        {
            InitializeComponent();            
            this.NavBar = MainNavBar;
            CargarDatosProveedores("");
            ConfigurarTabla();
            DGV_Table_Prov.Focus();
        }

        private void ConfigurarTabla()
        {
            // Ajustar la tabla para ocupar todo el panel
            DGV_Table_Prov.Dock = DockStyle.Fill;

            // Hacer el texto más grande
            DGV_Table_Prov.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Table_Prov.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 19, FontStyle.Bold);

            // Centrar el texto de las celdas de identificadores
            DGV_Table_Prov.Columns["Id_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Table_Prov.Columns["RFC_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Prov.Columns["Phone_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear a la izquierda las columnas de texto
            DGV_Table_Prov.Columns["Nom_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Prov.Columns["Rep_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Table_Prov.Columns["Email_Prov"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Centrar el texto de los encabezados
            DGV_Table_Prov.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cambiar nombres de encabezados
            DGV_Table_Prov.Columns["Id_Prov"].HeaderText = "ID Proveedor";
            DGV_Table_Prov.Columns["Nom_Prov"].HeaderText = "Nombre Proveedor";
            DGV_Table_Prov.Columns["Rep_Prov"].HeaderText = "Representante";
            DGV_Table_Prov.Columns["RFC_Prov"].HeaderText = "RFC Proveedor";
            DGV_Table_Prov.Columns["Email_Prov"].HeaderText = "Correo";
            DGV_Table_Prov.Columns["Phone_Prov"].HeaderText = "Teléfono";

            // Habilitar scroll automático
            DGV_Table_Prov.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Table_Prov.ScrollBars = ScrollBars.Both;

            DGV_Table_Prov.ReadOnly = true;
            DGV_Table_Prov.AllowUserToAddRows = false;

            // Configuración de colores
            DGV_Table_Prov.BackgroundColor = Color.AliceBlue; // Fondo general de la tabla
            DGV_Table_Prov.GridColor = Color.SteelBlue; // Color de las líneas de la cuadrícula

            // Configuración de las celdas
            DGV_Table_Prov.DefaultCellStyle.BackColor = Color.LightCyan; // Fondo de las celdas
            DGV_Table_Prov.DefaultCellStyle.ForeColor = Color.Black; // Texto de las celdas
            DGV_Table_Prov.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue; // Fondo al seleccionar celda
            DGV_Table_Prov.DefaultCellStyle.SelectionForeColor = Color.White; // Texto al seleccionar celda
        }


        private void Btn_Add_Prov_Click(object sender, EventArgs e)
        {
            V_CRUD_Add_Prov Add_Prov = new V_CRUD_Add_Prov();
            Add_Prov.ShowDialog();
            CargarDatosProveedores("");
        }

        private void Btn_Upd_Prov_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Prov.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Prov.SelectedRows[0];
                string idProv = selectedRow.Cells["Id_Prov"].Value?.ToString() ?? "N/A";
                string nombre = selectedRow.Cells["Nom_Prov"].Value?.ToString() ?? "N/A";
                string representante = selectedRow.Cells["Rep_Prov"].Value?.ToString() ?? "N/A";
                string rfcProveedor = selectedRow.Cells["RFC_Prov"].Value?.ToString() ?? "N/A";
                string email = selectedRow.Cells["Email_Prov"].Value?.ToString() ?? "N/A";
                string telefono = selectedRow.Cells["Phone_Prov"].Value?.ToString() ?? "N/A";

                V_CRUD_Upd_Prov Upd_Prov = new V_CRUD_Upd_Prov(idProv, nombre, representante, rfcProveedor, email, telefono);
                Upd_Prov.ShowDialog();
                CargarDatosProveedores("");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para actualizar.");
            }
        }


        private void Btn_Eliminar_Prov_Click(object sender, EventArgs e)
        {
            if (DGV_Table_Prov.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV_Table_Prov.SelectedRows[0];
                var idCell = selectedRow.Cells["Id_Prov"];
                var nameCell = selectedRow.Cells["Nom_Prov"];

                if (idCell?.Value != null && nameCell?.Value != null)
                {
                    string idProv = idCell.Value.ToString();
                    string nombre = nameCell.Value.ToString();

                    DialogResult dialogResult = MessageBox.Show($"¿Está seguro de eliminar al proveedor {nombre}, con el ID {idProv}?", "Eliminar Proveedor", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteProveedor(idProv);
                        MessageBox.Show("Proveedor eliminado exitosamente.");
                        CargarDatosProveedores("");
                    }
                }
                else
                {
                    MessageBox.Show("El proveedor seleccionado no tiene datos válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.");
            }
            CargarDatosProveedores("");
        }

        private void deleteProveedor(string idProv)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "UPDATE Proveedores SET LifeOrDie = 0 WHERE Id_Prov = @Id_Prov";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id_Prov", idProv);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void CargarDatosProveedores(string filtro)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            string query = @"
    SELECT 
        Id_Prov, 
        Nom_Prov, 
        Rep_Prov, 
        RFC_Prov, 
        Email_Prov, 
        Phone_Prov
    FROM Proveedores 
    WHERE LifeOrDie = 1
    AND (
        Id_Prov LIKE @Filtro OR 
        Nom_Prov LIKE @Filtro OR 
        Rep_Prov LIKE @Filtro OR 
        RFC_Prov LIKE @Filtro OR 
        Email_Prov LIKE @Filtro OR 
        Phone_Prov LIKE @Filtro
    )
    ORDER BY Cuando DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el filtro con comodines para la búsqueda
                    command.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    proveedoresDataTable = new DataTable();
                    dataAdapter.Fill(proveedoresDataTable);
                    DGV_Table_Prov.DataSource = proveedoresDataTable;
                }
            }
        }


        private void Btn_Emp_Prov_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_Employe_Prov(NavBar), "Empleados del Prov");
        }

        private void BProvRemoved_Click(object sender, EventArgs e)
        {
            NavBar.AbrirFormularioEnPanel(new V_ProvRemoved(), "Proveedores Eliminados");
        }
    }
}
