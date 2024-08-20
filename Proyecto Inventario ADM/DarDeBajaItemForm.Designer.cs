namespace ProyectoInventarioADM
{
    partial class DarDeBajaItemForm
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
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(13, 13);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(259, 21);
            this.comboBoxItems.TabIndex = 0;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Location = new System.Drawing.Point(13, 41);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(259, 23);
            this.btnDarBaja.TabIndex = 1;
            this.btnDarBaja.Text = "Dar de Baja";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // DarDeBajaItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.comboBoxItems);
            this.Name = "DarDeBajaItemForm";
            this.Text = "Dar de Baja Item";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button btnDarBaja;
    }
}
