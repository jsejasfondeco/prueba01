namespace ProyectoInventarioADM
{
    partial class ConsultarItemForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dataGridViewDetalles = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadMesAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostoCompraUnitarioMesAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalProductoInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalBsCompraMesAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalConsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompraMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromedioPonderado = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Nueva columna
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(9, 10);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(190, 21);
            this.comboBoxItems.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsultar.Location = new System.Drawing.Point(202, 10);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(56, 20);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dataGridViewDetalles
            // 
            this.dataGridViewDetalles.AllowUserToAddRows = false;
            this.dataGridViewDetalles.AllowUserToDeleteRows = false;
            this.dataGridViewDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colCantidad,
            this.colPrecio,
            this.colFechaRegistro,
            this.colCantidadMesAnterior,
            this.colCostoCompraUnitarioMesAnterior,
            this.colTotalBs,
            this.colTotalProductoInventario,
            this.colTotalBsCompraMesAnterior,
            this.colTotalConsumo,
            this.colCompraMes,
            this.colPromedioPonderado}); // Agregando la columna del Promedio Ponderado
            this.dataGridViewDetalles.Location = new System.Drawing.Point(9, 34);
            this.dataGridViewDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDetalles.Name = "dataGridViewDetalles";
            this.dataGridViewDetalles.ReadOnly = true;
            this.dataGridViewDetalles.RowHeadersVisible = false;
            this.dataGridViewDetalles.RowHeadersWidth = 51;
            this.dataGridViewDetalles.RowTemplate.Height = 24;
            this.dataGridViewDetalles.Size = new System.Drawing.Size(1117, 360);
            this.dataGridViewDetalles.TabIndex = 2;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.HeaderText = "Fecha Registro";
            this.colFechaRegistro.MinimumWidth = 6;
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.ReadOnly = true;
            // 
            // colCantidadMesAnterior
            // 
            this.colCantidadMesAnterior.HeaderText = "Cantidad Mes Anterior";
            this.colCantidadMesAnterior.MinimumWidth = 6;
            this.colCantidadMesAnterior.Name = "colCantidadMesAnterior";
            this.colCantidadMesAnterior.ReadOnly = true;
            // 
            // colCostoCompraUnitarioMesAnterior
            // 
            this.colCostoCompraUnitarioMesAnterior.HeaderText = "Costo Compra Unitario Mes Anterior";
            this.colCostoCompraUnitarioMesAnterior.MinimumWidth = 6;
            this.colCostoCompraUnitarioMesAnterior.Name = "colCostoCompraUnitarioMesAnterior";
            this.colCostoCompraUnitarioMesAnterior.ReadOnly = true;
            // 
            // colTotalBs
            // 
            this.colTotalBs.HeaderText = "Total Bs";
            this.colTotalBs.MinimumWidth = 6;
            this.colTotalBs.Name = "colTotalBs";
            this.colTotalBs.ReadOnly = true;
            // 
            // colTotalProductoInventario
            // 
            this.colTotalProductoInventario.HeaderText = "Total Producto Inventario";
            this.colTotalProductoInventario.MinimumWidth = 6;
            this.colTotalProductoInventario.Name = "colTotalProductoInventario";
            this.colTotalProductoInventario.ReadOnly = true;
            // 
            // colTotalBsCompraMesAnterior
            // 
            this.colTotalBsCompraMesAnterior.HeaderText = "Total Bs Compra Mes Anterior";
            this.colTotalBsCompraMesAnterior.MinimumWidth = 6;
            this.colTotalBsCompraMesAnterior.Name = "colTotalBsCompraMesAnterior";
            this.colTotalBsCompraMesAnterior.ReadOnly = true;
            // 
            // colTotalConsumo
            // 
            this.colTotalConsumo.HeaderText = "Total Consumo";
            this.colTotalConsumo.MinimumWidth = 6;
            this.colTotalConsumo.Name = "colTotalConsumo";
            this.colTotalConsumo.ReadOnly = true;
            // 
            // colCompraMes
            // 
            this.colCompraMes.HeaderText = "Compra del Mes";
            this.colCompraMes.MinimumWidth = 6;
            this.colCompraMes.Name = "colCompraMes";
            this.colCompraMes.ReadOnly = true;
            // 
            // colPromedioPonderado
            // 
            this.colPromedioPonderado.HeaderText = "Promedio Ponderado"; // Definiendo la columna Promedio Ponderado
            this.colPromedioPonderado.MinimumWidth = 6;
            this.colPromedioPonderado.Name = "colPromedioPonderado";
            this.colPromedioPonderado.ReadOnly = true;
            // 
            // ConsultarItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 406);
            this.Controls.Add(this.dataGridViewDetalles);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.comboBoxItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarItemForm";
            this.Text = "Consultar Item";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridViewDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadMesAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostoCompraUnitarioMesAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalProductoInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalBsCompraMesAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompraMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromedioPonderado; // Añadir la columna Promedio Ponderado
    }
}
