using System;
using System.Windows.Forms;

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
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "ssejas" && contraseña == "Fondeco2024#")
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
}
