using System;
using System.Windows.Forms;

namespace ProyectoInventarioADM
{
    public partial class MainForm : Form
    {
        private Inventario inventario;

        public MainForm()
        {
            InitializeComponent();
            inventario = new Inventario();
            ConfigurarTreeView(); // Configurar el TreeView
        }

        private void ConfigurarTreeView()
        {
            treeView1.Nodes.Clear();

            // Crear el nodo principal "INVENTARIO"
            TreeNode nodoInventario = new TreeNode("INVENTARIO");

            // Crear el subnodo "Sistemas" dentro de "INVENTARIO"
            TreeNode nodoSistemas = new TreeNode("Sistemas");

            // Añadir los módulos a "Sistemas"
            nodoSistemas.Nodes.Add("Registrar Item Nuevo");
            nodoSistemas.Nodes.Add("Dar de Baja Item");
            nodoSistemas.Nodes.Add("Consultar Item");
            nodoSistemas.Nodes.Add("Registrar Consumo");
            nodoSistemas.Nodes.Add("Historial de Transacciones");
            nodoSistemas.Nodes.Add("Registrar Compra");

            // Añadir "Sistemas" a "INVENTARIO"
            nodoInventario.Nodes.Add(nodoSistemas);

            // Añadir "INVENTARIO" al TreeView
            treeView1.Nodes.Add(nodoInventario);
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Registrar Item Nuevo":
                    RegistrarItemForm registrarForm = new RegistrarItemForm(inventario);
                    registrarForm.ShowDialog();
                    break;
                case "Dar de Baja Item":
                    DarDeBajaItemForm darBajaForm = new DarDeBajaItemForm(inventario);
                    darBajaForm.ShowDialog();
                    break;
                case "Consultar Item":
                    ConsultarItemForm consultarForm = new ConsultarItemForm(inventario);
                    consultarForm.ShowDialog();
                    break;
                case "Registrar Consumo":
                    RegistrarConsumoForm consumoForm = new RegistrarConsumoForm(inventario);
                    consumoForm.ShowDialog();
                    break;
                case "Historial de Transacciones":
                    HistorialTransaccionesForm historialForm = new HistorialTransaccionesForm(inventario);
                    historialForm.ShowDialog();
                    break;
                case "Registrar Compra":
                    RegistroCompraForm compraForm = new RegistroCompraForm(inventario);
                    compraForm.ShowDialog();
                    break;
            }
        }
    }
}
