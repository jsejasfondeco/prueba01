namespace ProyectoInventarioADM
{
    partial class RegistrarConsumoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox comboBoxItems; // Se reemplazó el TextBox por un ComboBox
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnRegistrar;

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
            this.lblNombreItem = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox(); // Creación del ComboBox
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreItem
            // 
            this.lblNombreItem.AutoSize = true;
            this.lblNombreItem.Location = new System.Drawing.Point(12, 15);
            this.lblNombreItem.Name = "lblNombreItem";
            this.lblNombreItem.Size = new System.Drawing.Size(83, 13);
            this.lblNombreItem.TabIndex = 0;
            this.lblNombreItem.Text = "Nombre del Ítem";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 41);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // Se asegura que el usuario solo pueda seleccionar un ítem existente
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(101, 12);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(171, 21);
            this.comboBoxItems.TabIndex = 2; // Se asigna el ComboBox al formulario
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(101, 39);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(171, 20);
            this.numCantidad.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(101, 65);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // RegistrarConsumoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.comboBoxItems); // Asegúrate de agregar el ComboBox al formulario
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreItem);
            this.Name = "RegistrarConsumoForm";
            this.Text = "Registrar Consumo";
            this.Load += new System.EventHandler(this.RegistrarConsumoForm_Load); // Se agrega el evento Load para cargar los ítems
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
