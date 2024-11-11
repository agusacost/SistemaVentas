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
            this.TtotalCompras = new System.Windows.Forms.Label();
            this.TTotalVentas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtTotalCompras = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGenerar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TtotalCompras
            // 
            this.TtotalCompras.BackColor = System.Drawing.SystemColors.Control;
            this.TtotalCompras.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtotalCompras.ForeColor = System.Drawing.Color.Crimson;
            this.TtotalCompras.Location = new System.Drawing.Point(457, 92);
            this.TtotalCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TtotalCompras.Name = "TtotalCompras";
            this.TtotalCompras.Size = new System.Drawing.Size(157, 50);
            this.TtotalCompras.TabIndex = 21;
            this.TtotalCompras.Text = "Total Compras";
            this.TtotalCompras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TTotalVentas
            // 
            this.TTotalVentas.BackColor = System.Drawing.SystemColors.Control;
            this.TTotalVentas.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTotalVentas.ForeColor = System.Drawing.Color.ForestGreen;
            this.TTotalVentas.Location = new System.Drawing.Point(302, 92);
            this.TTotalVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TTotalVentas.Name = "TTotalVentas";
            this.TTotalVentas.Size = new System.Drawing.Size(151, 50);
            this.TTotalVentas.TabIndex = 20;
            this.TTotalVentas.Text = "Total Ventas";
            this.TTotalVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(501, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Hasta:";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Location = new System.Drawing.Point(579, 66);
            this.dtFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaHasta.TabIndex = 17;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Location = new System.Drawing.Point(287, 66);
            this.dtFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtFechaDesde.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 59);
            this.label1.TabIndex = 15;
            // 
            // ChartCompras
            // 
            this.ChartCompras.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.ChartCompras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartCompras.Legends.Add(legend1);
            this.ChartCompras.Location = new System.Drawing.Point(5, 92);
            this.ChartCompras.Margin = new System.Windows.Forms.Padding(2);
            this.ChartCompras.Name = "ChartCompras";
            this.ChartCompras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartCompras.Series.Add(series1);
            this.ChartCompras.Size = new System.Drawing.Size(293, 472);
            this.ChartCompras.TabIndex = 23;
            this.ChartCompras.Text = "chart2";
            // 
            // ChartProductos
            // 
            this.ChartProductos.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.ChartProductos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartProductos.Legends.Add(legend2);
            this.ChartProductos.Location = new System.Drawing.Point(302, 144);
            this.ChartProductos.Margin = new System.Windows.Forms.Padding(2);
            this.ChartProductos.Name = "ChartProductos";
            this.ChartProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "GraficoTorta";
            this.ChartProductos.Series.Add(series2);
            this.ChartProductos.Size = new System.Drawing.Size(312, 420);
            this.ChartProductos.TabIndex = 24;
            this.ChartProductos.Text = "chart1";
            // 
            // ChartVentas
            // 
            this.ChartVentas.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.ChartVentas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartVentas.Legends.Add(legend3);
            this.ChartVentas.Location = new System.Drawing.Point(618, 92);
            this.ChartVentas.Margin = new System.Windows.Forms.Padding(2);
            this.ChartVentas.Name = "ChartVentas";
            this.ChartVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartVentas.Series.Add(series3);
            this.ChartVentas.Size = new System.Drawing.Size(293, 472);
            this.ChartVentas.TabIndex = 25;
            this.ChartVentas.Text = "chart3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(213, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(911, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Reportes Analiticos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalVentas.Location = new System.Drawing.Point(306, 112);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.ReadOnly = true;
            this.txtTotalVentas.Size = new System.Drawing.Size(147, 19);
            this.txtTotalVentas.TabIndex = 28;
            this.txtTotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCompras
            // 
            this.txtTotalCompras.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCompras.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalCompras.Location = new System.Drawing.Point(467, 112);
            this.txtTotalCompras.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCompras.Name = "txtTotalCompras";
            this.txtTotalCompras.ReadOnly = true;
            this.txtTotalCompras.Size = new System.Drawing.Size(147, 19);
            this.txtTotalCompras.TabIndex = 29;
            this.txtTotalCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 16;
            this.btnLimpiar.Location = new System.Drawing.Point(806, 11);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 36);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGenerar.IconColor = System.Drawing.Color.White;
            this.btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerar.IconSize = 16;
            this.btnGenerar.Location = new System.Drawing.Point(722, 11);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(80, 36);
            this.btnGenerar.TabIndex = 31;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 574);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTotalCompras);
            this.Controls.Add(this.txtTotalVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChartVentas);
            this.Controls.Add(this.ChartProductos);
            this.Controls.Add(this.ChartCompras);
            this.Controls.Add(this.TtotalCompras);
            this.Controls.Add(this.TTotalVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            ((System.ComponentModel.ISupportInitialize)(this.ChartCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TtotalCompras;
        private System.Windows.Forms.Label TTotalVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCompras;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.TextBox txtTotalCompras;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGenerar;
    }
}