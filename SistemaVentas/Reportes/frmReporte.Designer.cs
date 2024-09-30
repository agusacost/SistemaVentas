namespace SistemaVentas.Reportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BGenerarReporte = new System.Windows.Forms.Button();
            this.TtotalCompras = new System.Windows.Forms.Label();
            this.TTotalVentas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // BGenerarReporte
            // 
            this.BGenerarReporte.BackColor = System.Drawing.Color.Green;
            this.BGenerarReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.BGenerarReporte.Location = new System.Drawing.Point(1029, 12);
            this.BGenerarReporte.Name = "BGenerarReporte";
            this.BGenerarReporte.Size = new System.Drawing.Size(143, 41);
            this.BGenerarReporte.TabIndex = 22;
            this.BGenerarReporte.Text = "Generar Reporte";
            this.BGenerarReporte.UseVisualStyleBackColor = false;
            this.BGenerarReporte.Click += new System.EventHandler(this.BGenerarReporte_Click);
            // 
            // TtotalCompras
            // 
            this.TtotalCompras.BackColor = System.Drawing.SystemColors.Control;
            this.TtotalCompras.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtotalCompras.ForeColor = System.Drawing.Color.Crimson;
            this.TtotalCompras.Location = new System.Drawing.Point(627, 246);
            this.TtotalCompras.Name = "TtotalCompras";
            this.TtotalCompras.Size = new System.Drawing.Size(154, 81);
            this.TtotalCompras.TabIndex = 21;
            this.TtotalCompras.Text = "Total Compras";
            this.TtotalCompras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TTotalVentas
            // 
            this.TTotalVentas.BackColor = System.Drawing.SystemColors.Control;
            this.TTotalVentas.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTotalVentas.ForeColor = System.Drawing.Color.ForestGreen;
            this.TTotalVentas.Location = new System.Drawing.Point(454, 246);
            this.TTotalVentas.Name = "TTotalVentas";
            this.TTotalVentas.Size = new System.Drawing.Size(154, 81);
            this.TTotalVentas.TabIndex = 20;
            this.TTotalVentas.Text = "Total Ventas";
            this.TTotalVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(670, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Hasta:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(773, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1229, 73);
            this.label1.TabIndex = 15;
            // 
            // ChartCompras
            // 
            this.ChartCompras.BackColor = System.Drawing.SystemColors.Control;
            chartArea10.Name = "ChartArea1";
            this.ChartCompras.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.ChartCompras.Legends.Add(legend10);
            this.ChartCompras.Location = new System.Drawing.Point(15, 166);
            this.ChartCompras.Name = "ChartCompras";
            this.ChartCompras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.ChartCompras.Series.Add(series10);
            this.ChartCompras.Size = new System.Drawing.Size(391, 528);
            this.ChartCompras.TabIndex = 23;
            this.ChartCompras.Text = "chart2";
            // 
            // ChartProductos
            // 
            this.ChartProductos.BackColor = System.Drawing.SystemColors.Control;
            chartArea11.Name = "ChartArea1";
            this.ChartProductos.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.ChartProductos.Legends.Add(legend11);
            this.ChartProductos.Location = new System.Drawing.Point(459, 394);
            this.ChartProductos.Name = "ChartProductos";
            this.ChartProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "GraficoTorta";
            this.ChartProductos.Series.Add(series11);
            this.ChartProductos.Size = new System.Drawing.Size(303, 262);
            this.ChartProductos.TabIndex = 24;
            this.ChartProductos.Text = "chart1";
            // 
            // ChartVentas
            // 
            this.ChartVentas.BackColor = System.Drawing.SystemColors.Control;
            chartArea12.Name = "ChartArea1";
            this.ChartVentas.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.ChartVentas.Legends.Add(legend12);
            this.ChartVentas.Location = new System.Drawing.Point(812, 166);
            this.ChartVentas.Name = "ChartVentas";
            this.ChartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.ChartVentas.Series.Add(series12);
            this.ChartVentas.Size = new System.Drawing.Size(391, 528);
            this.ChartVentas.TabIndex = 25;
            this.ChartVentas.Text = "chart3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(286, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1230, 38);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lista de productos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 706);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChartVentas);
            this.Controls.Add(this.ChartProductos);
            this.Controls.Add(this.ChartCompras);
            this.Controls.Add(this.BGenerarReporte);
            this.Controls.Add(this.TtotalCompras);
            this.Controls.Add(this.TTotalVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            ((System.ComponentModel.ISupportInitialize)(this.ChartCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGenerarReporte;
        private System.Windows.Forms.Label TtotalCompras;
        private System.Windows.Forms.Label TTotalVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCompras;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}