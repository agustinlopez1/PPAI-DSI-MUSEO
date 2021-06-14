using PPAI_DSI_MUSEO.EntidadesMuseo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.GestorVentaEntrada
{
    public class GestorVentaEntrada
    {
        private List<Tarifa>tarifasExistentes;

        private List<Entrada>entradasSeleccionadas;

        private List<Reserva>reservasActuales;

        private List<Entrada>entradasVendidas;

        private List<Tarifa>tarifasSeleccionadas;

        private DateTime fechaHoraEntradaAGenerar;

        private int numeroEntrada;

        private Sede sedeActual;

        private int id_sede;



        public void obtenerSedeActual() 
        {
            sedeActual();
        }

        public static List<Tarifa> buscarTarifasExistentes(Sede sedeActual) {

            sedeActual.buscarTarifasExistentes();

            
        }
        public void calcularDuracionEstimada() { }







    }
}
