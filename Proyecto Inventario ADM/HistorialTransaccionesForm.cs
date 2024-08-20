using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class HistorialTransaccionesForm : Form
    {
        private Inventario inventario;

        public HistorialTransaccionesForm(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
            CargarTransacciones();
        }

        private void CargarTransacciones()
        {
            listViewTransacciones.Items.Clear();
            foreach (var transaccion in inventario.ObtenerTransacciones())
            {
                ListViewItem item = new ListViewItem(transaccion.NombreItem);
                item.SubItems.Add(transaccion.Cantidad.ToString());
                item.SubItems.Add(transaccion.PrecioUnitario.ToString("C"));
                item.SubItems.Add(transaccion.Tipo.ToString());
                item.SubItems.Add(transaccion.Fecha.ToString());
                listViewTransacciones.Items.Add(item);
            }
        }
    }
}
