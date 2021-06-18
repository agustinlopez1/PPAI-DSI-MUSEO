using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Sesion
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private Usuario usuario;

        public Sesion()
        {
            
        }

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public static Usuario ObtenerUsuario(int idUsuario) // checkeado
        {
            Usuario usu = new Usuario();
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Varios_DAO.ObtenerTabla("Usuario");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (Convert.ToInt32(tabla.Rows[i][0]) == idUsuario)
                {
                    usu.IdUsuario = Convert.ToInt32(tabla.Rows[i][0]);
                    usu.Nombre = tabla.Rows[i][1].ToString();
                    usu.Empleado = Usuario.ObtenerEmpleado((Convert.ToInt32(tabla.Rows[i][0])));
                    return usu;
                }
            }
            return null;
        }

        public Empleado getEmpleadoEnSesion()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios = Varios_DAO.ObtenerListaSesiones(Varios_DAO.ObtenerTabla("Sesion"));
            this.sesionActual = ObtenerSesionActual(listaSesiones);
        }

        

        






    }
}
