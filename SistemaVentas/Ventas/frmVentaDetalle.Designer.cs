namespace SistemaVentas.Ventas
{
    partial class frmVentaDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vtaDetalle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vtaDetalle
            // 
            this.vtaDetalle.AutoSize = true;
            this.vtaDetalle.Location = new System.Drawing.Point(240, 115);
            this.vtaDetalle.Name = "vtaDetalle";
            this.vtaDetalle.Size = new System.Drawing.Size(55, 13);
            this.vtaDetalle.TabIndex = 0;
            this.vtaDetalle.Text = "vtaDetalle";
            // 
            // frmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vtaDetalle);
            this.Name = "frmVentaDetalle";
            this.Text = "frmVentaDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vtaDetalle;
    }
}