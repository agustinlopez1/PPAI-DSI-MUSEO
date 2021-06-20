using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_MUSEO.EntidadesMuseo
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int legajo;
        private Sede sede;


        public Empleado()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public DateTime FechaNacimeinto { get => fechaNacimiento; set => fechaNacimiento = value; }

        public int Legajo { get => legajo; set => legajo = value; }

        public Sede Sede { get => sede; set => sede = value; }


        public static Sede ObtenerSede(int idSede) // checkeado
        {
            Sede sede = new Sede();
            DataTable tabla = new DataTable();
            tabla = AccesoADatos.Varios_DAO.ObtenerTabla("Sede");
            bool bandera = false;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                if (Convert.ToInt32(tabla.Rows[i][0]) == idSede)
                {
                    sede.IdSede = Convert.ToInt32(tabla.Rows[i][0]);
                    sede.CantMaximaVisitantes = Convert.ToInt32(tabla.Rows[i][1]);
                    sede.CantMaximaPorGuia = Convert.ToInt32(tabla.Rows[i][2]);
                    sede.Nombre = tabla.Rows[i][3].ToString();
                    

                    bandera = true;
                    return sede;
                }

            }
            if (bandera) {
                MessageBox.Show("se encontro la sede" + sede.Nombre);
            }
            

            return null;

        }




    }
}
