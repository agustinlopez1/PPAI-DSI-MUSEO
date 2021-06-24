using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI_MUSEO.AccesoADatos;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Tarifa
    {
        private int idTarifa;
        private float monto;
        private float montoAdicional;
        private int idSede;

        private TipoEntrada tipoEntrada;
        private TipoVisita tipoVisita;
        public Tarifa()
        {
        }

        public float Monto { get => monto; set => monto = value; }
        public float MontoAdicional { get => montoAdicional; set => montoAdicional = value; }
        public int IdTarifa { get => idTarifa; set => idTarifa = value; }
        public int IdSede { get => idSede; set => idSede = value; }
        public TipoEntrada TipoEntrada { get => tipoEntrada; set => tipoEntrada = value; }
        public TipoVisita TipoVisita { get => tipoVisita; set => tipoVisita = value; }

        



    }
}
