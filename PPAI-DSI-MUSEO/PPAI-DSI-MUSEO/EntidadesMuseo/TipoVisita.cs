using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class TipoVisita
    {
        private int idTipoVisita;
        private string nombre;
        private string descripcion;

        public TipoVisita()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTipoVisita { get => idTipoVisita; set => idTipoVisita = value; }
    }
}
