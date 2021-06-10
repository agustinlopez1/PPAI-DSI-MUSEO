using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Empleado
    {
        private string nombre;
        private int idEmpleado;

        public Empleado()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }
}
