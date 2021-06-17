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
        private Empleado empleado;

        public Usuario()
        {
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string UsuarioNombre { get => nombre; set => nombre = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }
        



    }
}
