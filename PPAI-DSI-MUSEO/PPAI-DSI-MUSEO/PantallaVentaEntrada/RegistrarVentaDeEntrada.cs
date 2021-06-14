using PPAI_DSI_MUSEO.EntidadesMuseo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_MUSEO.PantallaVentaEntrada
{
    public partial class RegistrarVentaDeEntrada : Form
    {
        public RegistrarVentaDeEntrada()
        {
            InitializeComponent();
        }

        private void RegistrarVentaDeEntrada_Load(object sender, EventArgs e)
        {
            Sesion sesionActual = new Sesion();
            sesionActual.FechaHoraInicio = DateTime.Now;
            sesionActual.IdUsuario = 0;

        }
    }
}
