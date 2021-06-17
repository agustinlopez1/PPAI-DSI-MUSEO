using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
