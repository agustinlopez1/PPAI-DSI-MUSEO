using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private int legEmpleado;

        public Usuario()
        {
        }

        public string UsuarioNombre { get => nombre; set => nombre = value; }
        public int LegEmpleado { get => legEmpleado; set => legEmpleado = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
