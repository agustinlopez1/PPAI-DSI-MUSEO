using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class TipoEntrada
    {
        private int idTipoEntrada;
        private string nombre;
        private string descripcion;

        public TipoEntrada()
        {
        }
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTipoEntrada { get => idTipoEntrada; set => idTipoEntrada = value; }

      
    }
}
