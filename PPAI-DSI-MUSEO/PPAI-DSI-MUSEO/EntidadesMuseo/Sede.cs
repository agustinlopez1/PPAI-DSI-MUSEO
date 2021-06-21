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

        public List<Tarifa> BuscarTarifaExistentes(int idsede)  //veer
        {

            this.tarifas = Varios_DAO.ObtenerListaTarifasSedeActual //lista de tarifas de la sede actual
                (Varios_DAO.ObtenerTabla("Tarifa"), idsede);

            foreach (Tarifa tarifa in this.tarifas) // de onda para mostrar que tipoentrada y visita tiene las tarifas de la sede actual.
            {

                MessageBox.Show("el tipoEntrada es " + tarifa.TipoEntrada.Nombre
                    + " y tipo visita es " + tarifa.TipoVisita.Nombre);
            }
  
            
            return this.tarifas;
        }



        public void ConocerExposicionesVigentes() 
        {
            this.exposiciones = Varios_DAO.ObtenerExposicionesXSede(Varios_DAO.ObtenerTabla("Exposicion"),this.idSede
                );
            
            
        }



    }
}
