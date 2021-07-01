using PPAI_DSI_MUSEO.AccesoADatos;
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

        public static Usuario getEmpleadoEnSesion(int idUsuario)
            //obtiene el usuario que esta en sesion
        {
            Usuario usuario = new Usuario();
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Varios_DAO.ObtenerTabla("Usuario");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (Convert.ToInt32(tabla.Rows[i][0]) == idUsuario)
                {
                    usuario.IdUsuario = Convert.ToInt32(tabla.Rows[i][0]);
                    usuario.Nombre = tabla.Rows[i][1].ToString();
                    usuario.Empleado = Usuario.getEmpleado((Convert.ToInt32(tabla.Rows[i][2])));
                    return usuario;
                }
            }
            return null;
        }
    }
}
