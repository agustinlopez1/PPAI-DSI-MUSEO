using System;
using System.Collections.Generic;
using System.Data;
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
        public string Nombre { get => nombre; set => nombre = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }

        public static Empleado getEmpleado(int legEmpleado) //devuelve el empleado del usuario
        {
            Empleado empleado = new Empleado();
            empleado = AccesoADatos.Varios_DAO.ObtenerEmpleado(legEmpleado);

            return empleado;

        }


    }
}
