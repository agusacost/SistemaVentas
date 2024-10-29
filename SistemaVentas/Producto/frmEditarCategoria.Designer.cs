namespace SistemaVentas.Producto
{
    partial class frmEditarCategoria
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
            this.btnCancelarCatE = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCatE = new FontAwesome.Sharp.IconButton();
            this.TDescripcionCatE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEstadoE = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarCatE
            // 
            this.btnCancelarCatE.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarCatE.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCatE.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelarCatE.IconColor = System.Drawing.Color.White;
            this.btnCancelarCatE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCatE.IconSize = 16;
            this.btnCancelarCatE.Location = new System.Drawing.Point(256, 245);
            this.btnCancelarCatE.Name = "btnCancelarCatE";
            this.btnCancelarCatE.Size = new System.Drawing.Size(114, 32);
            this.btnCancelarCatE.TabIndex = 56;
            this.btnCancelarCatE.Text = "Cancelar";
            this.btnCancelarCatE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCatE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCatE.UseVisualStyleBackColor = false;
            this.btnCancelarCatE.Click += new System.EventHandler(this.btnCancelarCatE_Click);
            // 
            // btnAgregarCatE
            // 
            this.btnAgregarCatE.BackColor = System.Drawing.Color.Green;
            this.btnAgregarCatE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCatE.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCatE.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarCatE.IconColor = System.Drawing.Color.White;
            this.btnAgregarCatE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCatE.IconSize = 16;
            this.btnAgregarCatE.Location = new System.Drawing.Point(110, 245);
            this.btnAgregarCatE.Name = "btnAgregarCatE";
            this.btnAgregarCatE.Size = new System.Drawing.Size(114, 32);
            this.btnAgregarCatE.TabIndex = 55;
            this.btnAgregarCatE.Text = "Agregar";
            this.btnAgregarCatE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCatE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCatE.UseVisualStyleBackColor = false;
            this.btnAgregarCatE.Click += new System.EventHandler(this.btnAgregarCatE_Click);
            // 
            // TDescripcionCatE
            // 
            this.TDescripcionCatE.BackColor = System.Drawing.SystemColors.Control;
            this.TDescripcionCatE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDescripcionCatE.Location = new System.Drawing.Point(110, 152);
            this.TDescripcionCatE.Name = "TDescripcionCatE";
            this.TDescripcionCatE.Size = new System.Drawing.Size(272, 20);
            this.TDescripcionCatE.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 38);
            this.label3.TabIndex = 50;
            this.label3.Text = "Editar Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBEstadoE
            // 
            this.CBEstadoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstadoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBEstadoE.FormattingEnabled = true;
            this.CBEstadoE.Location = new System.Drawing.Point(110, 202);
            this.CBEstadoE.Name = "CBEstadoE";
            this.CBEstadoE.Size = new System.Drawing.Size(272, 21);
            this.CBEstadoE.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Estado";
            // 
            // frmEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.ControlBox = false;
            this.Controls.Add(this.CBEstadoE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarCatE);
            this.Controls.Add(this.btnAgregarCatE);
            this.Controls.Add(this.TDescripcionCatE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarCategoria";
            this.Load += new System.EventHandler(this.frmEditarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelarCatE;
        private FontAwesome.Sharp.IconButton btnAgregarCatE;
        private System.Windows.Forms.TextBox TDescripcionCatE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBEstadoE;
        private System.Windows.Forms.Label label7;
    }
}