﻿namespace SistemaVentas.Reportes
{
    partial class frmReporte
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
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataCompras = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CBProveedorC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFechaFinC = new System.Windows.Forms.DateTimePicker();
            this.DateFechaInicioC = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IconoExcelC = new FontAwesome.Sharp.IconButton();
            this.IconoBusquedaC = new FontAwesome.Sharp.IconButton();
            this.IconoLimpiarC = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // CBBuscar
            // 
            this.CBBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Location = new System.Drawing.Point(836, 151);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(161, 24);
            this.CBBuscar.TabIndex = 25;
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
            // DataCompras
            // 
            this.DataCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCompras.Location = new System.Drawing.Point(20, 181);
            this.DataCompras.Name = "DataCompras";
            this.DataCompras.RowHeadersWidth = 51;
            this.DataCompras.RowTemplate.Height = 24;
            this.DataCompras.Size = new System.Drawing.Size(1143, 294);
            this.DataCompras.TabIndex = 23;
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
            // CBProveedorC
            // 
            this.CBProveedorC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CBProveedorC.FormattingEnabled = true;
            this.CBProveedorC.Location = new System.Drawing.Point(836, 69);
            this.CBProveedorC.Name = "CBProveedorC";
            this.CBProveedorC.Size = new System.Drawing.Size(161, 24);
            this.CBProveedorC.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(739, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 69);
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
            // DateFechaFinC
            // 
            this.DateFechaFinC.Location = new System.Drawing.Point(472, 69);
            this.DateFechaFinC.Name = "DateFechaFinC";
            this.DateFechaFinC.Size = new System.Drawing.Size(245, 22);
            this.DateFechaFinC.TabIndex = 17;
            this.DateFechaFinC.ValueChanged += new System.EventHandler(this.DateFechaFinC_ValueChanged);
            // 
            // DateFechaInicioC
            // 
            this.DateFechaInicioC.CustomFormat = "";
            this.DateFechaInicioC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DateFechaInicioC.Location = new System.Drawing.Point(131, 71);
            this.DateFechaInicioC.Name = "DateFechaInicioC";
            this.DateFechaInicioC.Size = new System.Drawing.Size(246, 22);
            this.DateFechaInicioC.TabIndex = 16;
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
            this.label1.Text = "Reporte Compras";
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
            // 
            // IconoBusquedaC
            // 
            this.IconoBusquedaC.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.IconoBusquedaC.IconColor = System.Drawing.Color.Black;
            this.IconoBusquedaC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoBusquedaC.IconSize = 35;
            this.IconoBusquedaC.Location = new System.Drawing.Point(1003, 140);
            this.IconoBusquedaC.Name = "IconoBusquedaC";
            this.IconoBusquedaC.Size = new System.Drawing.Size(49, 41);
            this.IconoBusquedaC.TabIndex = 27;
            this.IconoBusquedaC.UseVisualStyleBackColor = true;
            // 
            // IconoLimpiarC
            // 
            this.IconoLimpiarC.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.IconoLimpiarC.IconColor = System.Drawing.Color.Black;
            this.IconoLimpiarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoLimpiarC.IconSize = 35;
            this.IconoLimpiarC.Location = new System.Drawing.Point(1079, 138);
            this.IconoLimpiarC.Name = "IconoLimpiarC";
            this.IconoLimpiarC.Size = new System.Drawing.Size(49, 41);
            this.IconoLimpiarC.TabIndex = 26;
            this.IconoLimpiarC.UseVisualStyleBackColor = true;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1411, 688);
            this.Controls.Add(this.IconoExcelC);
            this.Controls.Add(this.IconoBusquedaC);
            this.Controls.Add(this.IconoLimpiarC);
            this.Controls.Add(this.CBBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataCompras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBProveedorC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateFechaFinC);
            this.Controls.Add(this.DateFechaInicioC);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            ((System.ComponentModel.ISupportInitialize)(this.DataCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton IconoExcelC;
        private FontAwesome.Sharp.IconButton IconoBusquedaC;
        private FontAwesome.Sharp.IconButton IconoLimpiarC;
        private System.Windows.Forms.ComboBox CBBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBProveedorC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateFechaFinC;
        private System.Windows.Forms.DateTimePicker DateFechaInicioC;
        private System.Windows.Forms.Label label1;
    }
}