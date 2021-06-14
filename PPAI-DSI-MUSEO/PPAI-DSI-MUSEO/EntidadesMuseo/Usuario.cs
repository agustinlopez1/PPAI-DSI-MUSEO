using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Usuario
    {
        private string nombre;
        private Empleado empleado;

        public Usuario()
        {
        }

        public string UsuarioNombre { get => nombre; set => nombre = value; }
        public Empleado UsuarioEmpleado { get => empleado; set => empleado = value; }

        public Empleado getEmpleado() 
        {
            Empleado emp = new Empleado();
            emp = this.empleado;
            return emp;
        }
    }
}
