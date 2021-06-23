using PPAI_DSI_MUSEO.AccesoADatos;
using PPAI_DSI_MUSEO.EntidadesMuseo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_MUSEO.Gestor
{
    public class GestorVentaEntrada
    {
        private List<Tarifa> tarifasExistentes;
        private int cantEntradasGenerar; //agregar a la vista
        private List<ReservaVisita> reservasActuales;
        private List<Entrada> entradasVendidas;
        private Tarifa tarifaSeleccionada;
        private DateTime fechaHoraEntradaAGenerar;
        private int numeroEntrada;
        private Sede sedeActual;
        private Sesion sesionActual;
        private int duracionEstimada;
        private int cantidadVisitantesTotal;
        private int montoTotal;  // ?????

        public GestorVentaEntrada()
        {

        }

        public List<Tarifa> TarifasExistentes { get => tarifasExistentes; set => tarifasExistentes = value; }
        public List<ReservaVisita> ReservasActuales { get => reservasActuales; set => reservasActuales = value; }
        public List<Entrada> EntradasVendidas { get => entradasVendidas; set => entradasVendidas = value; }
        public Sede SedeActual { get => sedeActual; set => sedeActual = value; }
        public Sesion SesionActual { get => sesionActual; set => sesionActual = value; }
        public int DuracionEstimada { get => duracionEstimada; set => duracionEstimada = value; }
        public Tarifa TarifaSeleccionada { get => tarifaSeleccionada; set => tarifaSeleccionada = value; }
        public int CantidadVisitantesTotal { get => cantidadVisitantesTotal; set => cantidadVisitantesTotal = value; }
        public int CantEntradasGenerar { get => cantEntradasGenerar; set => cantEntradasGenerar = value; }
        
        // VER estos tres nunca se usan:
        public int MontoTotal { get => montoTotal; set => montoTotal = value; }
        public DateTime FechaHoraEntradaAGenerar { get => fechaHoraEntradaAGenerar; set => fechaHoraEntradaAGenerar = value; }
        public int NumeroEntrada { get => numeroEntrada; set => numeroEntrada = value; }


        // ========================================================================
        public void OpcionRegistrarVenta() // método disparador del CU?
        {
            ObtenerSedeActual();
            BuscarTarifasExistentes();
        }

        public void ObtenerSedeActual()
        // setea el atributo sedeActual del gestor segun el empleado logueado en el sistema
        {
            List<Sesion> listaSesiones = new List<Sesion>();
            listaSesiones = Varios_DAO.ObtenerListaSesiones(Varios_DAO.ObtenerTabla("Sesion"));
            this.sesionActual = ObtenerSesionActual(listaSesiones);
            this.sedeActual = sesionActual.Usuario.Empleado.Sede;
        }

        public static Sesion ObtenerSesionActual(List<Sesion> listaSesiones)
        // obtiene la sesion actual para encontrar la sede 
        {
            Sesion ses = new Sesion();

            foreach (Sesion sesion in listaSesiones)
            {
                var fechaHFin = sesion.FechaHoraFin.ToString();
                if (fechaHFin.Equals("1/1/0001 00:00:00"))
                {
                    ses = sesion;

                    return ses;
                }
            }
            return null;
        } 

        public void BuscarTarifasExistentes()
        // setea el atributo tarifasExistentes del gestor segun las tarifas de la sede actual
        {
            this.tarifasExistentes = this.SedeActual.BuscarTarifaExistentes(sedeActual.IdSede);

        }

        public void tomarSeleccionDeTarifa(int idtarifa)
        // setea el atributo tarifasSeleccionada del gestor segun la seleccion del usuario
        {

            this.tarifaSeleccionada = Varios_DAO.ObtenerTarifaID(Varios_DAO.ObtenerTabla("Tarifa"), idtarifa);


        } 

        public void CalcularDuracionEstimada()
        {
            this.duracionEstimada = this.sedeActual.ConocerExposicionesVigentes();
        }

        public void BuscarReservas()
        // setea el atributo reservasActuales del gestor segun las reservas para el dia actual
        {
            ReservaVisita reserva = new ReservaVisita();
            this.reservasActuales = reserva.EsFechaHoraHoy(reserva.EsSedeActual(this.sedeActual.IdSede));
        }

        public void BuscarEntradasVendidas()
        // setea el atributo entradasVendidas del gestor segun las vendidas en el dia actual

        {
            Entrada entrada = new Entrada();
            this.entradasVendidas = entrada.EsFechaHoraHoy(entrada.EsSedeActual(this.SedeActual.IdSede));
        }

        public int BuscarCapacidadMaxima()
        {
            int capacidadMax;
            capacidadMax = this.SedeActual.CantMaximaVisitantes;
            return capacidadMax;
        }

        public  void CalcularVisitantesTotal()
        // setea el valor CantidadVisitantesTotal del gestor
        {
            BuscarEntradasVendidas();
            int cantEntradasVendidas = this.EntradasVendidas.Count();
            int cantVisitantes = 0;
            foreach (ReservaVisita reserva in this.ReservasActuales)
            {
                cantVisitantes += reserva.CantAlumnosConfirmada;
            }
            int resultado = cantEntradasVendidas + cantVisitantes;
            this.CantidadVisitantesTotal = resultado;
        }

        public  bool verificarLimiteVisitantes(int cantidadEntradas)  
            // valida que la cant. entradas no supere la capacidad
        {
            int capacidadSede = BuscarCapacidadMaxima();
            int limite = capacidadSede - this.CantidadVisitantesTotal;
            if (cantidadEntradas <= limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CalcularMontoTotal() 
        {
            int monto = Convert.ToInt32(this.tarifaSeleccionada.Monto);
            int montoAdicional = Convert.ToInt32(this.tarifaSeleccionada.MontoAdicional);

            this.montoTotal = (monto + montoAdicional) * this.cantEntradasGenerar;

            return this.montoTotal;
        
        }

        public void RegistrarNuevaEntrada() 
        {
            getFechaHoraActual();
            buscarUltimoNumeroEntrada();
            generarNumeroEntrada();
            actualizarCantidadVisitantes();
        }

        public void getFechaHoraActual() 
        {
            this.fechaHoraEntradaAGenerar = DateTime.Now; //chequear?
            MessageBox.Show("Se registró la venta con fecha " + this.fechaHoraEntradaAGenerar.ToString());
        }

        public int  buscarUltimoNumeroEntrada() 
        {

            int ultimoNro = Varios_DAO.ObtenerUltimoNroEntrada(); //=  despues lo vemo
        
            return ultimoNro;
        }

        public void generarNumeroEntrada() 
        {
            for (int i = 0; i < this.cantEntradasGenerar; i++)
            {
                this.numeroEntrada = buscarUltimoNumeroEntrada() + 1;
                Varios_DAO.AltaEntradaNueva(this.numeroEntrada, this.sedeActual.IdSede, this.tarifaSeleccionada.IdTarifa,
                this.tarifaSeleccionada.Monto,
                this.fechaHoraEntradaAGenerar);
            }
        }

        public void actualizarCantidadVisitantes() 
            // mensaje de actualizado de las pantallas segun la capacidad de la sede
        {
            this.cantidadVisitantesTotal += cantEntradasGenerar;
            MessageBox.Show("Se extiende al CU 'actualizar pantallas'. \n" +
                "Pantallas de cantidad de visitantes actualizadas.\n" +
                "En este momento hay " + cantidadVisitantesTotal +" personas en el museo");
        }
    }
}
