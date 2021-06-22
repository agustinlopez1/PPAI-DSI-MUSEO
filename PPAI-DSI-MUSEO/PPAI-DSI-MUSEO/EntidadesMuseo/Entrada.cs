using PPAI_DSI_MUSEO.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Entrada
    {
        private int numero;
        private DateTime fechaHoraVenta;
        private int idTarifa;
        private float monto;
        private Sede sede;

        public Entrada()
        {
        }

        public int Numero { get => numero; set => numero = value; }
        public DateTime FechaVenta { get => fechaHoraVenta; set => fechaHoraVenta = value; }
        public int IdTarifa { get => idTarifa; set => idTarifa = value; }
        public float Monto { get => monto; set => monto = value; }
        public Sede Sede { get => sede; set => sede = value; }

        public List<Entrada> EsFechaHoraHoy(List<Entrada> entradas)
        {

            List<Entrada> listaEntradasActuales = new List<Entrada>();
            foreach (Entrada entrada in entradas)
            {
                if (entrada.FechaVenta.Date == DateTime.Today.Date) // 
                {
                    listaEntradasActuales.Add(entrada);

                }
            }

            return listaEntradasActuales;

        }

        public List<Entrada> EsSedeActual(int idsede)
        {
            List<Entrada> listaEntradas = new List<Entrada>();
            listaEntradas = Varios_DAO.ObtenerEntradasXSede(Varios_DAO.ObtenerTabla("Entrada"), idsede);
            return listaEntradas;

        }

    }
}
