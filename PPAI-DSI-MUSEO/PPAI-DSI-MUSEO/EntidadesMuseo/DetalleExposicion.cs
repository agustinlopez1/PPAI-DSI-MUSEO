using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class DetalleExposicion
    {
        private int idDetalleExposicion;
        private Obra obra;
        private int idExposicion;
        public DetalleExposicion()
        {
        }

        public Obra Obra { get => obra; set => obra = value; }
        public int IdDetalleExposicion { get => idDetalleExposicion; set => idDetalleExposicion = value; }
        public int IdExposicion { get => idExposicion; set => idExposicion = value; }
    }
}
