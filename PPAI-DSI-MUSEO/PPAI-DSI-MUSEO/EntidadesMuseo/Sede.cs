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




    }
}
