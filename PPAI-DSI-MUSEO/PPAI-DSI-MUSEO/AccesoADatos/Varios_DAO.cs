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

                ses.Usuario = Sesion.getEmpleadoEnSesion(Convert.ToInt32(sesion["idUsuario"]));

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

        public static List<TipoEntrada> ObtenerListasTiposEntrada(DataTable tabla)
        {
            List<TipoEntrada> listaTipoEntrada = new List<TipoEntrada>();

            foreach (DataRow tipoentrada in tabla.Rows)
            {
                TipoEntrada tipoEntrada = new TipoEntrada();

                tipoEntrada.IdTipoEntrada = Convert.ToInt32(tipoentrada["idTipoEntrada"]);
                tipoEntrada.Nombre = tipoentrada["nombre"].ToString();
                tipoEntrada.Descripcion = tipoentrada["descripcion"].ToString();

                listaTipoEntrada.Add(tipoEntrada);

            }

            return listaTipoEntrada;

        }

        public static List<TipoVisita> ObtenerListasTiposVisita(DataTable tabla)
        {
            List<TipoVisita> listaTipoVisita = new List<TipoVisita>();

            foreach (DataRow tipovisita in tabla.Rows)
            {
                TipoVisita tipoVisita = new TipoVisita();

                tipoVisita.IdTipoVisita = Convert.ToInt32(tipovisita["idTipoEntrada"]);
                tipoVisita.Nombre = tipovisita["nombre"].ToString();
                tipoVisita.Descripcion = tipovisita["descripcion"].ToString();

                listaTipoVisita.Add(tipoVisita);

            }

            return listaTipoVisita;

        }

        public static List<Tarifa> ObtenerListaTarifa(DataTable tabla)
        {
            List<Tarifa> listaTarifa = new List<Tarifa>();

            foreach (DataRow tarifa in tabla.Rows)
            {
                Tarifa tarifaF = new Tarifa();

                tarifaF.IdTarifa = Convert.ToInt32(tarifa["idTarifa"]);
                tarifaF.Monto = Convert.ToInt32(tarifa["monto"]);
                tarifaF.MontoAdicional = Convert.ToInt32(tarifa["montoAdicional"]);
                tarifaF.TipoEntrada = Convert.ToInt32(tarifa["idTipoEn"]);
                tarifaF.TipoVisita = Convert.ToInt32(tarifa["idTipoVi"]);
                tarifaF.IdSede = Convert.ToInt32(tarifa["idSede"];

                listaTarifa.Add(tarifaF);

            }

            return listaTarifa;

        }



    }
}
