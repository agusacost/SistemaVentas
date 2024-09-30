using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaVentas.Reportes
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }
        private void ConfigurarGraficoVentas()
        {
            Dictionary<string, decimal> datosVentas = new Dictionary<string, decimal>()
    {
        { "2024-09-25", 50m },
        { "2024-09-26", 30m },
        { "2024-09-27", 70m },
        { "2024-09-28", 100m },
        { "2024-09-29", 40m }
    };

            decimal totalventas = 0;

            ChartVentas.Series.Clear();
            Series seriesVentas = new Series("Ventas");
            seriesVentas.ChartType = SeriesChartType.Column;

            // Configurar estilo de las etiquetas
            seriesVentas.IsValueShownAsLabel = true;  // Mostrar los valores en las barras
            seriesVentas.Font = new Font("Arial", 10, FontStyle.Bold);  // Cambiar estilo de fuente
            seriesVentas.LabelForeColor = Color.Black;  // Cambiar color de las etiquetas

            // Agregar los puntos al gráfico y suma total
            foreach (var venta in datosVentas)
            {
                seriesVentas.Points.AddXY(venta.Key, venta.Value);
                totalventas += venta.Value;
            }
            TTotalVentas.Text = $"Total Ventas: {totalventas:C}";

            // Configurar eje X para que se vea más limpio
            ChartVentas.ChartAreas[0].AxisX.Interval = 1;
            ChartVentas.ChartAreas[0].AxisX.LabelStyle.Angle = -45;  // Girar etiquetas del eje X
            ChartVentas.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            ChartVentas.Series.Add(seriesVentas);
        }

        public void ConfigurarGraficoCompras()
        {
            Dictionary<string, decimal> datosCompras = new Dictionary<string, decimal>()
    {
        { "2024-09-25", 40m },
        { "2024-09-26", 60m },
        { "2024-09-27", 20m },
        { "2024-09-28", 80m },
        { "2024-09-29", 50m }
    };
            decimal totalCompras = 0;
            ChartCompras.Series.Clear();
            Series seriesCompras = new Series("Compras");
            seriesCompras.ChartType = SeriesChartType.Column;

            // Configurar estilo de las etiquetas
            seriesCompras.IsValueShownAsLabel = true;  // Mostrar los valores en las barras
            seriesCompras.Font = new Font("Arial", 10, FontStyle.Bold);  // Cambiar estilo de fuente
            seriesCompras.LabelForeColor = Color.Black;  // Cambiar color de las etiquetas

            // Agregar los puntos al gráfico
            foreach (var compra in datosCompras)
            {
                seriesCompras.Points.AddXY(compra.Key, compra.Value);
                totalCompras += compra.Value;
            }
            TtotalCompras.Text = $"Total Compras: {totalCompras:C}";
            // Configurar eje X para que se vea más limpio
            ChartCompras.ChartAreas[0].AxisX.Interval = 1;
            ChartCompras.ChartAreas[0].AxisX.LabelStyle.Angle = -45;  // Girar etiquetas del eje X
            ChartCompras.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);

            ChartCompras.Series.Add(seriesCompras);
        }

        private void ConfigurarGraficoProductos()
        {
            Dictionary<string, decimal> datosProductos = new Dictionary<string, decimal>()
    {
        { "Producto A", 3m },
        { "Producto B", 5m },
        { "Producto C", 7m },
        { "Producto D", 4m }
    };

            ChartProductos.Series.Clear();
            Series seriesProductos = new Series("Productos");
            seriesProductos.ChartType = SeriesChartType.Pie;

            // Configurar estilo de las etiquetas
            seriesProductos.IsValueShownAsLabel = true;  // Mostrar los valores en los sectores
            seriesProductos.LabelForeColor = Color.Black;
            seriesProductos.Font = new Font("Arial", 6, FontStyle.Bold);  // Cambiar estilo de fuente
            seriesProductos.Label = "#VALX: #PERCENT{P0}";  // Mostrar el nombre del producto y el porcentaje

            // Agregar los puntos al gráfico
            foreach (var producto in datosProductos)
            {
                seriesProductos.Points.AddXY(producto.Key, producto.Value);
            }

            ChartProductos.Series.Add(seriesProductos);
        }

        private void BGenerarReporte_Click(object sender, EventArgs e)
        {
            ConfigurarGraficoVentas();
            ConfigurarGraficoCompras();
            ConfigurarGraficoProductos();
        }
    }
}
