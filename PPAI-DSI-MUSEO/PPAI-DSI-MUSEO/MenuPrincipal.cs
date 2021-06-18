using PPAI_DSI_MUSEO.PantallaVentaEntrada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_MUSEO
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonRegistrarVenta_Click(object sender, EventArgs e)
        {
            PantallaVentaEntrada ventana = new PantallaVentaEntrada();
            ventana.Show();
            this.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
