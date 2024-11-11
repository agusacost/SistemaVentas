using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Negocio
{
    public class N_Reporte
    {
        private D_Reporte obj_reporte = new D_Reporte();

        public double totalCompras(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.totalCompras(dtFechaDesde, dtFechaHasta);
        }

        public double totalVentas(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.totalVentas(dtFechaDesde, dtFechaHasta);
        }

        public List<DateTime> FechasV(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.FechasV(dtFechaDesde, dtFechaHasta);
        }

        public List<Double> MontosV(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.MontosV(dtFechaDesde, dtFechaHasta);
        }

        public List<decimal> MontosC(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.MontosC(dtFechaDesde, dtFechaHasta);
        }
        public List<DateTime> FechasC(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.FechasC(dtFechaDesde, dtFechaHasta);
        }
        public List<Double> MontosP(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.MontosP(dtFechaDesde, dtFechaHasta);
        }
        public List<string> Productos(DateTime dtFechaDesde, DateTime dtFechaHasta)
        {
            return obj_reporte.Productos(dtFechaDesde, dtFechaHasta);
        }
    }
}
