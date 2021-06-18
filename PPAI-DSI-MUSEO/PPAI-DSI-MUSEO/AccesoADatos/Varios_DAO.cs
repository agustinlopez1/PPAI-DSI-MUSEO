using PPAI_DSI_MUSEO.EntidadesMuseo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.AccesoADatos
{
    public class Varios_DAO
    {
        public static DataTable ObtenerTabla(string nombreTabla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["MuseoBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM " + nombreTabla;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        } // checkeado

        public static List<Sesion> ObtenerListaSesiones(DataTable tabla)
        {
            List<Sesion> listaSesiones = new List<Sesion>();

            foreach (DataRow sesion in tabla.Rows)
            {
                Sesion ses = new Sesion();

                ses.FechaHoraInicio = Convert.ToDateTime(sesion["fechaHoraInicio"]);
                if (sesion["fechaHoraFin"] == DBNull.Value)
                {
                    // ses.FechaHoraFin = DateTime.MinValue;
                    ses.FechaHoraFin = DateTime.MinValue;
                    // DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15)
                }
                else
                {
                    
                    ses.FechaHoraFin = Convert.ToDateTime(sesion["fechaHoraFin"]);
                }
                
                ses.Usuario = Sesion.ObtenerUsuario(Convert.ToInt32(sesion["idUsuario"]));

                listaSesiones.Add(ses);
            }

            return listaSesiones;
        } // checkeado

        public static List<Usuario> ObtenerListaUsuarios(DataTable tabla)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            foreach (DataRow usuario in tabla.Rows)
            {
                Usuario usu = new Usuario();

                usu.IdUsuario = Convert.ToInt32(usuario["idUsuario"]);
                usu.Nombre = usuario["nombre"].ToString();
                usu.Empleado = Usuario.ObtenerEmpleado(Convert.ToInt32(usuario["legajoEmpleado"]));

                listaUsuarios.Add(usu);

            }

            return listaUsuarios;
        } // checkeado


        public static Sede ObtenerSede(int idSede)
        {
            Sede sede = new Sede();
            DataTable tabla = new DataTable();
            tabla = ObtenerTabla("Sede");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (Convert.ToInt32(tabla.Rows[i][0]) == idSede)
                {
                    sede.IdSede = Convert.ToInt32(tabla.Rows[i][0]);
                    sede.CantMaximaVisitantes = Convert.ToInt32(tabla.Rows[i][1]);
                    sede.CantMaximaPorGuia = Convert.ToInt32(tabla.Rows[i][2]);
                    sede.Nombre = tabla.Rows[i][3].ToString();
                    return sede;
                }
            }
            return null;
        }


        //public static Usuario ObtenerUsuarioDeSesion(Sesion sesionActual)
        //{
        //    Usuario usuarioDeSesion = new Usuario();

        //    usuarioDeSesion = sesionActual.Usuario;

        //    return usuarioDeSesion;
        //}


    }
}
