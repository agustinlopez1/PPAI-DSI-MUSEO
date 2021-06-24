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


        


    }
}
