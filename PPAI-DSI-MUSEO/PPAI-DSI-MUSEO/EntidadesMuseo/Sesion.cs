using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Sesion
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private int idUsuario;

        public Sesion()
        {
            
        }

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        

        public Usuario ObtenerUsuario(Sesion sesion)
        {
            Usuario usuarioResultado = new Usuario();

            if (sesion.idUsuario = )
            {

            }

            return usuarioResultado;
        }

        public int ObtenerLegEmpleado()
        {
            Usuario usu = new Usuario();
            int leg = usu.LegEmpleado;
            return leg;
        }






    }
}
