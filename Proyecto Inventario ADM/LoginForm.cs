using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace ProyectoInventarioADM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario=@NombreUsuario AND Contrasena=@Contrasena";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contraseña);

                connection.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                MainForm mainForm = new MainForm(); // Abre el formulario principal
                mainForm.Show();
                this.Hide(); // Oculta el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Contraseña inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    catch (Exception ex)
            {
             MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
