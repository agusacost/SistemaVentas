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
            this.menu2 = new System.Windows.Forms.MenuStrip();
            this.Usuario = new FontAwesome.Sharp.IconMenuItem();
            this.Configuracion = new FontAwesome.Sharp.IconMenuItem();
            this.Compras = new FontAwesome.Sharp.IconMenuItem();
            this.Ventas = new FontAwesome.Sharp.IconMenuItem();
            this.Clientes = new FontAwesome.Sharp.IconMenuItem();
            this.Proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.Reportes = new FontAwesome.Sharp.IconMenuItem();
            this.Acerca = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuario,
            this.Configuracion,
            this.Compras,
            this.Ventas,
            this.Clientes,
            this.Proveedores,
            this.Reportes,
            this.Acerca});
            this.menu2.Location = new System.Drawing.Point(0, 60);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(800, 71);
            this.menu2.TabIndex = 0;
            this.menu2.Text = "menuStrip1";
            this.menu2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu2_ItemClicked);
            // 
            // Usuario
            // 
            this.Usuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Usuario.IconColor = System.Drawing.Color.Black;
            this.Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(60, 67);
            this.Usuario.Text = "Usuario";
            this.Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuario.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // Configuracion
            // 
            this.Configuracion.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.Configuracion.IconColor = System.Drawing.Color.Black;
            this.Configuracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Configuracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Configuracion.Name = "Configuracion";
            this.Configuracion.Size = new System.Drawing.Size(95, 67);
            this.Configuracion.Text = "Configuracion";
            this.Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Configuracion.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // Compras
            // 
            this.Compras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.Compras.IconColor = System.Drawing.Color.Black;
            this.Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(67, 67);
            this.Compras.Text = "Compras";
            this.Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Compras.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // Ventas
            // 
            this.Ventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.Ventas.IconColor = System.Drawing.Color.Black;
            this.Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(60, 67);
            this.Ventas.Text = "Ventas";
            this.Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Clientes
            // 
            this.Clientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.Clientes.IconColor = System.Drawing.Color.Black;
            this.Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(61, 67);
            this.Clientes.Text = "Clientes";
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Proveedores
            // 
            this.Proveedores.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.Proveedores.IconColor = System.Drawing.Color.Black;
            this.Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(84, 67);
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Reportes
            // 
            this.Reportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.Reportes.IconColor = System.Drawing.Color.Black;
            this.Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(65, 67);
            this.Reportes.Text = "Reportes";
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Acerca
            // 
            this.Acerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.Acerca.IconColor = System.Drawing.Color.Black;
            this.Acerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Acerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(71, 67);
            this.Acerca.Text = "Acerca de";
            this.Acerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(800, 60);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 131);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(800, 319);
            this.Contenedor.TabIndex = 3;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu2;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu2.ResumeLayout(false);
            this.menu2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu2;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem Acerca;
        private FontAwesome.Sharp.IconMenuItem Usuario;
        private FontAwesome.Sharp.IconMenuItem Configuracion;
        private FontAwesome.Sharp.IconMenuItem Compras;
        private FontAwesome.Sharp.IconMenuItem Ventas;
        private FontAwesome.Sharp.IconMenuItem Clientes;
        private FontAwesome.Sharp.IconMenuItem Proveedores;
        private FontAwesome.Sharp.IconMenuItem Reportes;
        private System.Windows.Forms.Panel Contenedor;
    }
}

