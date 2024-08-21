using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class DarDeBajaItemForm : Form
    {
        private Inventario inventario;

        public DarDeBajaItemForm(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
            CargarItems();
        }

        private void CargarItems()
        {
            comboBoxItems.Items.Clear();
            var items = inventario.ObtenerItems();
            foreach (var item in items)
            {
                comboBoxItems.Items.Add(item.Nombre);
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedItem != null)
            {
                string nombreItem = comboBoxItems.SelectedItem.ToString();
                inventario.EliminarItem(nombreItem);
                MessageBox.Show($"El ítem '{nombreItem}' ha sido dado de baja.");
                CargarItems();  // Refrescar la lista de ítems
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ítem para dar de baja.");
            }
        }
    }
}

