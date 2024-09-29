namespace SistemaVentas.Clientes
{
    partial class frmEditProveedor
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
            this.btnCancelarProvE = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProvE = new FontAwesome.Sharp.IconButton();
            this.RBInactivoProvE = new System.Windows.Forms.RadioButton();
            this.RBActivoProvE = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TRazonSocialE = new System.Windows.Forms.TextBox();
            this.TCorreoProvE = new System.Windows.Forms.TextBox();
            this.TTelefonoProvE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TDNIProvE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarProvE
            // 
            this.btnCancelarProvE.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarProvE.ForeColor = System.Drawing.Color.White;
            this.btnCancelarProvE.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelarProvE.IconColor = System.Drawing.Color.White;
            this.btnCancelarProvE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarProvE.IconSize = 16;
            this.btnCancelarProvE.Location = new System.Drawing.Point(367, 511);
            this.btnCancelarProvE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarProvE.Name = "btnCancelarProvE";
            this.btnCancelarProvE.Size = new System.Drawing.Size(152, 39);
            this.btnCancelarProvE.TabIndex = 70;
            this.btnCancelarProvE.Text = "Cancelar";
            this.btnCancelarProvE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarProvE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarProvE.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProvE
            // 
            this.btnAgregarProvE.BackColor = System.Drawing.Color.Green;
            this.btnAgregarProvE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProvE.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProvE.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarProvE.IconColor = System.Drawing.Color.White;
            this.btnAgregarProvE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProvE.IconSize = 16;
            this.btnAgregarProvE.Location = new System.Drawing.Point(157, 511);
            this.btnAgregarProvE.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProvE.Name = "btnAgregarProvE";
            this.btnAgregarProvE.Size = new System.Drawing.Size(152, 39);
            this.btnAgregarProvE.TabIndex = 69;
            this.btnAgregarProvE.Text = "Agregar";
            this.btnAgregarProvE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProvE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProvE.UseVisualStyleBackColor = false;
            this.btnAgregarProvE.Click += new System.EventHandler(this.btnAgregarProvE_Click);
            // 
            // RBInactivoProvE
            // 
            this.RBInactivoProvE.AutoSize = true;
            this.RBInactivoProvE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBInactivoProvE.Location = new System.Drawing.Point(365, 456);
            this.RBInactivoProvE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBInactivoProvE.Name = "RBInactivoProvE";
            this.RBInactivoProvE.Size = new System.Drawing.Size(87, 24);
            this.RBInactivoProvE.TabIndex = 68;
            this.RBInactivoProvE.TabStop = true;
            this.RBInactivoProvE.Text = "Inactivo";
            this.RBInactivoProvE.UseVisualStyleBackColor = true;
            // 
            // RBActivoProvE
            // 
            this.RBActivoProvE.AutoSize = true;
            this.RBActivoProvE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBActivoProvE.Location = new System.Drawing.Point(211, 456);
            this.RBActivoProvE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBActivoProvE.Name = "RBActivoProvE";
            this.RBActivoProvE.Size = new System.Drawing.Size(76, 24);
            this.RBActivoProvE.TabIndex = 67;
            this.RBActivoProvE.TabStop = true;
            this.RBActivoProvE.Text = "Activo";
            this.RBActivoProvE.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 28);
            this.label6.TabIndex = 66;
            this.label6.Text = "Estado:";
            // 
            // TRazonSocialE
            // 
            this.TRazonSocialE.BackColor = System.Drawing.SystemColors.Control;
            this.TRazonSocialE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TRazonSocialE.Location = new System.Drawing.Point(157, 229);
            this.TRazonSocialE.Margin = new System.Windows.Forms.Padding(4);
            this.TRazonSocialE.Name = "TRazonSocialE";
            this.TRazonSocialE.Size = new System.Drawing.Size(362, 22);
            this.TRazonSocialE.TabIndex = 65;
            // 
            // TCorreoProvE
            // 
            this.TCorreoProvE.BackColor = System.Drawing.SystemColors.Control;
            this.TCorreoProvE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCorreoProvE.Location = new System.Drawing.Point(157, 298);
            this.TCorreoProvE.Margin = new System.Windows.Forms.Padding(4);
            this.TCorreoProvE.Name = "TCorreoProvE";
            this.TCorreoProvE.Size = new System.Drawing.Size(362, 22);
            this.TCorreoProvE.TabIndex = 64;
            // 
            // TTelefonoProvE
            // 
            this.TTelefonoProvE.BackColor = System.Drawing.SystemColors.Control;
            this.TTelefonoProvE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TTelefonoProvE.Location = new System.Drawing.Point(157, 369);
            this.TTelefonoProvE.Margin = new System.Windows.Forms.Padding(4);
            this.TTelefonoProvE.Name = "TTelefonoProvE";
            this.TTelefonoProvE.Size = new System.Drawing.Size(362, 22);
            this.TTelefonoProvE.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 28);
            this.label5.TabIndex = 62;
            this.label5.Text = "RazonSocial:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 28);
            this.label1.TabIndex = 60;
            this.label1.Text = "Telefono:";
            // 
            // TDNIProvE
            // 
            this.TDNIProvE.BackColor = System.Drawing.SystemColors.Control;
            this.TDNIProvE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDNIProvE.Location = new System.Drawing.Point(157, 171);
            this.TDNIProvE.Margin = new System.Windows.Forms.Padding(4);
            this.TDNIProvE.Name = "TDNIProvE";
            this.TDNIProvE.Size = new System.Drawing.Size(362, 22);
            this.TDNIProvE.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 28);
            this.label4.TabIndex = 58;
            this.label4.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 47);
            this.label3.TabIndex = 57;
            this.label3.Text = "Editar Proovedor";
            // 
            // frmEditProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(676, 630);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarProvE);
            this.Controls.Add(this.btnAgregarProvE);
            this.Controls.Add(this.RBInactivoProvE);
            this.Controls.Add(this.RBActivoProvE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TRazonSocialE);
            this.Controls.Add(this.TCorreoProvE);
            this.Controls.Add(this.TTelefonoProvE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDNIProvE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelarProvE;
        private FontAwesome.Sharp.IconButton btnAgregarProvE;
        private System.Windows.Forms.RadioButton RBInactivoProvE;
        private System.Windows.Forms.RadioButton RBActivoProvE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TRazonSocialE;
        private System.Windows.Forms.TextBox TCorreoProvE;
        private System.Windows.Forms.TextBox TTelefonoProvE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TDNIProvE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}