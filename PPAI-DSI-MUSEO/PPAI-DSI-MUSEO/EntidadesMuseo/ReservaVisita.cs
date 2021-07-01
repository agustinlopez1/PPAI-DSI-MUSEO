using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI_MUSEO.AccesoADatos;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class ReservaVisita
    {
        private DateTime fechaCreada;
        private DateTime fechaReserva;
        private int idSede;
        private int cantAlumnos;
        private int cantAlumnosConfirmada;
        private int nroReserva;
        public ReservaVisita()
        {
        }

        public DateTime FechaCreada { get => fechaCreada; set => fechaCreada = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public int IdSede { get => idSede; set => idSede = value; }
        public int CantAlumnos { get => cantAlumnos; set => cantAlumnos = value; }
        public int CantAlumnosConfirmada { get => cantAlumnosConfirmada; set => cantAlumnosConfirmada = value; }
        public int NroReserva { get => nroReserva; set => nroReserva = value; }

        public List<ReservaVisita> esSedeActual(int idsede) 
        {
            List<ReservaVisita> listaReservaSede = new List<ReservaVisita>();
            listaReservaSede = Varios_DAO.ObtenerReservas(Varios_DAO.ObtenerTabla("ReserveVisita"), idsede);

            return listaReservaSede;
        
        } 
        public List<ReservaVisita> esFechaHoraHoy(List<ReservaVisita> reservas) 
        {

            List<ReservaVisita> listaReservaHoy = new List<ReservaVisita>();
            foreach (ReservaVisita reserva in reservas)
            {
                if (reserva.fechaReserva.Date == DateTime.Today.Date) 
                {
                    listaReservaHoy.Add(reserva);
                
                }
            }

            return listaReservaHoy;
        
        }
    }
}
