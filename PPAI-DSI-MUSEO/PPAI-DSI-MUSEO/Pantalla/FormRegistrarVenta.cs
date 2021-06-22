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
        GestorVentaEntrada gestor;
        private int cantidadEntrada { get;  set; }





        public PantallaVentaEntrada()
        {
            InitializeComponent();
            
        }

        private void RegistrarVentaDeEntrada_Load(object sender, EventArgs e)
        {
            
            labelFechaActual.Text = DateTime.Now.ToShortDateString();

            GestorVentaEntrada gestor = new GestorVentaEntrada();

            gestor.OpcionRegistrarVenta();
            MostrarTarifasExistentes(gestor.TarifasExistentes);

            gestor.CalcularDuracionEstimada();
            txtDuracionEstimada.Text = gestor.DuracionEstimada.ToString();
            
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
       
        private void TomarSeleccionDeTarifa(Tarifa tarifa) 
        {
            txtIDTarifa.Text = tarifa.IdTarifa.ToString();
;           txtTipoEntrada.Text = tarifa.TipoEntrada.Nombre.ToString();
            txtTipoVisita.Text = tarifa.TipoVisita.Nombre.ToString();
            // tarifasSele = agregar a la lista que va obtener el gestor 
            // GetorVentaEntrada gestor = new GestorVentaEntrada(); //el gestor como mierda era 
            // gestor.tomarSeleccionDeTarifa(tarifas)
            

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

        private void grillaTarifasExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaTarifasExistentes.Rows[indice];
            string tipoEntrada = filaseleccionada.Cells["tipoEntrada"].Value.ToString();
            string tipoVisita = filaseleccionada.Cells["tipoVisita"].Value.ToString();

            GestorVentaEntrada gestor = new GestorVentaEntrada();
            

            //List<Tarifa> tarifas = gestor.TarifasExistentes;    vemo queonda 
            //int idIndice =Convert.ToInt32(filaseleccionada);
            //Tarifa tarifa = tarifas[idIndice];
            //int idTarifa = tarifa.IdTarifa;

            //txtIDTarifa.Text = idTarifa.ToString();
            txtTipoEntrada.Text = tipoEntrada.ToString();
            txtTipoVisita.Text = tipoVisita.ToString();
           
           //falta conseguir el id de la tarifa que seleccionamos, traer la lista de tarifas exxistentes desde el gestor

        }

       

        private void grillaTarifasExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaTarifasExistentes.Rows[indice];
            string tipoEntrada = filaseleccionada.Cells["tipoEntrada"].Value.ToString();
            string tipoVisita = filaseleccionada.Cells["tipoVisita"].Value.ToString();

            GestorVentaEntrada gestor = new GestorVentaEntrada();
            txtTipoEntrada.Text = tipoEntrada.ToString();
            txtTipoVisita.Text = tipoVisita.ToString();
            

        }
        
        private void TomarCantidasEntradas() 
        {
               
            this.cantidadEntrada = Convert.ToInt32(txtNroEntradas.Text);
            if this.cantidadEntrada
            
        }

        private void txtNroEntradas_TextChanged(object sender, EventArgs e)
        {
            TomarCantidasEntradas();
        }
    }


}
