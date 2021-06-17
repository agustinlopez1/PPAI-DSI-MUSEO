using PPAI_DSI_MUSEO.EntidadesMuseo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.GestorVentaEntrada
{
    public class GestorVentaEntrada
    {
        private List<Tarifa> tarifasExistentes;

        private List<Entrada> entradasSeleccionadas;

        private List<ReservaVisita> reservasActuales;

        private List<Entrada> entradasVendidas;

        private List<Tarifa> tarifasSeleccionadas;

        private DateTime fechaHoraEntradaAGenerar;

        private int numeroEntrada;

        private Sede sedeActual;

        private Sesion sesionActual;


        

        public Sesion ObtenerSesionActual(List<Sesion> listaSesiones)
        {
            Sesion sesionActual = new Sesion();
            foreach (Sesion sesion in listaSesiones)
            {
                if (sesion.FechaHoraFin != null)
                {
                    continue;
                }
                else
                {
                    sesionActual = sesion;
                }
            }
            return sesionActual;
        }
     
        public void calcularDuracionEstimada() 
        {

        }

    }
}
