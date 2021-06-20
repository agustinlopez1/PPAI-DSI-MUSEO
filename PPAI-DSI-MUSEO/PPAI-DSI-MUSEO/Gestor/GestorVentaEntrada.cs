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
        private List<Tarifa> tarifasSeleccionadas;
        private DateTime fechaHoraEntradaAGenerar;
        private int numeroEntrada;
        private Sede sedeActual;
        private Sesion sesionActual;
        public GestorVentaEntrada()
        {

        }

        public List<Tarifa> TarifasExistentes { get => tarifasExistentes; set => tarifasExistentes = value; }
        public List<Entrada> EntradasSeleccionadas { get => entradasSeleccionadas; set => entradasSeleccionadas = value; }
        public List<ReservaVisita> ReservasActuales { get => reservasActuales; set => reservasActuales = value; }
        public List<Entrada> EntradasVendidas { get => entradasVendidas; set => entradasVendidas = value; }
        public List<Tarifa> TarifasSeleccionadas { get => tarifasSeleccionadas; set => tarifasSeleccionadas = value; }
        public DateTime FechaHoraEntradaAGenerar { get => fechaHoraEntradaAGenerar; set => fechaHoraEntradaAGenerar = value; }
        public int NumeroEntrada { get => numeroEntrada; set => numeroEntrada = value; }
        public Sede SedeActual { get => sedeActual; set => sedeActual = value; }
        public Sesion SesionActual { get => sesionActual; set => sesionActual = value; }

        
        // Empiezan nuestros métodos "principales"
        public void OpcionRegistrarVenta()
        {
            ObtenerSedeActual();
            MessageBox.Show("la sede es " + sesionActual.Usuario.Empleado.Sede.Nombre);


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
        }

        public void BuscarTarifasExistentes() 
        {
            List<Tarifa> listaTarifas = new List<Tarifa>();
            listaTarifas = this.sedeActual.Tarifas;
            this.tarifasExistentes = this.sedeActual.Tarifas;
            //queonda this.SedeActual.BuscarTarifaExistentes(sedeActual.IdSede);


            
        }

    }
}