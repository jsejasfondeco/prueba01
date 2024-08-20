using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class RegistrarConsumoForm : Form
    {
        private Inventario inventario; // Asumiendo que tienes una clase Inventario

        public RegistrarConsumoForm(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
        }

        private void RegistrarConsumoForm_Load(object sender, EventArgs e)
        {
            CargarItems(); // Carga los ítems en el ComboBox cuando se carga el formulario
        }

        private void CargarItems()
        {
            comboBoxItems.Items.Clear();
            var items = inventario.ObtenerItems(); // Este método debe devolver la lista de ítems disponibles
            foreach (var item in items)
            {
                comboBoxItems.Items.Add(item.Nombre);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedItem != null)
            {
                string nombreItem = comboBoxItems.SelectedItem.ToString();
                int cantidad = (int)numCantidad.Value;

                inventario.RegistrarConsumo(nombreItem, cantidad); // Registrar el consumo

                MessageBox.Show("Consumo registrado correctamente.");
                this.Close(); // Cierra la ventana después de registrar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ítem."); // Mensaje si no selecciona un ítem
            }
        }
    }
}
