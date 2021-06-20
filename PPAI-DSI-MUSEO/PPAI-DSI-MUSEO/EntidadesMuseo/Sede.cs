using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Sede
    {
        private int idSede;
        private string nombre;
        private List<Tarifa> tarifas;
        private int cantMaximaVisitantes;
        private int cantMaximaPorGuia;

        public Sede()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdSede { get => idSede; set => idSede = value; }
        public List<Tarifa> Tarifas { get => tarifas; set => tarifas = value; }
        public int CantMaximaVisitantes { get => cantMaximaVisitantes; set => cantMaximaVisitantes = value; }
        public int CantMaximaPorGuia { get => cantMaximaPorGuia; set => cantMaximaPorGuia = value; }


        public List<Tarifa> BuscarTarifaExistentes(int idsede)  //veer
        {

            this.tarifas = ObtenerListaTarifas(idSede);
            nombreTipoEntrada = ConocerTipoEntrada;
            nombreTipoVisita = ConocerTipoVisita;

            return this.tarifas;
        }




    }
}
