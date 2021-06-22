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
        
        public DateTime FechaHoraEntradaAGenerar { get => fechaHoraEntradaAGenerar; set => fechaHoraEntradaAGenerar = value; }
        public int NumeroEntrada { get => numeroEntrada; set => numeroEntrada = value; }
        public Sede SedeActual { get => sedeActual; set => sedeActual = value; }
        public Sesion SesionActual { get => sesionActual; set => sesionActual = value; }
        public int DuracionEstimada { get => duracionEstimada; set => duracionEstimada = value; }
        public Tarifa TarifaSeleccionada { get => tarifaSeleccionada; set => tarifaSeleccionada = value; }
        public int CantidadVisitantesTotal { get => cantidadVisitantesTotal; set => cantidadVisitantesTotal = value; }
        public int MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int CantEntradasGenerar { get => cantEntradasGenerar; set => cantEntradasGenerar = value; }


        // Empiezan nuestros métodos "principales"
        public void OpcionRegistrarVenta()
        {
            ObtenerSedeActual();
            MessageBox.Show("la sede es " + sesionActual.Usuario.Empleado.Sede.Nombre);
            BuscarTarifasExistentes();

        }

        public void ObtenerSedeActual() // obj: setear el parametro sedeActual del gestor
        {
            List<Sesion> listaSesiones = new List<Sesion>();
            listaSesiones = Varios_DAO.ObtenerListaSesiones(Varios_DAO.ObtenerTabla("Sesion"));
            this.sesionActual = ObtenerSesionActual(listaSesiones);  // acá ya tenemos la sesion actual seteada en el gestor
            this.sedeActual = sesionActual.Usuario.Empleado.Sede;
        }

        // Empiezan nuestros métodos "secundarios"
        public static Sesion ObtenerSesionActual(List<Sesion> listaSesiones)
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
        } //obtiene la sesion actual para encontrar la sede 

        public void BuscarTarifasExistentes()  //busca las tarifas que tenga la sede actual 
        {
            this.tarifasExistentes = this.SedeActual.BuscarTarifaExistentes(sedeActual.IdSede);

        }

        public void tomarSeleccionDeTarifa(int idtarifa)
        { 

            this.tarifaSeleccionada = Varios_DAO.ObtenerTarifaID(Varios_DAO.ObtenerTabla("Tarifa"), idtarifa);


        } //setea atributo de tarifasSelecioanda

        public void CalcularDuracionEstimada()
        {
            this.duracionEstimada = this.sedeActual.ConocerExposicionesVigentes();
    
        }


        public void BuscarReservas()           //FALTA TESTEAR   // setea la lista de reservas del dia de hoya
        {
            ReservaVisita reserva = new ReservaVisita();
            this.reservasActuales = reserva.EsFechaHoraHoy(reserva.EsSedeActual(this.sedeActual.IdSede));
        }


        public void BuscarEntradasVendidas()    //FALTA TESTEAR // setea el atributo entrada vendidas por la cantiada de entradas de ese dia
        {
            Entrada entrada = new Entrada();
            this.entradasVendidas = entrada.EsFechaHoraHoy(entrada.EsSedeActual(this.SedeActual.IdSede));
        }


        public int BuscarCapacidadMaxima()
        {
            int capacidadMax = 0;
            capacidadMax = this.SedeActual.CantMaximaVisitantes;
            return capacidadMax;
        }

        public  void CalcularVisitantesTotal()  // FALTA CHEKEAR- devuelve cuanta gente hay/va haber en la sede en ese momento.
        {
            
            BuscarEntradasVendidas();
            int cantEntradasVendidas = this.EntradasVendidas.Count();
            int cantVisitantes = 0;
            foreach (ReservaVisita reserva in this.ReservasActuales)
            {
                cantVisitantes += reserva.CantAlumnosConfirmada;
            }
            int res = cantEntradasVendidas + cantVisitantes;
            this.CantidadVisitantesTotal = res;
        }


        public  bool verificarLimiteVisitantes(int cantidadEntradas)  // verifica si la cantidad de entradas a comprar se puede
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


           
        
        
        }

        public void getFechaHoraActual() 
        {
            
            this.fechaHoraEntradaAGenerar = DateTime.Now; //chequear?
            MessageBox.Show(this.fechaHoraEntradaAGenerar.ToString());


        }

        public int  buscarUltimoNumeroEntrada() 
        {

            int ultimoNro = Varios_DAO.ObtenerUltimoNroEntrada(); //=  despues lo vemo
        
            return ultimoNro;
        }

        public void generarNumeroEntrada() 
        {
            this.numeroEntrada = buscarUltimoNumeroEntrada() + 1;
            Varios_DAO.AltaEntradaNueva(this.numeroEntrada,this.sedeActual.IdSede, this.tarifaSeleccionada.IdTarifa,
                this.tarifaSeleccionada.Monto,
                this.fechaHoraEntradaAGenerar);

        
        }
        public void actualizarCantidadVisitantes() //mensaje de actualizado las pantallas
        {

            MessageBox.Show("Pantalla Principal con visitantes actualizados");
            MessageBox.Show("Pantalla Sala con visitantes actualizados ");
        }

        
    }
}
