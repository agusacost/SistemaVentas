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
            this.label6 = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
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
            this.btnCancelarProv.Location = new System.Drawing.Point(261, 391);
            this.btnCancelarProv.Name = "btnCancelarProv";
            this.btnCancelarProv.Size = new System.Drawing.Size(114, 32);
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
            this.btnAgregarProv.Location = new System.Drawing.Point(118, 391);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(114, 32);
            this.btnAgregarProv.TabIndex = 55;
            this.btnAgregarProv.Text = "Agregar";
            this.btnAgregarProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProv.UseVisualStyleBackColor = false;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "Estado:";
            // 
            // txtRSocial
            // 
            this.txtRSocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRSocial.Location = new System.Drawing.Point(118, 188);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(272, 20);
            this.txtRSocial.TabIndex = 51;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(118, 237);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(272, 20);
            this.txtCorreo.TabIndex = 50;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(118, 286);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 20);
            this.txtTelefono.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "RazonSocial:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Correo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Telefono:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDoc
            // 
            this.txtDoc.BackColor = System.Drawing.SystemColors.Control;
            this.txtDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDoc.Location = new System.Drawing.Point(118, 141);
            this.txtDoc.MaxLength = 8;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(272, 20);
            this.txtDoc.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Documento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 38);
            this.label3.TabIndex = 43;
            this.label3.Text = "Agregar Proovedor";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(118, 335);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 21);
            this.CBEstado.TabIndex = 58;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(341, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(49, 20);
            this.txtId.TabIndex = 59;
            // 
            // frmAddProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.btnCancelarProv);
            this.Controls.Add(this.btnAgregarProv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRSocial);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Proveedor";
            this.Load += new System.EventHandler(this.frmAddProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelarProv;
        private FontAwesome.Sharp.IconButton btnAgregarProv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.TextBox txtId;
    }
}