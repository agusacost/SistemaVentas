namespace SistemaVentas.Reportes
{
    partial class frmReporteVentas
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
            this.CBBuscarV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataVentas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CBClientesV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFechaFinV = new System.Windows.Forms.DateTimePicker();
            this.DateFechaInicioV = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IconoExcelC = new FontAwesome.Sharp.IconButton();
            this.IconoBusquedaV = new FontAwesome.Sharp.IconButton();
            this.IconoLimpiarV = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // CBBuscarV
            // 
            this.CBBuscarV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CBBuscarV.FormattingEnabled = true;
            this.CBBuscarV.Location = new System.Drawing.Point(836, 151);
            this.CBBuscarV.Name = "CBBuscarV";
            this.CBBuscarV.Size = new System.Drawing.Size(161, 24);
            this.CBBuscarV.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(753, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Buscar por:";
            // 
            // DataVentas
            // 
            this.DataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVentas.Location = new System.Drawing.Point(20, 181);
            this.DataVentas.Name = "DataVentas";
            this.DataVentas.RowHeadersWidth = 51;
            this.DataVentas.RowTemplate.Height = 24;
            this.DataVentas.Size = new System.Drawing.Size(1143, 294);
            this.DataVentas.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1162, 368);
            this.label5.TabIndex = 22;
            // 
            // CBClientesV
            // 
            this.CBClientesV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CBClientesV.FormattingEnabled = true;
            this.CBClientesV.Location = new System.Drawing.Point(836, 66);
            this.CBClientesV.Name = "CBClientesV";
            this.CBClientesV.Size = new System.Drawing.Size(161, 24);
            this.CBClientesV.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha Inicio:";
            // 
            // DateFechaFinV
            // 
            this.DateFechaFinV.Location = new System.Drawing.Point(500, 68);
            this.DateFechaFinV.Name = "DateFechaFinV";
            this.DateFechaFinV.Size = new System.Drawing.Size(247, 22);
            this.DateFechaFinV.TabIndex = 17;
            // 
            // DateFechaInicioV
            // 
            this.DateFechaInicioV.CustomFormat = "";
            this.DateFechaInicioV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateFechaInicioV.Location = new System.Drawing.Point(144, 71);
            this.DateFechaInicioV.Name = "DateFechaInicioV";
            this.DateFechaInicioV.Size = new System.Drawing.Size(252, 22);
            this.DateFechaInicioV.TabIndex = 16;
            this.DateFechaInicioV.ValueChanged += new System.EventHandler(this.DateFechaInicioV_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1162, 99);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reporte Ventas";
            // 
            // IconoExcelC
            // 
            this.IconoExcelC.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IconoExcelC.IconColor = System.Drawing.Color.Black;
            this.IconoExcelC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoExcelC.IconSize = 35;
            this.IconoExcelC.Location = new System.Drawing.Point(20, 136);
            this.IconoExcelC.Name = "IconoExcelC";
            this.IconoExcelC.Size = new System.Drawing.Size(170, 43);
            this.IconoExcelC.TabIndex = 28;
            this.IconoExcelC.Text = "Descargar excel:";
            this.IconoExcelC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconoExcelC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconoExcelC.UseVisualStyleBackColor = true;
            this.IconoExcelC.Click += new System.EventHandler(this.IconoExcelC_Click);
            // 
            // IconoBusquedaV
            // 
            this.IconoBusquedaV.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IconoBusquedaV.IconColor = System.Drawing.Color.Black;
            this.IconoBusquedaV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoBusquedaV.IconSize = 35;
            this.IconoBusquedaV.Location = new System.Drawing.Point(1003, 140);
            this.IconoBusquedaV.Name = "IconoBusquedaV";
            this.IconoBusquedaV.Size = new System.Drawing.Size(49, 41);
            this.IconoBusquedaV.TabIndex = 27;
            this.IconoBusquedaV.UseVisualStyleBackColor = true;
            // 
            // IconoLimpiarV
            // 
            this.IconoLimpiarV.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.IconoLimpiarV.IconColor = System.Drawing.Color.Black;
            this.IconoLimpiarV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoLimpiarV.IconSize = 35;
            this.IconoLimpiarV.Location = new System.Drawing.Point(1079, 138);
            this.IconoLimpiarV.Name = "IconoLimpiarV";
            this.IconoLimpiarV.Size = new System.Drawing.Size(49, 41);
            this.IconoLimpiarV.TabIndex = 26;
            this.IconoLimpiarV.UseVisualStyleBackColor = true;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1411, 688);
            this.Controls.Add(this.IconoExcelC);
            this.Controls.Add(this.IconoBusquedaV);
            this.Controls.Add(this.IconoLimpiarV);
            this.Controls.Add(this.CBBuscarV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataVentas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBClientesV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateFechaFinV);
            this.Controls.Add(this.DateFechaInicioV);
            this.Controls.Add(this.label1);
            this.Name = "frmReporteVentas";
            this.Text = "frmReporteVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DataVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton IconoExcelC;
        private FontAwesome.Sharp.IconButton IconoBusquedaV;
        private FontAwesome.Sharp.IconButton IconoLimpiarV;
        private System.Windows.Forms.ComboBox CBBuscarV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBClientesV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateFechaFinV;
        private System.Windows.Forms.DateTimePicker DateFechaInicioV;
        private System.Windows.Forms.Label label1;
    }
}