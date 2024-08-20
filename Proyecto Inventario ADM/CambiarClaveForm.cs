using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class CambiarClaveForm : Form
    {
        public CambiarClaveForm()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Lógica para cambiar la clave
            MessageBox.Show("Clave cambiada con éxito.");
        }
    }
}
