using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_DSI_MUSEO.AccesoADatos;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Sede
    {
        private int idSede;
        private string nombre;
        private List<Tarifa> tarifas;
        private int cantMaximaVisitantes;
        private int cantMaximaPorGuia;
        private List<Exposicion> exposiciones;

        public Sede()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdSede { get => idSede; set => idSede = value; }
        public List<Tarifa> Tarifas { get => tarifas; set => tarifas = value; }
        public int CantMaximaVisitantes { get => cantMaximaVisitantes; set => cantMaximaVisitantes = value; }
        public int CantMaximaPorGuia { get => cantMaximaPorGuia; set => cantMaximaPorGuia = value; }
        public List<Exposicion> Exposiciones { get => exposiciones; set => exposiciones = value; }

        public List<Tarifa> buscarTarifaExistentes(int idsede)  //lista de tarifas de la sede actual
        {

            this.tarifas = Varios_DAO.ObtenerListaTarifasSedeActual 
                (Varios_DAO.ObtenerTabla("Tarifa"), idsede);
            
            return this.tarifas;
        }



        public int conocerExposicionesVigentes() //devuelve duracion de las obras en las exposiciones
        {
            
            this.exposiciones = Varios_DAO.ObtenerExposicionesXSede(Varios_DAO.ObtenerTabla("Exposicion"), this.idSede);

            List<Exposicion> exposicionesVigentes = new List<Exposicion>();
            Exposicion expo = new Exposicion();

            exposicionesVigentes = expo.esVigente(this.exposiciones);

            int acumulador = 0;

            foreach (Exposicion expo1 in exposicionesVigentes)
            {
                List<DetalleExposicion> listadetalles = new List<DetalleExposicion>();
               listadetalles = Varios_DAO.ObtenerDetallesXExposiciones(Varios_DAO.ObtenerTabla("DetalleExposicion"), 
                   Convert.ToInt32(expo1.IdExpo));


                foreach (DetalleExposicion detall in listadetalles)
                {

                    int duracionResumida = detall.Obra.DuracionResumida;
                    acumulador += duracionResumida;

                }

            }

            return acumulador;
        }
   

    }
}
