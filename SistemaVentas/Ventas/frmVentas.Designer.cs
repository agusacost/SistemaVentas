namespace SistemaVentas.Ventas
{
    partial class frmVentas
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
            this.label11 = new System.Windows.Forms.Label();
            this.TCambio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TCantidadProd = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.TProd = new System.Windows.Forms.TextBox();
            this.TCodProd = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.TNombreCliente = new System.Windows.Forms.TextBox();
            this.TDNICliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBTipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.BRegistrar = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.TPaga = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCantidadProd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.backLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backLabel.Location = new System.Drawing.Point(0, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(1411, 66);
            this.backLabel.TabIndex = 16;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(51, 149);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(1121, 466);
            this.labelName.TabIndex = 17;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(1013, 505);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cambio:";
            // 
            // TCambio
            // 
            this.TCambio.Location = new System.Drawing.Point(1017, 524);
            this.TCambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TCambio.Name = "TCambio";
            this.TCambio.Size = new System.Drawing.Size(115, 22);
            this.TCambio.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.TCantidadProd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TStock);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TPrecio);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.TProd);
            this.groupBox3.Controls.Add(this.TCodProd);
            this.groupBox3.Controls.Add(this.iconButton1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(57, 286);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1104, 95);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // TCantidadProd
            // 
            this.TCantidadProd.Location = new System.Drawing.Point(804, 63);
            this.TCantidadProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TCantidadProd.Name = "TCantidadProd";
            this.TCantidadProd.Size = new System.Drawing.Size(131, 22);
            this.TCantidadProd.TabIndex = 32;
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
            // TStock
            // 
            this.TStock.Location = new System.Drawing.Point(676, 63);
            this.TStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(119, 22);
            this.TStock.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Stock:";
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(548, 63);
            this.TPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(119, 22);
            this.TPrecio.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(147, 37);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(47, 22);
            this.textBox5.TabIndex = 25;
            // 
            // TProd
            // 
            this.TProd.Location = new System.Drawing.Point(263, 63);
            this.TProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TProd.Name = "TProd";
            this.TProd.Size = new System.Drawing.Size(276, 22);
            this.TProd.TabIndex = 23;
            // 
            // TCodProd
            // 
            this.TCodProd.Location = new System.Drawing.Point(8, 63);
            this.TCodProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TCodProd.Name = "TCodProd";
            this.TCodProd.Size = new System.Drawing.Size(185, 22);
            this.TCodProd.TabIndex = 22;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.TNombreCliente);
            this.groupBox2.Controls.Add(this.TDNICliente);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(613, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(548, 75);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(492, 11);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 22);
            this.textBox8.TabIndex = 33;
            // 
            // TNombreCliente
            // 
            this.TNombreCliente.Location = new System.Drawing.Point(263, 41);
            this.TNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TNombreCliente.Name = "TNombreCliente";
            this.TNombreCliente.Size = new System.Drawing.Size(276, 22);
            this.TNombreCliente.TabIndex = 23;
            // 
            // TDNICliente
            // 
            this.TDNICliente.Location = new System.Drawing.Point(8, 39);
            this.TDNICliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TDNICliente.Name = "TDNICliente";
            this.TDNICliente.Size = new System.Drawing.Size(185, 22);
            this.TDNICliente.TabIndex = 22;
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
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre Completo";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.CBTipoDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DateFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(57, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(548, 75);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // CBTipoDoc
            // 
            this.CBTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTipoDoc.FormattingEnabled = true;
            this.CBTipoDoc.Location = new System.Drawing.Point(300, 38);
            this.CBTipoDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBTipoDoc.Name = "CBTipoDoc";
            this.CBTipoDoc.Size = new System.Drawing.Size(239, 24);
            this.CBTipoDoc.TabIndex = 20;
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
            // DateFecha
            // 
            this.DateFecha.Location = new System.Drawing.Point(12, 39);
            this.DateFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(279, 22);
            this.DateFecha.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Registrar Venta";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 16;
            this.btnEliminar.Location = new System.Drawing.Point(1055, 153);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 44);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Limpiar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // BRegistrar
            // 
            this.BRegistrar.BackColor = System.Drawing.Color.Teal;
            this.BRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegistrar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrar.ForeColor = System.Drawing.Color.White;
            this.BRegistrar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BRegistrar.IconColor = System.Drawing.Color.White;
            this.BRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BRegistrar.IconSize = 16;
            this.BRegistrar.Location = new System.Drawing.Point(1017, 555);
            this.BRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BRegistrar.Name = "BRegistrar";
            this.BRegistrar.Size = new System.Drawing.Size(116, 44);
            this.BRegistrar.TabIndex = 28;
            this.BRegistrar.Text = "Registrar";
            this.BRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BRegistrar.UseVisualStyleBackColor = false;
            this.BRegistrar.Click += new System.EventHandler(this.BRegistrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(1013, 457);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Paga con:";
            // 
            // TPaga
            // 
            this.TPaga.Location = new System.Drawing.Point(1017, 476);
            this.TPaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TPaga.Name = "TPaga";
            this.TPaga.Size = new System.Drawing.Size(115, 22);
            this.TPaga.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(1013, 388);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Total a pagar:";
            // 
            // TTotal
            // 
            this.TTotal.Location = new System.Drawing.Point(1017, 407);
            this.TTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TTotal.Name = "TTotal";
            this.TTotal.Size = new System.Drawing.Size(115, 22);
            this.TTotal.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(57, 388);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(935, 212);
            this.dataGridView1.TabIndex = 41;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 125;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1411, 688);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TPaga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TCambio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BRegistrar);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.backLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCantidadProd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TCambio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown TCantidadProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TProd;
        private System.Windows.Forms.TextBox TCodProd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox TNombreCliente;
        private System.Windows.Forms.TextBox TDNICliente;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton BRegistrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TPaga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}