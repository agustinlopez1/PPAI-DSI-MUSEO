using PPAI_DSI_MUSEO.EntidadesMuseo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_MUSEO.AccesoADatos
{
    public class Varios_DAO
    {
        public static DataTable ObtenerTabla(string nombreTabla) 
            // devuelve una tabla resultado de la consulta a la BD segun nombreTabla 
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
        } 

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
        }

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
        public static Empleado ObtenerEmpleado(int legEmpleado)
        {
            Empleado empleado = new Empleado();
            DataTable tabla = new DataTable();
            tabla = ObtenerTabla("Empleado");
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (Convert.ToInt32(tabla.Rows[i][3]) == legEmpleado)
                {
                    empleado.Nombre = tabla.Rows[i][0].ToString();
                    empleado.Apellido = tabla.Rows[i][1].ToString();
                    empleado.FechaNacimeinto = Convert.ToDateTime(tabla.Rows[i][2]);
                    empleado.Legajo = Convert.ToInt32(tabla.Rows[i][3]);
                    empleado.Sede = Varios_DAO.ObtenerSede(Convert.ToInt32(tabla.Rows[i][4]));
                    return empleado;
                }
            }
            return null;
        }

        public static TipoEntrada ObtenerTipoEntrada(DataTable tabla, int idTipoEntrada)
        {

            foreach (DataRow tipoentrada in tabla.Rows)
            {
                TipoEntrada tipoEntrada = new TipoEntrada();
                if (idTipoEntrada == Convert.ToInt32(tipoentrada["idTipoEntrada"]))
                {
                    tipoEntrada.IdTipoEntrada = Convert.ToInt32(tipoentrada["idTipoEntrada"]);
                    tipoEntrada.Nombre = tipoentrada["nombre"].ToString();
                    tipoEntrada.Descripcion = tipoentrada["descripcion"].ToString();

                    return tipoEntrada;
                }


            }

            return null;

        }

        public static TipoVisita ObtenerTipoVisita(DataTable tabla, int idTipoVisita)
        {

            foreach (DataRow tipovisita in tabla.Rows)
            {
                TipoVisita tipoVisita = new TipoVisita();
                if (idTipoVisita == Convert.ToInt32(tipovisita["idTipoVisita"]))
                {
                    tipoVisita.IdTipoVisita = Convert.ToInt32(tipovisita["idTipoVisita"]);
                    tipoVisita.Nombre = tipovisita["nombre"].ToString();
                    tipoVisita.Descripcion = tipovisita["descripcion"].ToString();

                    return tipoVisita;
                }



            }

            return null;

        }

        public static List<Tarifa> ObtenerListaTarifasSedeActual(DataTable tabla, int idsede)
        {
            List<Tarifa> listaTarifa = new List<Tarifa>();

            foreach (DataRow tarifa in tabla.Rows)
            {
                Tarifa tarifaF = new Tarifa();
                if (idsede == Convert.ToInt32(tarifa["idSede"]))
                {
                    tarifaF.IdTarifa = Convert.ToInt32(tarifa["idTarifa"]);
                    tarifaF.Monto = Convert.ToInt32(tarifa["monto"]);
                    tarifaF.MontoAdicional = Convert.ToInt32(tarifa["montoAdicional"]);
                    tarifaF.TipoEntrada = ObtenerTipoEntrada(ObtenerTabla("TipoEntrada"), Convert.ToInt32(tarifa["idTipoEn"]));
                    tarifaF.TipoVisita = ObtenerTipoVisita(ObtenerTabla("TipoVisita"), Convert.ToInt32(tarifa["idTipoVi"]));
                    tarifaF.IdSede = Convert.ToInt32(tarifa["idSede"]);

                    listaTarifa.Add(tarifaF);
                }
            }
            return listaTarifa;
        }

        public static List<Exposicion> ObtenerExposicionesXSede(DataTable tabla, int idsede)
        {

            List<Exposicion> listaExposiciones = new List<Exposicion>();

            foreach (DataRow exposiciontabla in tabla.Rows)
            {
                Exposicion exposicionE = new Exposicion();
                if (idsede == Convert.ToInt32(exposiciontabla["idSede"]))
                {
                    exposicionE.FechaInicio = Convert.ToDateTime(exposiciontabla["fechaInicio"]);
                    exposicionE.FechaFin = Convert.ToDateTime(exposiciontabla["fechaFin"]);
                    exposicionE.Nombre = (exposiciontabla["nombre"]).ToString();
                    exposicionE.IdExpo = Convert.ToInt32(exposiciontabla["idExpo"]);
                    exposicionE.IdSede = Convert.ToInt32(exposiciontabla["idSede"]);


                    listaExposiciones.Add(exposicionE);
                }

            }
            return listaExposiciones;

        }

        public static List<DetalleExposicion> ObtenerDetallesXExposiciones(DataTable tabla, int idExposicion)
        {

            List<DetalleExposicion> listaDetallesExposiciones = new List<DetalleExposicion>();

            foreach (DataRow detalletabla in tabla.Rows)
            {
                DetalleExposicion detalleExpo = new DetalleExposicion();
                if (idExposicion == Convert.ToInt32(detalletabla["idExposicion"]))
                {
                    detalleExpo.IdDetalleExposicion = Convert.ToInt32(detalletabla["idDetalle"]);
                    detalleExpo.Obra = ObtenerObra(ObtenerTabla("Obra"), Convert.ToInt32(detalletabla["idObra"]));
                    detalleExpo.IdExposicion = Convert.ToInt32(detalletabla["idExposicion"]);


                    listaDetallesExposiciones.Add(detalleExpo);
                }
            }
            return listaDetallesExposiciones;

        }

        public static Obra ObtenerObra(DataTable tabla, int idObra)
        {
            foreach (DataRow obra in tabla.Rows)
            {
                Obra obra1 = new Obra();
                if (idObra == Convert.ToInt32(obra["idObra"]))
                {
                    obra1.IdObra = Convert.ToInt32(obra["idObra"]);
                    obra1.Nombre = obra["nombre"].ToString();
                    obra1.Descripcion = obra["descripcion"].ToString();
                    obra1.DuracionResumida = Convert.ToInt32(obra["duracionResumida"]);

                    return obra1;
                }
            }

            return null;
        }

        public static List<ReservaVisita> ObtenerReservas(DataTable tabla, int idSede)
        {
            List<ReservaVisita> listaReserva = new List<ReservaVisita>();

            foreach (DataRow reservatabla in tabla.Rows)
            {
                ReservaVisita reserva = new ReservaVisita();
                if (idSede == Convert.ToInt32(reservatabla["idSede"]))
                {
                    reserva.IdSede = Convert.ToInt32(reservatabla["idSede"]);
                    reserva.FechaCreada = Convert.ToDateTime(reservatabla["fechaHoraCreada"]);
                    reserva.FechaReserva = Convert.ToDateTime(reservatabla["fechaHoraReserva"]);
                    reserva.NroReserva = Convert.ToInt32(reservatabla["nroReserva"]);
                    reserva.CantAlumnos = Convert.ToInt32(reservatabla["cantAlumnos"]);
                    reserva.CantAlumnosConfirmada = Convert.ToInt32(reservatabla["cantAlumnosConfirmada"]);

                    listaReserva.Add(reserva);
                }

            }
            return listaReserva;
        }

        public static List<Entrada> ObtenerEntradasXSede(DataTable tabla, int idsede)
        {

            List<Entrada> listaEntradas = new List<Entrada>();

            foreach (DataRow entrada in tabla.Rows)
            {
                Entrada entrada2 = new Entrada();
                if (idsede == Convert.ToInt32(entrada["idSede"]))
                {
                    entrada2.Numero = Convert.ToInt32(entrada["nroEntrada"]);
                    entrada2.FechaVenta = Convert.ToDateTime(entrada["fechaHoraVenta"]);
                    entrada2.Monto = Convert.ToInt32(entrada["monto"]);
                    entrada2.Sede = ObtenerSede(idsede);
                    listaEntradas.Add(entrada2);
                }

            }
            return listaEntradas;

        }

        public static Tarifa ObtenerTarifaID(DataTable tabla, int idTarifa)
        {


            foreach (DataRow tarifatabla in tabla.Rows)
            {
                Tarifa tarifaID = new Tarifa();
                if (idTarifa == Convert.ToInt32(tarifatabla["idTarifa"]))
                {
                    tarifaID.IdTarifa = Convert.ToInt32(tarifatabla["idTarifa"]);
                    tarifaID.Monto = Convert.ToInt32(tarifatabla["monto"]);
                    tarifaID.MontoAdicional = Convert.ToInt32(tarifatabla["montoAdicional"]);
                    tarifaID.TipoEntrada = ObtenerTipoEntrada(ObtenerTabla("TipoEntrada"), Convert.ToInt32(tarifatabla["idTipoEn"]));
                    tarifaID.TipoVisita = ObtenerTipoVisita(ObtenerTabla("TipoVisita"), Convert.ToInt32(tarifatabla["idTipoVi"]));
                    tarifaID.IdSede = Convert.ToInt32(tarifatabla["idSede"]);

                    return tarifaID;
                }

            }
            return null;


        }

        public static int ObtenerUltimoNroEntrada() 
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["MuseoBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT MAX(nroEntrada) as NroEntrada FROM Entrada" ;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                int ultimoNum = Convert.ToInt32(tabla.Rows[0]["NroEntrada"]);

                // MessageBox.Show("ultimo numero es " + ultimoNum);
                // se repetia una vez de onda + una vez por cada entrada

                return ultimoNum;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool AltaEntradaNueva(int nroEntrada, int idSede, 
            int idTarifa, float monto, DateTime fechaVenta)
        {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["MuseoBD"];
                SqlTransaction objetoTransaccion = null;
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "INSERT INTO Entrada VALUES(@nroEntrada,@fechaVenta, @idTarifa, @monto, @idSede)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nroEntrada", nroEntrada);
                    cmd.Parameters.AddWithValue("@fechaVenta", fechaVenta);
                    cmd.Parameters.AddWithValue("@idTarifa",idTarifa);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@idSede", idSede);

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    objetoTransaccion = cn.BeginTransaction("AltaEntrada");
                    cmd.Transaction = objetoTransaccion;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    objetoTransaccion.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    objetoTransaccion.Rollback();
                    return false;
                }
                finally
                {
                    cn.Close();
                }
        }

        public static Exposicion ObtenerExposicionPorID(DataTable tabla, int idExposicion)
        {

            Exposicion exposicion = new Exposicion();

            foreach (DataRow exposiciontabla in tabla.Rows)
            {
                if (idExposicion == Convert.ToInt32(exposiciontabla["idExpo"]))
                {
                    exposicion.FechaInicio = Convert.ToDateTime(exposiciontabla["fechaInicio"]);
                    exposicion.FechaFin = Convert.ToDateTime(exposiciontabla["fechaFin"]);
                    exposicion.Nombre = (exposiciontabla["nombre"]).ToString();
                    exposicion.IdExpo = Convert.ToInt32(exposiciontabla["idExpo"]);
                    exposicion.IdSede = Convert.ToInt32(exposiciontabla["idSede"]);

                    return exposicion;
                }
            }
            return null;

        }




    }
}
