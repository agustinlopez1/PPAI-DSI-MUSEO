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
    public class AD_Sesion
    {
        public static List<Sesion> obtenerSesion()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["MuseoBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetUsuarios";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
