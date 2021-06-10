using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Reserva
    {
        private DateTime fechaCreada;
        private DateTime fechaReserva;
        private int idSede;

        public Reserva()
        {
        }

        public DateTime FechaCreada { get => fechaCreada; set => fechaCreada = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public int IdSede { get => idSede; set => idSede = value; }
    }
}
