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
    public partial class FormRegistrarVenta : Form
    {
        public FormRegistrarVenta()
        {
            InitializeComponent();
        }

        private void RegistrarVentaDeEntrada_Load(object sender, EventArgs e)
        {
            labelFechaActual.Text = DateTime.Now.ToShortDateString();


        }

        private void ObtenerMaximoEntradas() // llena el txtMaximoEntradas segun la capacidad
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            // reestablezco todos los campos
            txtIDTarifa.Text = "";
            txtTipoEntrada.Text = "";
            txtTipoVisita.Text = "";
            comboExposiciones.SelectedIndex = -1;
            txtDuracionEstimada.Text = "";
            txtNroEntradas.Text = "";
            // el siguiente metodo llena el txtMaximoEntradas segun la capacidad:
            ObtenerMaximoEntradas();
            txtNroEntradasDetalle.Text = "";
            txtMontoEntrada.Text = "";
            txtMontoAdicional.Text = "";
            txtTotal.Text = "";
        }

        private void botonConfirmarVenta_Click(object sender, EventArgs e)
        {
            // insertar codigo para registrar venta

            LimpiarCampos();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.Show();
            this.Close();
        }
    }
}
