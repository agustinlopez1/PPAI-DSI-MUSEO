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
using PPAI_DSI_MUSEO.Gestor;

namespace PPAI_DSI_MUSEO.PantallaVentaEntrada
{
    public partial class PantallaVentaEntrada : Form
    {
        public PantallaVentaEntrada()
        {
            InitializeComponent();
           GestorVentaEntrada gestor = new GestorVentaEntrada();
        }

        private void RegistrarVentaDeEntrada_Load(object sender, EventArgs e)
        {
            labelFechaActual.Text = DateTime.Now.ToShortDateString();

            Gestor.GestorVentaEntrada gestor = new Gestor.GestorVentaEntrada();
            gestor.OpcionRegistrarVenta();
            MostrarTarifasExistentes(gestor.TarifasExistentes);
        }

        private void ObtenerMaximoEntradas() // llena el txtMaximoEntradas segun la capacidad
        {

        }

        private void MostrarTarifasExistentes(List<Tarifa> tarifas)
        {
            foreach (Tarifa tarifa in tarifas)
            {
                grillaTarifasExistentes.Rows.Add(tarifa.Monto, tarifa.TipoEntrada.Nombre, tarifa.TipoVisita.Nombre, tarifa.MontoAdicional);
            }

        }
        private void TarifasExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaTarifasExistentes.Rows[indice];
            //string id = filaseleccionada.Cells["id_tarifa"].Value.ToString();
            

        }
        private void TomarSeleccionTarifa(Tarifa tarifa)
        {
            txtIDTarifa.Text = tarifa.IdTarifa.ToString();
;           txtTipoEntrada.Text = tarifa.TipoEntrada.Nombre.ToString();
            txtTipoVisita.Text = tarifa.TipoVisita.Nombre.ToString();

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

        private void botonCalcularTotal_Click(object sender, EventArgs e)
        {
            //aca va calcular detalle
        }
    }
}
