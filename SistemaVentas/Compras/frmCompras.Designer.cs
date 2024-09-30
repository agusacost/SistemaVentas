namespace SistemaVentas.Compras
{
    partial class frmCompras
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
            this.backLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.BRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.BLimpiarCompra = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBDocumentoC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TRazonSocialC = new System.Windows.Forms.TextBox();
            this.TNumeroDocumentoC = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CantidadC = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TPrecioVentaC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TPrecioCompraC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TProductoC = new System.Windows.Forms.TextBox();
            this.TCodProdC = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTotalAPagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.backLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backLabel.Location = new System.Drawing.Point(0, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(1223, 66);
            this.backLabel.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(51, 149);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(1121, 466);
            this.labelName.TabIndex = 14;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BRegistrarCompra
            // 
            this.BRegistrarCompra.BackColor = System.Drawing.Color.Teal;
            this.BRegistrarCompra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrarCompra.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.BRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BRegistrarCompra.IconColor = System.Drawing.Color.White;
            this.BRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BRegistrarCompra.IconSize = 16;
            this.BRegistrarCompra.Location = new System.Drawing.Point(1017, 555);
            this.BRegistrarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BRegistrarCompra.Name = "BRegistrarCompra";
            this.BRegistrarCompra.Size = new System.Drawing.Size(116, 44);
            this.BRegistrarCompra.TabIndex = 15;
            this.BRegistrarCompra.Text = "Registrar";
            this.BRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRegistrarCompra.UseVisualStyleBackColor = false;
            this.BRegistrarCompra.Click += new System.EventHandler(this.BRegistrarCompra_Click);
            // 
            // BLimpiarCompra
            // 
            this.BLimpiarCompra.BackColor = System.Drawing.Color.LightCoral;
            this.BLimpiarCompra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BLimpiarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLimpiarCompra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLimpiarCompra.ForeColor = System.Drawing.Color.White;
            this.BLimpiarCompra.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BLimpiarCompra.IconColor = System.Drawing.Color.White;
            this.BLimpiarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BLimpiarCompra.IconSize = 16;
            this.BLimpiarCompra.Location = new System.Drawing.Point(1055, 153);
            this.BLimpiarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BLimpiarCompra.Name = "BLimpiarCompra";
            this.BLimpiarCompra.Size = new System.Drawing.Size(107, 44);
            this.BLimpiarCompra.TabIndex = 16;
            this.BLimpiarCompra.Text = "Limpiar";
            this.BLimpiarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiarCompra.UseVisualStyleBackColor = false;
            this.BLimpiarCompra.Click += new System.EventHandler(this.BLimpiarCompra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Compra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.CBDocumentoC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DateFechaCompra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(57, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(548, 75);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Compra";
            // 
            // CBDocumentoC
            // 
            this.CBDocumentoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDocumentoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBDocumentoC.FormattingEnabled = true;
            this.CBDocumentoC.Location = new System.Drawing.Point(300, 38);
            this.CBDocumentoC.Margin = new System.Windows.Forms.Padding(4);
            this.CBDocumentoC.Name = "CBDocumentoC";
            this.CBDocumentoC.Size = new System.Drawing.Size(239, 24);
            this.CBDocumentoC.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo Documento:";
            // 
            // DateFechaCompra
            // 
            this.DateFechaCompra.Location = new System.Drawing.Point(12, 39);
            this.DateFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.DateFechaCompra.Name = "DateFechaCompra";
            this.DateFechaCompra.Size = new System.Drawing.Size(279, 22);
            this.DateFechaCompra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.TRazonSocialC);
            this.groupBox2.Controls.Add(this.TNumeroDocumentoC);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(613, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(548, 75);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(492, 11);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 22);
            this.textBox8.TabIndex = 33;
            // 
            // TRazonSocialC
            // 
            this.TRazonSocialC.Location = new System.Drawing.Point(263, 41);
            this.TRazonSocialC.Margin = new System.Windows.Forms.Padding(4);
            this.TRazonSocialC.Name = "TRazonSocialC";
            this.TRazonSocialC.Size = new System.Drawing.Size(276, 22);
            this.TRazonSocialC.TabIndex = 23;
            // 
            // TNumeroDocumentoC
            // 
            this.TNumeroDocumentoC.Location = new System.Drawing.Point(8, 39);
            this.TNumeroDocumentoC.Margin = new System.Windows.Forms.Padding(4);
            this.TNumeroDocumentoC.Name = "TNumeroDocumentoC";
            this.TNumeroDocumentoC.Size = new System.Drawing.Size(185, 22);
            this.TNumeroDocumentoC.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(201, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Razon Social";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numero de Documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.CantidadC);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TPrecioVentaC);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TPrecioCompraC);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.TProductoC);
            this.groupBox3.Controls.Add(this.TCodProdC);
            this.groupBox3.Controls.Add(this.iconButton1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(57, 286);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1104, 95);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // CantidadC
            // 
            this.CantidadC.Location = new System.Drawing.Point(804, 63);
            this.CantidadC.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadC.Name = "CantidadC";
            this.CantidadC.Size = new System.Drawing.Size(131, 22);
            this.CantidadC.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(800, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Cantidad:";
            // 
            // TPrecioVentaC
            // 
            this.TPrecioVentaC.Location = new System.Drawing.Point(676, 63);
            this.TPrecioVentaC.Margin = new System.Windows.Forms.Padding(4);
            this.TPrecioVentaC.Name = "TPrecioVentaC";
            this.TPrecioVentaC.Size = new System.Drawing.Size(119, 22);
            this.TPrecioVentaC.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Precio Venta:";
            // 
            // TPrecioCompraC
            // 
            this.TPrecioCompraC.Location = new System.Drawing.Point(548, 63);
            this.TPrecioCompraC.Margin = new System.Windows.Forms.Padding(4);
            this.TPrecioCompraC.Name = "TPrecioCompraC";
            this.TPrecioCompraC.Size = new System.Drawing.Size(119, 22);
            this.TPrecioCompraC.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio Compra:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 37);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 22);
            this.textBox5.TabIndex = 25;
            // 
            // TProductoC
            // 
            this.TProductoC.Location = new System.Drawing.Point(263, 63);
            this.TProductoC.Margin = new System.Windows.Forms.Padding(4);
            this.TProductoC.Name = "TProductoC";
            this.TProductoC.Size = new System.Drawing.Size(276, 22);
            this.TProductoC.TabIndex = 23;
            // 
            // TCodProdC
            // 
            this.TCodProdC.Location = new System.Drawing.Point(8, 63);
            this.TCodProdC.Margin = new System.Windows.Forms.Padding(4);
            this.TCodProdC.Name = "TCodProdC";
            this.TCodProdC.Size = new System.Drawing.Size(185, 22);
            this.TCodProdC.TabIndex = 22;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(201, 64);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(55, 23);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cod. Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(57, 388);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(935, 212);
            this.dataGridView1.TabIndex = 25;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Width = 125;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 125;
            // 
            // TTotalAPagar
            // 
            this.TTotalAPagar.Location = new System.Drawing.Point(1017, 524);
            this.TTotalAPagar.Margin = new System.Windows.Forms.Padding(4);
            this.TTotalAPagar.Name = "TTotalAPagar";
            this.TTotalAPagar.Size = new System.Drawing.Size(115, 22);
            this.TTotalAPagar.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1013, 505);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Total a pagar:";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 688);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TTotalAPagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BLimpiarCompra);
            this.Controls.Add(this.BRegistrarCompra);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.backLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCompras";
            this.Text = "Agregar Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label labelName;
        private FontAwesome.Sharp.IconButton BRegistrarCompra;
        private FontAwesome.Sharp.IconButton BLimpiarCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateFechaCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBDocumentoC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox TRazonSocialC;
        private System.Windows.Forms.TextBox TNumeroDocumentoC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TProductoC;
        private System.Windows.Forms.TextBox TCodProdC;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.NumericUpDown CantidadC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TPrecioVentaC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TPrecioCompraC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.TextBox TTotalAPagar;
        private System.Windows.Forms.Label label11;
    }
}