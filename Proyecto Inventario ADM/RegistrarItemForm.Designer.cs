namespace ProyectoInventarioADM
{
    partial class RegistrarItemForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombreItem;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;

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
            this.txtNombreItem = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombreItem = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreItem
            // 
            this.txtNombreItem.Location = new System.Drawing.Point(221, 65);
            this.txtNombreItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreItem.Name = "txtNombreItem";
            this.txtNombreItem.Size = new System.Drawing.Size(193, 20);
            this.txtNombreItem.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(221, 108);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(193, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(221, 154);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(193, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(279, 218);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 24);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblNombreItem
            // 
            this.lblNombreItem.AutoSize = true;
            this.lblNombreItem.Location = new System.Drawing.Point(128, 68);
            this.lblNombreItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreItem.Name = "lblNombreItem";
            this.lblNombreItem.Size = new System.Drawing.Size(87, 13);
            this.lblNombreItem.TabIndex = 4;
            this.lblNombreItem.Text = "Nombre del Ítem:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(128, 111);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(128, 157);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // RegistrarItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 294);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreItem);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombreItem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarItemForm";
            this.Text = "Registrar Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
