namespace SistemaVentas.Producto
{
    partial class frmAddProducto
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
            this.TDescripcion = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TPrecioCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Agregar Producto";
            // 
            // TDescripcion
            // 
            this.TDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.TDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TDescripcion.Location = new System.Drawing.Point(119, 206);
            this.TDescripcion.Name = "TDescripcion";
            this.TDescripcion.Size = new System.Drawing.Size(272, 20);
            this.TDescripcion.TabIndex = 22;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(116, 180);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(233, 23);
            this.lblNom.TabIndex = 21;
            this.lblNom.Text = "Descripcion:";
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.Control;
            this.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNombre.Location = new System.Drawing.Point(119, 159);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(272, 20);
            this.TNombre.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cantidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TCantidad
            // 
            this.TCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.TCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCantidad.Location = new System.Drawing.Point(118, 304);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(272, 20);
            this.TCantidad.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // TCodigo
            // 
            this.TCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.TCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TCodigo.Location = new System.Drawing.Point(118, 112);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(272, 20);
            this.TCodigo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Codigo:";
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(119, 256);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(272, 21);
            this.CBCategoria.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Categoria";
            // 
            // TPrecioCompra
            // 
            this.TPrecioCompra.BackColor = System.Drawing.SystemColors.Control;
            this.TPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPrecioCompra.Location = new System.Drawing.Point(119, 351);
            this.TPrecioCompra.Name = "TPrecioCompra";
            this.TPrecioCompra.Size = new System.Drawing.Size(272, 20);
            this.TPrecioCompra.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Precio compra:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Estado:";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(118, 398);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(272, 21);
            this.CBEstado.TabIndex = 33;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 16;
            this.btnAgregar.Location = new System.Drawing.Point(119, 434);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 32);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 16;
            this.btnCancelar.Location = new System.Drawing.Point(276, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 32);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAddProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(507, 512);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TPrecioCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDescripcion);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TDescripcion;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TPrecioCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBEstado;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}