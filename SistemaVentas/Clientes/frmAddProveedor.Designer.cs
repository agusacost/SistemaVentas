namespace SistemaVentas.Clientes
{
    partial class frmAddProveedor
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
            this.btnCancelarProv = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProv = new FontAwesome.Sharp.IconButton();
            this.RBInactivoProv = new System.Windows.Forms.RadioButton();
            this.RBActivoProv = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TRazonSocial = new System.Windows.Forms.TextBox();
            this.TCorreoProv = new System.Windows.Forms.TextBox();
            this.TTelefonoProv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TDNIProv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarProv
            // 
            this.btnCancelarProv.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarProv.ForeColor = System.Drawing.Color.White;
            this.btnCancelarProv.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelarProv.IconColor = System.Drawing.Color.White;
            this.btnCancelarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarProv.IconSize = 16;
            this.btnCancelarProv.Location = new System.Drawing.Point(367, 514);
            this.btnCancelarProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarProv.Name = "btnCancelarProv";
            this.btnCancelarProv.Size = new System.Drawing.Size(152, 39);
            this.btnCancelarProv.TabIndex = 56;
            this.btnCancelarProv.Text = "Cancelar";
            this.btnCancelarProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarProv.UseVisualStyleBackColor = false;
            this.btnCancelarProv.Click += new System.EventHandler(this.btnCancelarProv_Click);
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.BackColor = System.Drawing.Color.Green;
            this.btnAgregarProv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProv.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProv.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarProv.IconColor = System.Drawing.Color.White;
            this.btnAgregarProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProv.IconSize = 16;
            this.btnAgregarProv.Location = new System.Drawing.Point(157, 514);
            this.btnAgregarProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(152, 39);
            this.btnAgregarProv.TabIndex = 55;
            this.btnAgregarProv.Text = "Agregar";
            this.btnAgregarProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProv.UseVisualStyleBackColor = false;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // RBInactivoProv
            // 
            this.RBInactivoProv.AutoSize = true;
            this.RBInactivoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBInactivoProv.Location = new System.Drawing.Point(365, 459);
            this.RBInactivoProv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBInactivoProv.Name = "RBInactivoProv";
            this.RBInactivoProv.Size = new System.Drawing.Size(87, 24);
            this.RBInactivoProv.TabIndex = 54;
            this.RBInactivoProv.TabStop = true;
            this.RBInactivoProv.Text = "Inactivo";
            this.RBInactivoProv.UseVisualStyleBackColor = true;
            // 
            // RBActivoProv
            // 
            this.RBActivoProv.AutoSize = true;
            this.RBActivoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBActivoProv.Location = new System.Drawing.Point(211, 459);
            this.RBActivoProv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBActivoProv.Name = "RBActivoProv";
            this.RBActivoProv.Size = new System.Drawing.Size(76, 24);
            this.RBActivoProv.TabIndex = 53;
            this.RBActivoProv.TabStop = true;
            this.RBActivoProv.Text = "Activo";
            this.RBActivoProv.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 28);
            this.label6.TabIndex = 52;
            this.label6.Text = "Estado:";
            // 
            // TRazonSocial
            // 
            this.TRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.TRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TRazonSocial.Location = new System.Drawing.Point(157, 232);
            this.TRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.TRazonSocial.Name = "TRazonSocial";
            this.TRazonSocial.Size = new System.Drawing.Size(362, 22);
            this.TRazonSocial.TabIndex = 51;
            // 
            // TCorreoProv
            // 
            this.TCorreoProv.BackColor = System.Drawing.SystemColors.Control;
            this.TCorreoProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCorreoProv.Location = new System.Drawing.Point(157, 301);
            this.TCorreoProv.Margin = new System.Windows.Forms.Padding(4);
            this.TCorreoProv.Name = "TCorreoProv";
            this.TCorreoProv.Size = new System.Drawing.Size(362, 22);
            this.TCorreoProv.TabIndex = 50;
            // 
            // TTelefonoProv
            // 
            this.TTelefonoProv.BackColor = System.Drawing.SystemColors.Control;
            this.TTelefonoProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TTelefonoProv.Location = new System.Drawing.Point(157, 372);
            this.TTelefonoProv.Margin = new System.Windows.Forms.Padding(4);
            this.TTelefonoProv.Name = "TTelefonoProv";
            this.TTelefonoProv.Size = new System.Drawing.Size(362, 22);
            this.TTelefonoProv.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 28);
            this.label5.TabIndex = 48;
            this.label5.Text = "RazonSocial:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Telefono:";
            // 
            // TDNIProv
            // 
            this.TDNIProv.BackColor = System.Drawing.SystemColors.Control;
            this.TDNIProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDNIProv.Location = new System.Drawing.Point(157, 174);
            this.TDNIProv.Margin = new System.Windows.Forms.Padding(4);
            this.TDNIProv.Name = "TDNIProv";
            this.TDNIProv.Size = new System.Drawing.Size(362, 22);
            this.TDNIProv.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 28);
            this.label4.TabIndex = 44;
            this.label4.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 47);
            this.label3.TabIndex = 43;
            this.label3.Text = "Agregar Proovedor";
            // 
            // frmAddProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(676, 630);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarProv);
            this.Controls.Add(this.btnAgregarProv);
            this.Controls.Add(this.RBInactivoProv);
            this.Controls.Add(this.RBActivoProv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TRazonSocial);
            this.Controls.Add(this.TCorreoProv);
            this.Controls.Add(this.TTelefonoProv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDNIProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelarProv;
        private FontAwesome.Sharp.IconButton btnAgregarProv;
        private System.Windows.Forms.RadioButton RBInactivoProv;
        private System.Windows.Forms.RadioButton RBActivoProv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TRazonSocial;
        private System.Windows.Forms.TextBox TCorreoProv;
        private System.Windows.Forms.TextBox TTelefonoProv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TDNIProv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}