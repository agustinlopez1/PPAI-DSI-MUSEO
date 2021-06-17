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
        //public static List<Sesion> obtenerSesiones()
        public static DataTable ObtenerSesiones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["MuseoBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                // List<Sesion> listaSesiones = new List<Sesion>();
                
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Sesion";

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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static List<Sesion> ObtenerListaDeDataTable(DataTable tabla)
        {
            List<Sesion> listaSesiones = new List<Sesion>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Sesion sesion = new Sesion();
                sesion.FechaHoraInicio = Convert.ToDateTime(tabla.Rows[i]["fechaHoraInicio"]);
                sesion.FechaHoraFin = Convert.ToDateTime(tabla.Rows[i]["fechaHoraFin"]);
                sesion.IdUsuario = Convert.ToInt32(tabla.Rows[i]["idUsuario"]);
                listaSesiones.Add(sesion);
            }

            return listaSesiones;
        }

        




    }
}
