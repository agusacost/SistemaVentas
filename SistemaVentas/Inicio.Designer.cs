namespace SistemaVentas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ventasBercomatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Container = new System.Windows.Forms.Panel();
            this.labelTag = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.SettingsLabel = new FontAwesome.Sharp.IconMenuItem();
            this.subCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.subProducto = new FontAwesome.Sharp.IconMenuItem();
            this.UserLabel = new FontAwesome.Sharp.IconMenuItem();
            this.VentasLabel = new FontAwesome.Sharp.IconMenuItem();
            this.subRegistrarVta = new FontAwesome.Sharp.IconMenuItem();
            this.subDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.ComprasLabel = new FontAwesome.Sharp.IconMenuItem();
            this.subRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.ClientesLabel = new FontAwesome.Sharp.IconMenuItem();
            this.ProveedoresLabel = new FontAwesome.Sharp.IconMenuItem();
            this.ReportesLabel = new FontAwesome.Sharp.IconMenuItem();
            this.AcercaLabel = new FontAwesome.Sharp.IconMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightSlateGray;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasBercomatToolStripMenuItem,
            this.SettingsLabel,
            this.UserLabel,
            this.VentasLabel,
            this.ComprasLabel,
            this.ClientesLabel,
            this.ProveedoresLabel,
            this.ReportesLabel,
            this.AcercaLabel});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu.Size = new System.Drawing.Size(184, 697);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip2";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked_1);
            // 
            // ventasBercomatToolStripMenuItem
            // 
            this.ventasBercomatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasBercomatToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventasBercomatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.ventasBercomatToolStripMenuItem.Name = "ventasBercomatToolStripMenuItem";
            this.ventasBercomatToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.ventasBercomatToolStripMenuItem.Text = "Ventas Bercomat";
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(184, 0);
            this.Container.Margin = new System.Windows.Forms.Padding(4);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1229, 697);
            this.Container.TabIndex = 2;
            this.Container.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Paint);
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelTag.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.ForeColor = System.Drawing.Color.White;
            this.labelTag.Location = new System.Drawing.Point(16, 620);
            this.labelTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(72, 23);
            this.labelTag.TabIndex = 3;
            this.labelTag.Text = "Usuario:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(16, 640);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(59, 19);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "Usuario:";
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCategoria,
            this.subProducto});
            this.SettingsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.White;
            this.SettingsLabel.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.SettingsLabel.IconColor = System.Drawing.Color.White;
            this.SettingsLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsLabel.IconSize = 40;
            this.SettingsLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(173, 44);
            this.SettingsLabel.Text = "Mantenedor";
            // 
            // subCategoria
            // 
            this.subCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subCategoria.IconColor = System.Drawing.Color.Black;
            this.subCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subCategoria.Name = "subCategoria";
            this.subCategoria.Size = new System.Drawing.Size(168, 28);
            this.subCategoria.Text = "Categoria";
            this.subCategoria.Click += new System.EventHandler(this.subCategoria_Click);
            // 
            // subProducto
            // 
            this.subProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subProducto.IconColor = System.Drawing.Color.Black;
            this.subProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subProducto.Name = "subProducto";
            this.subProducto.Size = new System.Drawing.Size(168, 28);
            this.subProducto.Text = "Producto";
            this.subProducto.Click += new System.EventHandler(this.subProducto_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.UserLabel.IconColor = System.Drawing.Color.White;
            this.UserLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserLabel.IconSize = 40;
            this.UserLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UserLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(173, 44);
            this.UserLabel.Text = "Usuarios";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // VentasLabel
            // 
            this.VentasLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subRegistrarVta,
            this.subDetalleVenta});
            this.VentasLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasLabel.ForeColor = System.Drawing.Color.White;
            this.VentasLabel.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.VentasLabel.IconColor = System.Drawing.Color.White;
            this.VentasLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasLabel.IconSize = 40;
            this.VentasLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.VentasLabel.Name = "VentasLabel";
            this.VentasLabel.Size = new System.Drawing.Size(173, 44);
            this.VentasLabel.Text = "Ventas";
            // 
            // subRegistrarVta
            // 
            this.subRegistrarVta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subRegistrarVta.IconColor = System.Drawing.Color.Black;
            this.subRegistrarVta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subRegistrarVta.Name = "subRegistrarVta";
            this.subRegistrarVta.Size = new System.Drawing.Size(162, 28);
            this.subRegistrarVta.Text = "Registrar";
            this.subRegistrarVta.Click += new System.EventHandler(this.subRegistrarVta_Click);
            // 
            // subDetalleVenta
            // 
            this.subDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.subDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subDetalleVenta.Name = "subDetalleVenta";
            this.subDetalleVenta.Size = new System.Drawing.Size(162, 28);
            this.subDetalleVenta.Text = "Detalles";
            this.subDetalleVenta.Click += new System.EventHandler(this.subDetalleVenta_Click);
            // 
            // ComprasLabel
            // 
            this.ComprasLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subRegistrarCompra,
            this.subDetalleCompra});
            this.ComprasLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasLabel.ForeColor = System.Drawing.Color.White;
            this.ComprasLabel.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.ComprasLabel.IconColor = System.Drawing.Color.White;
            this.ComprasLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ComprasLabel.IconSize = 40;
            this.ComprasLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComprasLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ComprasLabel.Name = "ComprasLabel";
            this.ComprasLabel.Size = new System.Drawing.Size(173, 44);
            this.ComprasLabel.Text = "Compras";
            // 
            // subRegistrarCompra
            // 
            this.subRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.subRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subRegistrarCompra.Name = "subRegistrarCompra";
            this.subRegistrarCompra.Size = new System.Drawing.Size(162, 28);
            this.subRegistrarCompra.Text = "Registrar";
            this.subRegistrarCompra.Click += new System.EventHandler(this.subRegistrarCompra_Click);
            // 
            // subDetalleCompra
            // 
            this.subDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.subDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subDetalleCompra.Name = "subDetalleCompra";
            this.subDetalleCompra.Size = new System.Drawing.Size(162, 28);
            this.subDetalleCompra.Text = "Detalle";
            this.subDetalleCompra.Click += new System.EventHandler(this.subDetalleCompra_Click);
            // 
            // ClientesLabel
            // 
            this.ClientesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesLabel.ForeColor = System.Drawing.Color.White;
            this.ClientesLabel.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.ClientesLabel.IconColor = System.Drawing.Color.White;
            this.ClientesLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientesLabel.IconSize = 40;
            this.ClientesLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ClientesLabel.Name = "ClientesLabel";
            this.ClientesLabel.Size = new System.Drawing.Size(173, 44);
            this.ClientesLabel.Text = "Clientes";
            this.ClientesLabel.Click += new System.EventHandler(this.ClientesLabel_Click);
            // 
            // ProveedoresLabel
            // 
            this.ProveedoresLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedoresLabel.ForeColor = System.Drawing.Color.White;
            this.ProveedoresLabel.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.ProveedoresLabel.IconColor = System.Drawing.Color.White;
            this.ProveedoresLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProveedoresLabel.IconSize = 40;
            this.ProveedoresLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProveedoresLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ProveedoresLabel.Name = "ProveedoresLabel";
            this.ProveedoresLabel.Size = new System.Drawing.Size(173, 44);
            this.ProveedoresLabel.Text = "Proveedores";
            this.ProveedoresLabel.Click += new System.EventHandler(this.ProveedoresLabel_Click);
            // 
            // ReportesLabel
            // 
            this.ReportesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportesLabel.ForeColor = System.Drawing.Color.White;
            this.ReportesLabel.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ReportesLabel.IconColor = System.Drawing.Color.White;
            this.ReportesLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportesLabel.IconSize = 40;
            this.ReportesLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReportesLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ReportesLabel.Name = "ReportesLabel";
            this.ReportesLabel.Size = new System.Drawing.Size(173, 44);
            this.ReportesLabel.Text = "Reportes";
            this.ReportesLabel.Click += new System.EventHandler(this.ReportesLabel_Click);
            // 
            // AcercaLabel
            // 
            this.AcercaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcercaLabel.ForeColor = System.Drawing.Color.White;
            this.AcercaLabel.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.AcercaLabel.IconColor = System.Drawing.Color.White;
            this.AcercaLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AcercaLabel.IconSize = 40;
            this.AcercaLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AcercaLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.AcercaLabel.Name = "AcercaLabel";
            this.AcercaLabel.Size = new System.Drawing.Size(173, 44);
            this.AcercaLabel.Text = "Acerca de";
            this.AcercaLabel.Click += new System.EventHandler(this.AcercaLabel_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 697);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Bercomat";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ventasBercomatToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem SettingsLabel;
        private FontAwesome.Sharp.IconMenuItem UserLabel;
        private FontAwesome.Sharp.IconMenuItem VentasLabel;
        private FontAwesome.Sharp.IconMenuItem ComprasLabel;
        private FontAwesome.Sharp.IconMenuItem ClientesLabel;
        private FontAwesome.Sharp.IconMenuItem ProveedoresLabel;
        private FontAwesome.Sharp.IconMenuItem ReportesLabel;
        private FontAwesome.Sharp.IconMenuItem AcercaLabel;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label lbUsuario;
        private FontAwesome.Sharp.IconMenuItem subCategoria;
        private FontAwesome.Sharp.IconMenuItem subProducto;
        private FontAwesome.Sharp.IconMenuItem subRegistrarVta;
        private FontAwesome.Sharp.IconMenuItem subDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem subRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem subDetalleCompra;
    }
}

