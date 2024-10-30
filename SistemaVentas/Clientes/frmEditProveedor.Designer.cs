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
            this.label6 = new System.Windows.Forms.Label();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
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
            this.btnCancelarProvE.Location = new System.Drawing.Point(275, 415);
            this.btnCancelarProvE.Name = "btnCancelarProvE";
            this.btnCancelarProvE.Size = new System.Drawing.Size(114, 32);
            this.btnCancelarProvE.TabIndex = 70;
            this.btnCancelarProvE.Text = "Cancelar";
            this.btnCancelarProvE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarProvE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarProvE.UseVisualStyleBackColor = false;
            this.btnCancelarProvE.Click += new System.EventHandler(this.btnCancelarProvE_Click_1);
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
            this.btnAgregarProvE.Location = new System.Drawing.Point(118, 415);
            this.btnAgregarProvE.Name = "btnAgregarProvE";
            this.btnAgregarProvE.Size = new System.Drawing.Size(114, 32);
            this.btnAgregarProvE.TabIndex = 69;
            this.btnAgregarProvE.Text = "Agregar";
            this.btnAgregarProvE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProvE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProvE.UseVisualStyleBackColor = false;
            this.btnAgregarProvE.Click += new System.EventHandler(this.btnAgregarProvE_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 66;
            this.label6.Text = "Estado:";
            // 
            // txtRsocial
            // 
            this.txtRsocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRsocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRsocial.Location = new System.Drawing.Point(118, 186);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(272, 20);
            this.txtRsocial.TabIndex = 65;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(118, 242);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(272, 20);
            this.txtCorreo.TabIndex = 64;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(118, 300);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 20);
            this.txtTelefono.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "RazonSocial:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Telefono:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Location = new System.Drawing.Point(118, 139);
            this.txtDocumento.MaxLength = 11;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(272, 20);
            this.txtDocumento.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 38);
            this.label3.TabIndex = 57;
            this.label3.Text = "Editar Proovedor";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(118, 356);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(272, 21);
            this.CBEstado.TabIndex = 71;
            // 
            // frmEditProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.ControlBox = false;
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.btnCancelarProvE);
            this.Controls.Add(this.btnAgregarProvE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRsocial);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Proveedor";
            this.Load += new System.EventHandler(this.frmEditProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelarProvE;
        private FontAwesome.Sharp.IconButton btnAgregarProvE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRsocial;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBEstado;
    }
}