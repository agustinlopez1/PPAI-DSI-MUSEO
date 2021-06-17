using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Exposicion
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string nombre;
        private int idExpo;
        private int idSede;

        public Exposicion()
        {
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdExpo { get => idExpo; set => idExpo = value; }
        public int IdSede { get => idSede; set => idSede = value; }
    }
}
