using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Entidades;
using Negocio;

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
            // Limpiar los puntos de datos existentes y las series previas
            ChartVentas.Series.Clear();
            ChartVentas.Legends.Clear();

            // Crear una nueva leyenda para el gráfico
            Legend legend = new Legend("Ventas");
            ChartVentas.Legends.Add(legend);

            // Crear la serie para el gráfico
            Series series = new Series("Ventas Totales")
            {
                ChartType = SeriesChartType.Column, // Gráfico de columnas
                IsValueShownAsLabel = true, // Mostrar valores en las etiquetas
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            // Obtener los datos desde la capa de negocio
            List<DateTime> FechasV = new N_Reporte().FechasV(dtFechaDesde.Value, dtFechaHasta.Value);
            List<double> MontosV = new N_Reporte().MontosV(dtFechaDesde.Value, dtFechaHasta.Value);

            // Validar que ambas listas tengan la misma longitud
            if (FechasV.Count == MontosV.Count)
            {
                for (int i = 0; i < FechasV.Count; i++)
                {
                    // Evitar valores nulos o faltantes en los datos
                    if (FechasV[i] != null && MontosV[i] != null)
                    {
                        // Agregar cada punto a la serie
                        series.Points.AddXY(FechasV[i].ToString("dd/MM/yyyy"), MontosV[i]);
                    }
                }

                // Agregar la serie al gráfico
                ChartVentas.Series.Add(series);

                // Configurar el área del gráfico
                ChartVentas.ChartAreas[0].AxisX.Title = "Fecha";
                ChartVentas.ChartAreas[0].AxisY.Title = "Monto Total ($)";
                ChartVentas.ChartAreas[0].AxisX.Interval = 1; // Mostrar todas las etiquetas del eje X
                ChartVentas.ChartAreas[0].RecalculateAxesScale();

                // Establecer el formato de los valores en el eje Y
                ChartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "$0.00";
            }
            else
            {
                MessageBox.Show("Error: La cantidad de fechas y montos no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigurarGraficoCompras()
        {
            // Limpiar los puntos de datos existentes y las series previas
            ChartCompras.Series.Clear();
            ChartCompras.Legends.Clear();

            // Crear una nueva leyenda para el gráfico
            Legend legend = new Legend("Compras");
            ChartCompras.Legends.Add(legend);

            // Crear la serie para el gráfico
            Series series = new Series("Compras Totales")
            {
                ChartType = SeriesChartType.Column, // Gráfico de columnas
                IsValueShownAsLabel = true, // Mostrar valores en las etiquetas
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double
            };

            // Obtener los datos desde la capa de negocio
            List<DateTime> FechasC = new N_Reporte().FechasC(dtFechaDesde.Value, dtFechaHasta.Value);
            List<decimal> MontosC = new N_Reporte().MontosC(dtFechaDesde.Value, dtFechaHasta.Value);

            // Validar que ambas listas tengan la misma longitud
            if (FechasC.Count == MontosC.Count)
            {
                for (int i = 0; i < FechasC.Count; i++)
                {
                    // Evitar valores nulos o faltantes en los datos
                    if (FechasC[i] != null && MontosC[i] != null)
                    {
                        // Agregar cada punto a la serie (convertir la fecha a cadena con formato)
                        series.Points.AddXY(FechasC[i].ToString("dd/MM/yyyy"), MontosC[i]);
                    }
                }

                // Agregar la serie al gráfico
                ChartCompras.Series.Add(series);

                // Configurar el área del gráfico
                ChartCompras.ChartAreas[0].AxisX.Title = "Fecha";
                ChartCompras.ChartAreas[0].AxisY.Title = "Monto Total ($)";
                ChartCompras.ChartAreas[0].AxisX.Interval = 1; // Mostrar todas las etiquetas del eje X
                ChartCompras.ChartAreas[0].RecalculateAxesScale();

                // Establecer el formato de los valores en el eje Y
                ChartCompras.ChartAreas[0].AxisY.LabelStyle.Format = "$0.00";
            }
            else
            {
                MessageBox.Show("Error: La cantidad de fechas y montos no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigurarGraficoProductos()
        {
            try
            {
                // Obtenemos los productos y montos desde la capa de negocio
                List<string> productos = new N_Reporte().Productos(dtFechaDesde.Value, dtFechaHasta.Value);
                List<double> montos = new N_Reporte().MontosP(dtFechaDesde.Value, dtFechaHasta.Value);

                // Obtenemos los totales de ventas y compras
                double totalVentas = new N_Reporte().totalVentas(dtFechaDesde.Value, dtFechaHasta.Value);
                double totalCompras = new N_Reporte().totalCompras(dtFechaDesde.Value, dtFechaHasta.Value);

                // Actualizamos los textos de ventas y compras
                txtTotalVentas.Text = $"${totalVentas}";
                txtTotalCompras.Text = $"${totalCompras}";

                // Validamos que haya datos para el gráfico
                if (productos.Count > 0 && montos.Count > 0)
                {
                    // Limpiamos series anteriores
                    ChartProductos.Series.Clear();

                    // Creamos una nueva serie para el gráfico de torta
                    Series serie = new Series("Productos");
                    serie.ChartType = SeriesChartType.Pie; // Tipo de gráfico (torta)
                    serie.Points.DataBindXY(productos, montos); // Asignamos datos
                    serie.IsValueShownAsLabel = true; // Mostrar etiquetas de valores
                    serie.LabelFormat = "C"; // Formato de moneda para los montos
                    serie.LabelForeColor = Color.White; // Color del texto

                    ChartProductos.Series.Add(serie); // Añadimos la serie al gráfico

                    // Comprobamos si ya existe una leyenda llamada "Legend1"
                    if (ChartProductos.Legends.Count == 0)
                    {
                        Legend legend = new Legend("Legend1");
                        legend.Docking = Docking.Bottom;
                        ChartProductos.Legends.Add(legend);
                    }

                    ChartProductos.Series[0].Legend = "Legend1"; // Asignamos la leyenda a la serie
                }
                else
                {
                    // Si no hay datos, limpiamos el gráfico y mostramos un mensaje
                    ChartProductos.Series.Clear();
                    MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al configurar el gráfico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ConfigurarGraficoVentas();
            ConfigurarGraficoCompras();
            ConfigurarGraficoProductos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ChartVentas.Series.Clear();
            ChartVentas.Legends.Clear();
            ChartCompras.Series.Clear();
            ChartCompras.Legends.Clear();
            ChartProductos.Series.Clear();  // Limpiar las series
            ChartProductos.Legends.Clear(); // Limpiar las leyendas

            // Restablecer las fechas de los DateTimePicker a la fecha de hoy
            dtFechaDesde.Value = DateTime.Now;
            dtFechaHasta.Value = DateTime.Now;

            // Limpiar los cuadros de texto (si es necesario)
            txtTotalVentas.Text = "$0.00";
            txtTotalCompras.Text = "$0.00";

            // Opcional: puedes restablecer los títulos de los ejes si lo deseas
            ChartVentas.ChartAreas[0].AxisX.Title = "Fecha";
            ChartVentas.ChartAreas[0].AxisY.Title = "Monto Total ($)";
            ChartCompras.ChartAreas[0].AxisX.Title = "Fecha";
            ChartCompras.ChartAreas[0].AxisY.Title = "Monto Total ($)";

            // Si es necesario también puedes restablecer el formato de los ejes
            ChartVentas.ChartAreas[0].AxisY.LabelStyle.Format = "$0.00";
            ChartCompras.ChartAreas[0].AxisY.LabelStyle.Format = "$0.00";

            // Opcional: puedes mostrar un mensaje de confirmación
            MessageBox.Show("El gráfico ha sido limpiado y puedes cargar nuevos datos.", "Limpiar Gráfico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

