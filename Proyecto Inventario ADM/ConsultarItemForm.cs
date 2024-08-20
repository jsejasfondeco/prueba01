using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class ConsultarItemForm : Form
    {
        private Inventario inventario;

        public ConsultarItemForm(Inventario inventario)
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
                if (!comboBoxItems.Items.Contains(item.Nombre))
                {
                    comboBoxItems.Items.Add(item.Nombre);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedItem != null)
            {
                string nombreItem = comboBoxItems.SelectedItem.ToString();
                Item item = inventario.ConsultarItem(nombreItem);

                if (item != null)
                {
                    dataGridViewDetalles.Rows.Clear();

                    // Añadir fila con los valores correspondientes
                    dataGridViewDetalles.Rows.Add(item.Nombre, item.Cantidad, item.Precio,
                        item.FechaRegistro, item.CantidadMesAnterior, item.CostoCompraUnitarioMesAnterior,
                        item.TotalBs, item.TotalProductoInventario, item.TotalBsCompraMesAnterior,
                        item.TotalConsumo, item.CompraMes, item.PromedioPonderado); // Mostrar el promedio ponderado
                }
                else
                {
                    MessageBox.Show("Item no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un ítem.");
            }
        }
    }
}
