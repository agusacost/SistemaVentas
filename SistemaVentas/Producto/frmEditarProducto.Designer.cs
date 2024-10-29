namespace SistemaVentas.Producto
{
    partial class frmEditarProducto
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
            this.btnCancelarProdE = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProdE = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.CBEstadoE = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBCategoriaE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TNombreE = new System.Windows.Forms.TextBox();
            this.TDescripcionE = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelarProdE
            // 
            this.btnCancelarProdE.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelarProdE.ForeColor = System.Drawing.Color.White;
            this.btnCancelarProdE.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelarProdE.IconColor = System.Drawing.Color.White;
            this.btnCancelarProdE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarProdE.IconSize = 16;
            this.btnCancelarProdE.Location = new System.Drawing.Point(277, 365);
            this.btnCancelarProdE.Name = "btnCancelarProdE";
            this.btnCancelarProdE.Size = new System.Drawing.Size(114, 32);
            this.btnCancelarProdE.TabIndex = 53;
            this.btnCancelarProdE.Text = "Cancelar";
            this.btnCancelarProdE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarProdE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarProdE.UseVisualStyleBackColor = false;
            this.btnCancelarProdE.Click += new System.EventHandler(this.btnCancelarProdE_Click);
            // 
            // btnAgregarProdE
            // 
            this.btnAgregarProdE.BackColor = System.Drawing.Color.Green;
            this.btnAgregarProdE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProdE.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProdE.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarProdE.IconColor = System.Drawing.Color.White;
            this.btnAgregarProdE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProdE.IconSize = 16;
            this.btnAgregarProdE.Location = new System.Drawing.Point(120, 365);
            this.btnAgregarProdE.Name = "btnAgregarProdE";
            this.btnAgregarProdE.Size = new System.Drawing.Size(114, 32);
            this.btnAgregarProdE.TabIndex = 52;
            this.btnAgregarProdE.Text = "Agregar";
            this.btnAgregarProdE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProdE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProdE.UseVisualStyleBackColor = false;
            this.btnAgregarProdE.Click += new System.EventHandler(this.btnAgregarProdE_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Estado:";
            // 
            // CBEstadoE
            // 
            this.CBEstadoE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstadoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBEstadoE.FormattingEnabled = true;
            this.CBEstadoE.Location = new System.Drawing.Point(119, 327);
            this.CBEstadoE.Name = "CBEstadoE";
            this.CBEstadoE.Size = new System.Drawing.Size(272, 21);
            this.CBEstadoE.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Categoria";
            // 
            // CBCategoriaE
            // 
            this.CBCategoriaE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoriaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBCategoriaE.FormattingEnabled = true;
            this.CBCategoriaE.Location = new System.Drawing.Point(120, 218);
            this.CBCategoriaE.Name = "CBCategoriaE";
            this.CBCategoriaE.Size = new System.Drawing.Size(272, 21);
            this.CBCategoriaE.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre";
            // 
            // TNombreE
            // 
            this.TNombreE.BackColor = System.Drawing.SystemColors.Control;
            this.TNombreE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNombreE.Location = new System.Drawing.Point(120, 121);
            this.TNombreE.Name = "TNombreE";
            this.TNombreE.Size = new System.Drawing.Size(272, 20);
            this.TNombreE.TabIndex = 41;
            // 
            // TDescripcionE
            // 
            this.TDescripcionE.BackColor = System.Drawing.SystemColors.Control;
            this.TDescripcionE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDescripcionE.Location = new System.Drawing.Point(120, 169);
            this.TDescripcionE.Name = "TDescripcionE";
            this.TDescripcionE.Size = new System.Drawing.Size(272, 20);
            this.TDescripcionE.TabIndex = 39;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(117, 143);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(233, 23);
            this.lblNom.TabIndex = 38;
            this.lblNom.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 38);
            this.label3.TabIndex = 37;
            this.label3.Text = "Editar Producto";
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(119, 268);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(272, 21);
            this.cbProveedor.TabIndex = 54;
            // 
            // frmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.ControlBox = false;
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.btnCancelarProdE);
            this.Controls.Add(this.btnAgregarProdE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBEstadoE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBCategoriaE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNombreE);
            this.Controls.Add(this.TDescripcionE);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.frmEditarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelarProdE;
        private FontAwesome.Sharp.IconButton btnAgregarProdE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBEstadoE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBCategoriaE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNombreE;
        private System.Windows.Forms.TextBox TDescripcionE;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedor;
    }
}