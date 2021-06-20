using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Tarifa
    {
        private int idTarifa;
        private float monto;
        private float montoAdicional;
        private int idTipoEntrada;
        private int idTipoVisita;
        private int idSede;

        public Tarifa()
        {
        }

        public float Monto { get => monto; set => monto = value; }
        public float MontoAdicional { get => montoAdicional; set => montoAdicional = value; }
        public int TipoEntrada { get => idTipoEntrada; set => idTipoEntrada = value; }
        public int TipoVisita { get => idTipoVisita; set => idTipoVisita = value; }
        public int IdTarifa { get => idTarifa; set => idTarifa = value; }
        public int IdSede { get => idSede; set => idSede = value; }

        public void ConocerTipoEntrada(int idSede)
        {
            DataTable tablaTipoEntrada = AccesoADatos.Varios_DAO.ObtenerTabla("TipoEntrada");
            List<TipoEntrada> listaTipoEntrada = new List<TipoEntrada>();
            listaTipoEntrada = AccesoADatos.Varios_DAO.ObtenerListasTiposEntrada(tablaTipoEntrada);
            
        }

        public void ConocerTipoVisita()
        {
            DataTable tablaTipoVisita = AccesoADatos.Varios_DAO.ObtenerTabla("TipoVisita"); //crear
            List<TipoVisita> listaTipoVisita = new List<TipoVisita>();
            listaTipoVisita = AccesoADatos.Varios_DAO.ObtenerListasTiposVisita(tablaTipoVisita);

        }

    }
}
