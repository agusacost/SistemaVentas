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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BGenerarReporte = new System.Windows.Forms.Button();
            this.TtotalCompras = new System.Windows.Forms.Label();
            this.TTotalVentas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // BGenerarReporte
            // 
            this.BGenerarReporte.BackColor = System.Drawing.Color.PowderBlue;
            this.BGenerarReporte.Location = new System.Drawing.Point(994, 45);
            this.BGenerarReporte.Name = "BGenerarReporte";
            this.BGenerarReporte.Size = new System.Drawing.Size(101, 41);
            this.BGenerarReporte.TabIndex = 22;
            this.BGenerarReporte.Text = "Generar Reporte";
            this.BGenerarReporte.UseVisualStyleBackColor = false;
            this.BGenerarReporte.Click += new System.EventHandler(this.BGenerarReporte_Click);
            // 
            // TtotalCompras
            // 
            this.TtotalCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TtotalCompras.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtotalCompras.ForeColor = System.Drawing.Color.Crimson;
            this.TtotalCompras.Location = new System.Drawing.Point(749, 139);
            this.TtotalCompras.Name = "TtotalCompras";
            this.TtotalCompras.Size = new System.Drawing.Size(154, 81);
            this.TtotalCompras.TabIndex = 21;
            this.TtotalCompras.Text = "Total Compras";
            this.TtotalCompras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TTotalVentas
            // 
            this.TTotalVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TTotalVentas.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTotalVentas.ForeColor = System.Drawing.Color.ForestGreen;
            this.TTotalVentas.Location = new System.Drawing.Point(455, 139);
            this.TTotalVentas.Name = "TTotalVentas";
            this.TTotalVentas.Size = new System.Drawing.Size(154, 81);
            this.TTotalVentas.TabIndex = 20;
            this.TTotalVentas.Text = "Total Ventas";
            this.TTotalVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(358, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha Desde:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(474, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1398, 85);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reportes Estadisticos";
            // 
            // ChartCompras
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartCompras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartCompras.Legends.Add(legend1);
            this.ChartCompras.Location = new System.Drawing.Point(28, 110);
            this.ChartCompras.Name = "ChartCompras";
            this.ChartCompras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartCompras.Series.Add(series1);
            this.ChartCompras.Size = new System.Drawing.Size(391, 528);
            this.ChartCompras.TabIndex = 23;
            this.ChartCompras.Text = "chart2";
            // 
            // ChartProductos
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartProductos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartProductos.Legends.Add(legend2);
            this.ChartProductos.Location = new System.Drawing.Point(535, 324);
            this.ChartProductos.Name = "ChartProductos";
            this.ChartProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "GraficoTorta";
            this.ChartProductos.Series.Add(series2);
            this.ChartProductos.Size = new System.Drawing.Size(282, 240);
            this.ChartProductos.TabIndex = 24;
            this.ChartProductos.Text = "chart1";
            // 
            // ChartVentas
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartVentas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartVentas.Legends.Add(legend3);
            this.ChartVentas.Location = new System.Drawing.Point(966, 110);
            this.ChartVentas.Name = "ChartVentas";
            this.ChartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartVentas.Series.Add(series3);
            this.ChartVentas.Size = new System.Drawing.Size(391, 528);
            this.ChartVentas.TabIndex = 25;
            this.ChartVentas.Text = "chart3";
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1411, 688);
            this.Controls.Add(this.ChartVentas);
            this.Controls.Add(this.ChartProductos);
            this.Controls.Add(this.ChartCompras);
            this.Controls.Add(this.BGenerarReporte);
            this.Controls.Add(this.TtotalCompras);
            this.Controls.Add(this.TTotalVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCompras;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVentas;
    }
}