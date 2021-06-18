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

        public static Empleado ObtenerEmpleado(int legEmpleado) // checkeado
        {
            Empleado emp = new Empleado();
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Varios_DAO.ObtenerTabla("Empleado");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (Convert.ToInt32(tabla.Rows[i][3]) == legEmpleado)
                {
                    emp.Nombre = tabla.Rows[i][0].ToString();
                    emp.Apellido = tabla.Rows[i][1].ToString();
                    emp.FechaNacimeinto = Convert.ToDateTime(tabla.Rows[i][2]);
                    emp.Legajo = Convert.ToInt32(tabla.Rows[i][3]);
                    emp.Sede = Empleado.ObtenerSede(Convert.ToInt32(tabla.Rows[i][4]));
                    
                    return emp;
                }
            }
            return null;

        }


    }
}
