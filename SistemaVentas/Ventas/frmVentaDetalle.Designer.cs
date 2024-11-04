namespace SistemaVentas.Ventas
{
    partial class frmVentaDetalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BLimpiarCompra = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txttipodoccompra = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnrodoc = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.backLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backLabel.Location = new System.Drawing.Point(0, 0);
            this.backLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(918, 54);
            this.backLabel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(60, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 413);
            this.label1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Detalle Venta";
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
            this.BLimpiarCompra.Location = new System.Drawing.Point(769, 107);
            this.BLimpiarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.BLimpiarCompra.Name = "BLimpiarCompra";
            this.BLimpiarCompra.Size = new System.Drawing.Size(80, 24);
            this.BLimpiarCompra.TabIndex = 41;
            this.BLimpiarCompra.Text = "Limpiar";
            this.BLimpiarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BLimpiarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiarCompra.UseVisualStyleBackColor = false;
            this.BLimpiarCompra.Click += new System.EventHandler(this.BLimpiarCompra_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(685, 107);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 24);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(530, 111);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(151, 20);
            this.txtBusqueda.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(425, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Numero de Venta:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.txttipodoccompra);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Location = new System.Drawing.Point(79, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(761, 81);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(518, 47);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(232, 20);
            this.txtusuario.TabIndex = 2;
            // 
            // txttipodoccompra
            // 
            this.txttipodoccompra.BackColor = System.Drawing.Color.White;
            this.txttipodoccompra.Location = new System.Drawing.Point(262, 47);
            this.txttipodoccompra.Margin = new System.Windows.Forms.Padding(2);
            this.txttipodoccompra.Name = "txttipodoccompra";
            this.txttipodoccompra.ReadOnly = true;
            this.txttipodoccompra.Size = new System.Drawing.Size(238, 20);
            this.txttipodoccompra.TabIndex = 1;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.White;
            this.txtfecha.Location = new System.Drawing.Point(14, 47);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(232, 20);
            this.txtfecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtnrodoc);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.txtDocumentoCliente);
            this.groupBox2.Location = new System.Drawing.Point(79, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(761, 81);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Numero de documento:";
            // 
            // txtnrodoc
            // 
            this.txtnrodoc.Location = new System.Drawing.Point(689, 47);
            this.txtnrodoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtnrodoc.Name = "txtnrodoc";
            this.txtnrodoc.Size = new System.Drawing.Size(60, 20);
            this.txtnrodoc.TabIndex = 2;
            this.txtnrodoc.Visible = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.White;
            this.txtNombreCliente.Location = new System.Drawing.Point(262, 47);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(238, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.BackColor = System.Drawing.Color.White;
            this.txtDocumentoCliente.Location = new System.Drawing.Point(14, 47);
            this.txtDocumentoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.ReadOnly = true;
            this.txtDocumentoCliente.Size = new System.Drawing.Size(232, 20);
            this.txtDocumentoCliente.TabIndex = 0;
            // 
            // dgvdata
            // 
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioVenta,
            this.Cantidad,
            this.Subtotal});
            this.dgvdata.Location = new System.Drawing.Point(79, 323);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(2);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(592, 179);
            this.dgvdata.TabIndex = 44;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
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
            // detalleBtn
            // 
            this.detalleBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.detalleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.detalleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detalleBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleBtn.ForeColor = System.Drawing.Color.White;
            this.detalleBtn.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.detalleBtn.IconColor = System.Drawing.Color.White;
            this.detalleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detalleBtn.IconSize = 16;
            this.detalleBtn.Location = new System.Drawing.Point(675, 478);
            this.detalleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.detalleBtn.Name = "detalleBtn";
            this.detalleBtn.Size = new System.Drawing.Size(163, 24);
            this.detalleBtn.TabIndex = 47;
            this.detalleBtn.Text = "Detalle";
            this.detalleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detalleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.detalleBtn.UseVisualStyleBackColor = false;
            this.detalleBtn.Click += new System.EventHandler(this.detalleBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(673, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Monto Total:";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Location = new System.Drawing.Point(675, 454);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(163, 20);
            this.txtMonto.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(673, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Monto cambio:";
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.Color.White;
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.Location = new System.Drawing.Point(675, 414);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(163, 20);
            this.txtCambio.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(673, 356);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Monto Pago:";
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.Color.White;
            this.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPago.Location = new System.Drawing.Point(675, 374);
            this.txtPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtPago.Name = "txtPago";
            this.txtPago.ReadOnly = true;
            this.txtPago.Size = new System.Drawing.Size(163, 20);
            this.txtPago.TabIndex = 51;
            // 
            // frmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 559);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.detalleBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BLimpiarCompra);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backLabel);
            this.Name = "frmVentaDetalle";
            this.Text = "frmVentaDetalle";
            this.Load += new System.EventHandler(this.frmVentaDetalle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BLimpiarCompra;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txttipodoccompra;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnrodoc;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton detalleBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}