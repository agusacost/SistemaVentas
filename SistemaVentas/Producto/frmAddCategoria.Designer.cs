namespace SistemaVentas.Producto
{
    partial class frmAddCategoria
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
            this.btnCancelarCat = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCat = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarCat.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCat.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelarCat.IconColor = System.Drawing.Color.White;
            this.btnCancelarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCat.IconSize = 16;
            this.btnCancelarCat.Location = new System.Drawing.Point(260, 240);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(114, 32);
            this.btnCancelarCat.TabIndex = 49;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCat.UseVisualStyleBackColor = false;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.Green;
            this.btnAgregarCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCat.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCat.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarCat.IconColor = System.Drawing.Color.White;
            this.btnAgregarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCat.IconSize = 16;
            this.btnAgregarCat.Location = new System.Drawing.Point(118, 240);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(114, 32);
            this.btnAgregarCat.TabIndex = 48;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(118, 146);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 20);
            this.txtDescripcion.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 38);
            this.label3.TabIndex = 43;
            this.label3.Text = "Agregar Categoria";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(194, 202);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 21);
            this.CBEstado.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "Estado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(354, 120);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 52;
            this.txtId.Visible = false;
            // 
            // frmAddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCategoria";
            this.Load += new System.EventHandler(this.frmAddCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelarCat;
        private FontAwesome.Sharp.IconButton btnAgregarCat;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
    }
}