using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Entrada
    {
        private int numero;
        private DateTime fechaVenta;
        private int idTarifa;

        public Entrada()
        {
        }

        public int Numero { get => numero; set => numero = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public int IdTarifa { get => idTarifa; set => idTarifa = value; }

    }
}
