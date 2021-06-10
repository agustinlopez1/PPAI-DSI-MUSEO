using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Tarifa
    {
        private float monto;
        private float montoAdicional;
        private int idTipoEntrada;
        private int idTipoVisita;

        public Tarifa()
        {
        }

        public float Monto { get => monto; set => monto = value; }
        public float MontoAdicional { get => montoAdicional; set => montoAdicional = value; }
        public int TipoEntrada { get => idTipoEntrada; set => idTipoEntrada = value; }
        public int TipoVisita { get => idTipoVisita; set => idTipoVisita = value; }
    }
}
