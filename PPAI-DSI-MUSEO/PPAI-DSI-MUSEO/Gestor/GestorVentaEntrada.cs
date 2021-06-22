﻿using PPAI_DSI_MUSEO.AccesoADatos;
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
        private List<Entrada> entradasSeleccionadas;
        private List<ReservaVisita> reservasActuales;
        private List<Entrada> entradasVendidas;
        private Tarifa tarifasSeleccionada;
        private DateTime fechaHoraEntradaAGenerar;
        private int numeroEntrada;
        private Sede sedeActual;
        private Sesion sesionActual;
        private int duracionEstimada;
        private int cantidadVisitantesTotal;

        public GestorVentaEntrada()
        {

        }

        public List<Tarifa> TarifasExistentes { get => tarifasExistentes; set => tarifasExistentes = value; }
        public List<Entrada> EntradasSeleccionadas { get => entradasSeleccionadas; set => entradasSeleccionadas = value; }
        public List<ReservaVisita> ReservasActuales { get => reservasActuales; set => reservasActuales = value; }
        public List<Entrada> EntradasVendidas { get => entradasVendidas; set => entradasVendidas = value; }
        
        public DateTime FechaHoraEntradaAGenerar { get => fechaHoraEntradaAGenerar; set => fechaHoraEntradaAGenerar = value; }
        public int NumeroEntrada { get => numeroEntrada; set => numeroEntrada = value; }
        public Sede SedeActual { get => sedeActual; set => sedeActual = value; }
        public Sesion SesionActual { get => sesionActual; set => sesionActual = value; }
        public int DuracionEstimada { get => duracionEstimada; set => duracionEstimada = value; }
        public Tarifa TarifasSeleccionada { get => tarifasSeleccionada; set => tarifasSeleccionada = value; }
        public int CantidadVisitantesTotal { get => cantidadVisitantesTotal; set => cantidadVisitantesTotal = value; }


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

        public void tomarSeleccionDeTarifa(Tarifa tarifasSele)
        {
            this.tarifasSeleccionada = tarifasSele;


        } //setea atributo de tarifasSelecioandas 

        public void CalcularDuracionEstimada()
        {
            this.duracionEstimada = this.sedeActual.ConocerExposicionesVigentes();
    
        }


        public void BuscarReservas()           //FALTA TESTEAR  
        {
            ReservaVisita reserva = new ReservaVisita();
            this.reservasActuales = reserva.EsFechaHoraHoy(reserva.EsSedeActual(this.sedeActual.IdSede));
        }


        public void BuscarEntradasVendidas()    //FALTA TESTEAR
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

        public void CalcularVisitantesTotal()  // FALTA CHEKEAR
        {
            int capacidadSede = BuscarCapacidadMaxima();
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


        private bool verificarLimiteVisitantes(int cantidadEntradas)  //CHEKEAR
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

    }
}
