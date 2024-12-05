using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vistas
{
    public partial class V_Login : Form
    {
        private string user;
        public V_Login()
        {
            // Configurar el formulario
            this.Text = "Login";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true; // Para evitar parpadeos al dibujar
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Cuadro central
            Panel centralPanel = new Panel
            {
                BackColor = Color.FromArgb(200, 255, 255, 255), // Fondo semi-transparente
                Size = new Size(300, 400), // Ajustar el tamaño para incluir el botón "Salir"
                Location = new Point((this.ClientSize.Width - 300) / 2, (this.ClientSize.Height - 400) / 2),
                Anchor = AnchorStyles.None
            };
            this.Controls.Add(centralPanel);

            // Imagen de encabezado (logo)
            PictureBox logoPictureBox = new PictureBox
            {
                ImageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\victorvega\\source\\repos\\INGSoftwareConsultoria\\Vistas\\Images\\ConsultoriaImg.png"), // Ruta de la imagen
                SizeMode = PictureBoxSizeMode.Zoom, // Ajusta la imagen para que se vea completa
                Size = new Size(100, 100),
                Location = new Point((centralPanel.Width - 100) / 2, 10) // Centrado horizontalmente
            };
            centralPanel.Controls.Add(logoPictureBox);

            // Texto inicial (centrado)
            Label lbltext = new Label
            {
                Text = "Por favor, inicie sesión:",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point((centralPanel.Width - 200) / 2, logoPictureBox.Bottom + 10)
            };
            centralPanel.Controls.Add(lbltext);

            // Usuario
            Label lblUser = new Label
            {
                Text = "Usuario:",
                Location = new Point((centralPanel.Width - 260) / 2, lbltext.Bottom + 20),
                AutoSize = true
            };
            TextBox txtUser = new TextBox
            {
                Location = new Point((centralPanel.Width - 260) / 2, lblUser.Bottom + 5),
                Width = 260
            };

            // Contraseña
            Label lblPassword = new Label
            {
                Text = "Contraseña:",
                Location = new Point((centralPanel.Width - 260) / 2, txtUser.Bottom + 15),
                AutoSize = true
            };
            TextBox txtPassword = new TextBox
            {
                Location = new Point((centralPanel.Width - 260) / 2, lblPassword.Bottom + 5),
                Width = 260,
                PasswordChar = '*'
            };

            // Botón de Iniciar Sesión
            Button btnLogin = new Button
            {
                Text = "Iniciar Sesión",
                Location = new Point((centralPanel.Width - 260) / 2, txtPassword.Bottom + 20),
                Width = 260,
                Height = 40,
                BackColor = Color.Green,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Evento al presionar el botón de iniciar sesión
            btnLogin.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Por favor, complete ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (VerificarCredenciales(txtUser.Text, txtPassword.Text))
                {
                    string txtUserInput = txtUser.Text.Trim();
                    ObtenerUserName(txtUserInput);

                    V_Principal principal = new V_Principal();
                    principal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Evento para detectar la tecla Enter
            txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin.PerformClick();
                }
            };

            // Botón de Salir
            Button btnSalir = new Button
            {
                Text = "Salir",
                Location = new Point((centralPanel.Width - 260) / 2, btnLogin.Bottom + 20),
                Width = 260,
                Height = 40,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Evento al presionar el botón de salir
            btnSalir.Click += (s, e) =>
            {
                Application.Exit(); // Cierra completamente la aplicación
            };

            // Agregar componentes al panel
            centralPanel.Controls.Add(lblUser);
            centralPanel.Controls.Add(txtUser);
            centralPanel.Controls.Add(lblPassword);
            centralPanel.Controls.Add(txtPassword);
            centralPanel.Controls.Add(btnLogin);
            centralPanel.Controls.Add(btnSalir); // Agrega el botón "Salir"

            // Configurar evento Paint
            this.Paint += DrawBackground;
        }

        private void ObtenerUserName(string txtUserInput)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT UserName, Id_Permits FROM InicioSesion WHERE Id_Login = @IdLogin";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agrega el parámetro con el texto ingresado en txtUser
                        command.Parameters.AddWithValue("@IdLogin", txtUserInput);

                        connection.Open();

                        // Usa un SqlDataReader para obtener los valores
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si se encuentra el registro
                            {
                                // Asignar valores a las variables globales
                                dataLogin.userName = reader["UserName"].ToString();
                                dataLogin.userPermits = Convert.ToInt32(reader["Id_Permits"]);

                                //MessageBox.Show($"Usuario encontrado: {dataLogin.userName}, Permisos: {dataLogin.userPermits} Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawBackground(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\victorvega\\source\\repos\\INGSoftwareConsultoria\\Vistas\\Images\\consultoriaBackground1.jpeg");

            if (!File.Exists(imagePath))
            {
                MessageBox.Show("La imagen de fondo no se encuentra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cargar la imagen
            using (Image backgroundImage = Image.FromFile(imagePath))
            {
                // Dibujar la imagen para ocupar todo el fondo
                g.DrawImage(backgroundImage, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            }
        }

        private bool VerificarCredenciales(string usuario, string contrasena)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = "SELECT COUNT(1) FROM InicioSesion WHERE Id_Login = @Usuario AND Pass_LogIn = @Contrasena";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        connection.Open();

                        // Ejecutar la consulta y verificar si existe el usuario
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0; // Retorna true si existe
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
