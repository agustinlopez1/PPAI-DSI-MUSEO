using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Obra
    {
        private string nombre;
        private string descripcion;
        private int idObra;
        private int duracionResumida; 
        public Obra()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdObra { get => idObra; set => idObra = value; }
        public int DuracionResumida { get => duracionResumida; set => duracionResumida = value; }
    }
}
