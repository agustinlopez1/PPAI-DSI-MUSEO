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
        private List<Tarifa> tarifasExistentes;

        private List<Entrada> entradasSeleccionadas;

        private List<Reserva> reservasActuales;

        private List<Entrada> entradasVendidas;

        private List<Tarifa> tarifasSeleccionadas;

        private DateTime fechaHoraEntradaAGenerar;

        private int numeroEntrada;

        private Sede sedeActual;

        private int id_sede;

        private Sesion sesionActual;


        public void obtenerSedeActual()
        {
            Sesion ses = new Sesion();
            ses = sesionActual;
            Usuario usu = new Usuario();
            usu = ses.getEmpleadoEnSesion();
            Empleado emp = new Empleado();
            emp = usu.getEmpleado();
            Sede sed = new Sede();
            sed = emp.getSede();
            this.sedeActual = sed;
        }

        public static List<Tarifa> buscarTarifasExistentes(Sede sedeActual) {

            sedeActual.buscarTarifasExistentes();
        }

        public void calcularDuracionEstimada() { }
        {

        }

    }
}
