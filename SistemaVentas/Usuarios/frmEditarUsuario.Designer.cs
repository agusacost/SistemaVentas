namespace SistemaVentas.Usuarios
{
    partial class frmEditarUsuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelarE = new FontAwesome.Sharp.IconButton();
            this.btnAgregarE = new FontAwesome.Sharp.IconButton();
            this.CBEstadoE = new System.Windows.Forms.ComboBox();
            this.CBRolE = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClaveConfE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClaveE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumentoE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Editar Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(484, 91);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 22);
            this.txtId.TabIndex = 37;
            this.txtId.Text = "0";
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnCancelarE
            // 
            this.btnCancelarE.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarE.ForeColor = System.Drawing.Color.White;
            this.btnCancelarE.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelarE.IconColor = System.Drawing.Color.White;
            this.btnCancelarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarE.IconSize = 16;
            this.btnCancelarE.Location = new System.Drawing.Point(373, 502);
            this.btnCancelarE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarE.Name = "btnCancelarE";
            this.btnCancelarE.Size = new System.Drawing.Size(152, 39);
            this.btnCancelarE.TabIndex = 36;
            this.btnCancelarE.Text = "Cancelar";
            this.btnCancelarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarE.UseVisualStyleBackColor = false;
            this.btnCancelarE.Click += new System.EventHandler(this.btnCancelarE_Click);
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.BackColor = System.Drawing.Color.Green;
            this.btnAgregarE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarE.ForeColor = System.Drawing.Color.White;
            this.btnAgregarE.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarE.IconColor = System.Drawing.Color.White;
            this.btnAgregarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarE.IconSize = 16;
            this.btnAgregarE.Location = new System.Drawing.Point(163, 502);
            this.btnAgregarE.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(152, 39);
            this.btnAgregarE.TabIndex = 35;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarE.UseVisualStyleBackColor = false;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // CBEstadoE
            // 
            this.CBEstadoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstadoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBEstadoE.FormattingEnabled = true;
            this.CBEstadoE.Location = new System.Drawing.Point(364, 450);
            this.CBEstadoE.Margin = new System.Windows.Forms.Padding(4);
            this.CBEstadoE.Name = "CBEstadoE";
            this.CBEstadoE.Size = new System.Drawing.Size(160, 24);
            this.CBEstadoE.TabIndex = 34;
            // 
            // CBRolE
            // 
            this.CBRolE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRolE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRolE.FormattingEnabled = true;
            this.CBRolE.Location = new System.Drawing.Point(163, 450);
            this.CBRolE.Margin = new System.Windows.Forms.Padding(4);
            this.CBRolE.Name = "CBRolE";
            this.CBRolE.Size = new System.Drawing.Size(160, 24);
            this.CBRolE.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 418);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Estado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Rol:";
            // 
            // txtClaveConfE
            // 
            this.txtClaveConfE.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveConfE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveConfE.Location = new System.Drawing.Point(163, 385);
            this.txtClaveConfE.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveConfE.Name = "txtClaveConfE";
            this.txtClaveConfE.PasswordChar = '*';
            this.txtClaveConfE.Size = new System.Drawing.Size(362, 22);
            this.txtClaveConfE.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Confirmar clave:";
            // 
            // txtClaveE
            // 
            this.txtClaveE.BackColor = System.Drawing.SystemColors.Control;
            this.txtClaveE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveE.Location = new System.Drawing.Point(163, 321);
            this.txtClaveE.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveE.Name = "txtClaveE";
            this.txtClaveE.PasswordChar = '*';
            this.txtClaveE.Size = new System.Drawing.Size(362, 22);
            this.txtClaveE.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Clave:";
            // 
            // txtDocumentoE
            // 
            this.txtDocumentoE.BackColor = System.Drawing.SystemColors.Control;
            this.txtDocumentoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentoE.Location = new System.Drawing.Point(163, 194);
            this.txtDocumentoE.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoE.Name = "txtDocumentoE";
            this.txtDocumentoE.Size = new System.Drawing.Size(362, 22);
            this.txtDocumentoE.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Numero de Documento:";
            // 
            // txtCorreoE
            // 
            this.txtCorreoE.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoE.Location = new System.Drawing.Point(163, 257);
            this.txtCorreoE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoE.Name = "txtCorreoE";
            this.txtCorreoE.Size = new System.Drawing.Size(362, 22);
            this.txtCorreoE.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Correo:";
            // 
            // txtNombreE
            // 
            this.txtNombreE.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreE.Location = new System.Drawing.Point(163, 127);
            this.txtNombreE.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(362, 22);
            this.txtNombreE.TabIndex = 22;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(159, 95);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(311, 28);
            this.lblNom.TabIndex = 21;
            this.lblNom.Text = "Nombre Completo:";
            // 
            // frmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(676, 630);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancelarE);
            this.Controls.Add(this.btnAgregarE);
            this.Controls.Add(this.CBEstadoE);
            this.Controls.Add(this.CBRolE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClaveConfE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClaveE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumentoE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreoE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuario";
            this.Load += new System.EventHandler(this.frmEditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton btnCancelarE;
        private FontAwesome.Sharp.IconButton btnAgregarE;
        private System.Windows.Forms.ComboBox CBEstadoE;
        private System.Windows.Forms.ComboBox CBRolE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClaveConfE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClaveE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumentoE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label lblNom;
    }
}