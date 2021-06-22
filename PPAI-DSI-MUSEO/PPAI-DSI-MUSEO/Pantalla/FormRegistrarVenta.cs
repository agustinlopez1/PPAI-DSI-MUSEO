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
        GestorVentaEntrada gestor = new GestorVentaEntrada();
        private int cantidadEntrada { get;  set; }





        public PantallaVentaEntrada()
        {
            InitializeComponent();
            

        }

        private void RegistrarVentaDeEntrada_Load(object sender, EventArgs e)
        {
            
            labelFechaActual.Text = DateTime.Now.ToShortDateString();

            //GestorVentaEntrada gestor = new GestorVentaEntrada();

            gestor.OpcionRegistrarVenta();
            MostrarTarifasExistentes(gestor.TarifasExistentes);

            gestor.CalcularDuracionEstimada();
            txtDuracionEstimada.Text = gestor.DuracionEstimada.ToString();

            gestor.BuscarReservas();
            gestor.BuscarEntradasVendidas();
            gestor.CalcularVisitantesTotal();
            int capMaximaSede = gestor.BuscarCapacidadMaxima();
            int maxEntradasDisponibles = (capMaximaSede - gestor.CantidadVisitantesTotal);

            txtMaximoEntradas.Text = maxEntradasDisponibles.ToString();
            
        }

        private void ObtenerMaximoEntradas() // llena el txtMaximoEntradas segun la capacidad
        {

        }

        private void MostrarTarifasExistentes(List<Tarifa> tarifas)
        {
            foreach (Tarifa tarifa in tarifas)
            {
                grillaTarifasExistentes.Rows.Add(tarifa.IdTarifa,tarifa.Monto, tarifa.TipoEntrada.Nombre, tarifa.TipoVisita.Nombre, tarifa.MontoAdicional);
                
            }

        }
       
        private void  TomarSeleccionDeTarifa(int idtarifa)
        {

            gestor.tomarSeleccionDeTarifa(idtarifa);



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
            tomarConfirmacionVenta();
            
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.Show();
            this.Close();
        }

        private void botonCalcularTotal_Click(object sender, EventArgs e)
        {
            TomarCantidadEntradas();
            

            if (gestor.verificarLimiteVisitantes(Convert.ToInt32(txtNroEntradas.Text)))
            {
                mostrarDetallaEntrada();
            }
            else 
            {
                MessageBox.Show("Debe ingresar otra cantidad");
            
            }
            
            
            
            //aca va calcular detalle
        }

        private void grillaTarifasExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaTarifasExistentes.Rows[indice];
            string tipoEntrada = filaseleccionada.Cells["tipoEntrada"].Value.ToString();
            string tipoVisita = filaseleccionada.Cells["tipoVisita"].Value.ToString();
            int idTarifa = Convert.ToInt32(filaseleccionada.Cells["idTarifa"].Value);
 
            TomarSeleccionDeTarifa(idTarifa);

            txtIDTarifa.Text = idTarifa.ToString();
            txtTipoEntrada.Text = tipoEntrada.ToString();
            txtTipoVisita.Text = tipoVisita.ToString();
            

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
        
        private void TomarCantidadEntradas() 
        {
            int cantidad = Convert.ToInt32(txtNroEntradas.Text);
            gestor.CantEntradasGenerar = cantidad;

        }
        private void mostrarDetallaEntrada() 
        {
            txtNroEntradasDetalle.Text = gestor.CantEntradasGenerar.ToString();
            txtMontoEntrada.Text = gestor.TarifaSeleccionada.Monto.ToString();
            txtMontoAdicional.Text = gestor.TarifaSeleccionada.MontoAdicional.ToString();
            txtTotal.Text = gestor.CalcularMontoTotal().ToString();
            botonCalcularTotal.Enabled = true; //probar validaciones

        }


        private void tomarConfirmacionVenta() //modificar ea 
        {
            
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea confirmar la venta" +
                " por $" + txtTotal.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                gestor.RegistrarNuevaEntrada();
                LimpiarCampos();
            }
        
   

        } 

        


    }


}
