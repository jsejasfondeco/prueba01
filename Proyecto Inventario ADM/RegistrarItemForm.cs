using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class RegistrarItemForm : Form
    {
        private Inventario inventario;

        public RegistrarItemForm(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreItem.Text;
            int cantidad;
            decimal precio;

            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }

            Item nuevoItem = new Item(nombre, cantidad, precio, DateTime.Now);
            inventario.AgregarItem(nuevoItem);
            inventario.GuardarInventario(); // Guardar cambios

            MessageBox.Show("Item registrado exitosamente.");
            this.Close();
        }
    }
}
