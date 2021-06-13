using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Sede
    {
        private string nombre;
        private float tarifa;
        private int idExposicion;

        public Sede()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Tarifa { get => tarifa; set => tarifa = value; }
        public int IdExposicion { get => idExposicion; set => idExposicion = value; }

        public List<Tarifa> buscarTarifasExistentes() {

            
        }

        public void conocer();


    }
}
