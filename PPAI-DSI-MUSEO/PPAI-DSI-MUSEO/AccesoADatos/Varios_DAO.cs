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
                ses.FechaHoraFin = Convert.ToDateTime(sesion["fechaHoraFin"]);
                ses.Usuario = Sesion.ObtenerUsuario(Convert.ToInt32(sesion["idUsuario"]));

                listaSesiones.Add(ses);
            }

            return listaSesiones;
        } // checkeado



        //public static Usuario ObtenerUsuarioDeSesion(Sesion sesionActual)
        //{
        //    Usuario usuarioDeSesion = new Usuario();

        //    usuarioDeSesion = sesionActual.Usuario;

        //    return usuarioDeSesion;
        //}


    }
}
