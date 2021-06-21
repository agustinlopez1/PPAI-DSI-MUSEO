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
        private Exposicion exposicion; //taa bien? 

        public DetalleExposicion()
        {
        }

        public Obra Obra { get => obra; set => obra = value; }

        public Exposicion Exposicion { get => exposicion; set => exposicion = value; }

    }
}
