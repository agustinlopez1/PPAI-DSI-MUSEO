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
using System.Text.RegularExpressions;

namespace PPAI_DSI_MUSEO.PantallaVentaEntrada
{
    public partial class PantallaVentaEntrada : Form
    {
        GestorVentaEntrada gestor = new GestorVentaEntrada();
        
        public PantallaVentaEntrada()
        {
            InitializeComponent();
        }

        private void RegistrarVentaDeEntrada_Load(object sender, EventArgs e)  //HabilitarPantalla
        {
            gestor.opcionRegistrarVenta();
            labelFechaActual.Text = DateTime.Now.ToShortDateString();
            lblSedeActual.Text = gestor.SesionActual.Usuario.Empleado.Sede.Nombre;
            mostrarTarifasExistentes(gestor.TarifasExistentes);
            

            //gestor.CalcularDuracionEstimada();

            // txtDuracionEstimada.Text = gestor.DuracionEstimada.ToString();

            gestor.buscarReservas();
            gestor.buscarEntradasVendidas();
            gestor.calcularVisitantesTotal();
            ActualizarDisponibilidad(); 
        }

        private void ActualizarDisponibilidad()
        {
            int capMaximaSede = gestor.buscarCapacidadMaxima();
            int maxEntradasDisponibles = (capMaximaSede - gestor.CantidadVisitantesTotal);
            txtMaximoEntradas.Text = maxEntradasDisponibles.ToString();
        }
        
        private void mostrarTarifasExistentes(List<Tarifa> tarifas)
        {
            foreach (Tarifa tarifa in tarifas)
            {
                grillaTarifasExistentes.Rows.Add(tarifa.IdTarifa,tarifa.Monto, tarifa.TipoEntrada.Nombre, tarifa.TipoVisita.Nombre, tarifa.MontoAdicional);
                
            }

        }
       
        private void  tomarSeleccionDeTarifa(int idtarifa)
        {

            gestor.tomarSeleccionDeTarifa(idtarifa);



        }

        private void LimpiarCampos()
        {
            // reestablezco todos los campos
            txtIDTarifa.Text = "";
            txtTipoEntrada.Text = "";
            txtTipoVisita.Text = "";
            txtDuracionEstimada.Text = "";
            txtNroEntradas.Text = "";
            LimpiarCamposDetalle();
        }

        private void LimpiarCamposDetalle()
        {
            txtNroEntradasDetalle.Text = "";
            txtMontoEntrada.Text = "";
            txtMontoAdicional.Text = "";
            txtTotal.Text = "";
        }
        
        private void tomarCantidadEntradas() 
        {
            int cantidad = Convert.ToInt32(txtNroEntradas.Text);
            gestor.CantEntradasGenerar = cantidad;
           
        }

        private void mostrarDetallaEntrada() 
        {
            txtNroEntradasDetalle.Text = gestor.CantEntradasGenerar.ToString();
            txtMontoEntrada.Text = gestor.TarifaSeleccionada.Monto.ToString();
            txtMontoAdicional.Text = gestor.TarifaSeleccionada.MontoAdicional.ToString();
            txtTotal.Text = gestor.calcularMontoTotal().ToString();
            botonCalcularTotal.Enabled = true;

        }

        private void tomarConfirmacionVenta()  
        {
            
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea confirmar la venta" +
                " por $" + txtTotal.Text + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                gestor.registrarNuevaEntrada();
                LimpiarCampos();
                ActualizarDisponibilidad();
                // actualizar volver a cargar la capacidad de entradas maximas
            }
        }

        private void botonCalcularTotal_Click(object sender, EventArgs e)
        {
            if (txtNroEntradas.Text != "") // valida que no sea vacío
            {
                bool esNumero = Regex.IsMatch(txtNroEntradas.Text, @"^\d+$"); // valida que sea un numero
                if (esNumero) // valida que sea un numero
                {
                    tomarCantidadEntradas();

                    if (gestor.verificarLimiteVisitantes(Convert.ToInt32(txtNroEntradas.Text))) // valida capacidad de sede
                    {
                        mostrarDetallaEntrada();
                    }
                    else // si excede capacidad:
                    {
                        MessageBox.Show("La cantidad de entradas ingresada excede la capacidad de la sede." +
                            "\nIngrese una cantidad correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNroEntradas.Text = "";
                        txtNroEntradas.Focus();
                    }
                }
                else // si no son numeros:
                {
                    MessageBox.Show("Solo se aceptan caracteres numéricos." +
                            "\nIngrese una cantidad correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNroEntradas.Text = "";
                    txtNroEntradas.Focus();
                }


            }
            else // si el textbox esta vacio:
            {
                MessageBox.Show("El campo 'N° de entradas' no puede estar vacío." +
                            "\nIngrese la cantidad de entradas para poder calcular el monto total.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroEntradas.Focus();
            }
        }

        private void botonConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "")
            // valida que se haya presionado el boton "Calcular total"
            {
                if (txtNroEntradas.Text != "")
                // valida que se haya ingresado la cantidad de entradas a emitir
                {
                    tomarConfirmacionVenta();
                }
                else
                {
                    MessageBox.Show("Complete todos los datos para poder registrar la venta",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero debe calcular el monto total para poder registrar la venta.\n" +
                    "Presione el botón 'Calcular total'.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.Show();
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void grillaTarifasExistentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int indice = e.RowIndex;
                DataGridViewRow filaseleccionada = grillaTarifasExistentes.Rows[indice];
                string tipoEntrada = filaseleccionada.Cells["tipoEntrada"].Value.ToString();
                string tipoVisita = filaseleccionada.Cells["tipoVisita"].Value.ToString();
                int idTarifa = Convert.ToInt32(filaseleccionada.Cells["idTarifa"].Value);



                tomarSeleccionDeTarifa(idTarifa);

                txtIDTarifa.Text = idTarifa.ToString();
                txtTipoEntrada.Text = tipoEntrada.ToString();
                txtTipoVisita.Text = tipoVisita.ToString();
                if (tipoVisita.ToString() == "Por Exposicion")
                {
                    labelError.Visible = true;
                    txtDuracionEstimada.Text = "NoAplica";
                    txtDuracionEstimada.ForeColor = Color.Red;
                }
                else
                {
                    labelError.Visible = false;
                    txtDuracionEstimada.ForeColor = Color.FromArgb(4, 139, 204);
                    gestor.calcularDuracionEstimada();
                    txtDuracionEstimada.Text = gestor.DuracionEstimada.ToString();
                }

                //if (tipoVisita.ToString() == "Por Exposicion")
                //{ labelError.Visible = true; txtDuracionEstimada.Text = "NoAplica"; txtDuracionEstimada.ForeColor = Color.Red; }
                //else { labelError.Visible = false; txtDuracionEstimada.ForeColor = Color.FromArgb(4, 139, 204); 
                //    txtDuracionEstimada.Text = gestor.DuracionEstimada.ToString(); ; }
                LimpiarCamposDetalle();
                

            }
            else
            {
                txtIDTarifa.Text = "";
                txtTipoEntrada.Text = "";
                txtTipoVisita.Text = "";
            }
        }

        private void grillaTarifasExistentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int indice = e.RowIndex;
                DataGridViewRow filaseleccionada = grillaTarifasExistentes.Rows[indice];
                string tipoEntrada = filaseleccionada.Cells["tipoEntrada"].Value.ToString();
                string tipoVisita = filaseleccionada.Cells["tipoVisita"].Value.ToString();
                int idTarifa = Convert.ToInt32(filaseleccionada.Cells["idTarifa"].Value);

                tomarSeleccionDeTarifa(idTarifa);
               
                txtIDTarifa.Text = idTarifa.ToString(); // se puede ingresar por parametro? y deberia 
                txtTipoEntrada.Text = tipoEntrada.ToString();
                txtTipoVisita.Text = tipoVisita.ToString();
                
                if (tipoVisita.ToString() == "Por Exposicion")
                {
                    labelError.Visible = true;
                    txtDuracionEstimada.Text = "NoAplica";
                    txtDuracionEstimada.ForeColor = Color.Red;
                }
                else
                {
                    labelError.Visible = false;
                    txtDuracionEstimada.ForeColor = Color.FromArgb(4, 139, 204);
                    gestor.calcularDuracionEstimada();
                    txtDuracionEstimada.Text = gestor.DuracionEstimada.ToString();
                }

                

                //if (txtTipoVisita.Text == "Por Exposicion") { CargarComboExposiciones(); }

                //int idExpo = comboExposiciones.SelectedIndex;
                //gestor.ExposicionSelecionada.IdExpo = idExpo;
                ////alternativa pausada

               
                LimpiarCamposDetalle();
            }
            else
            {
                txtIDTarifa.Text = "";
                txtTipoEntrada.Text = "";
                txtTipoVisita.Text = "";
            }
        }

        // estos dos metodos son para los efectos visuales de la grilla
        private void grillaTarifasExistentes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 40 && e.RowIndex > 0)
            {
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.FromArgb(34, 36, 49);
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.FromArgb(34, 36, 49);
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.FromArgb(34, 36, 49);
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.FromArgb(34, 36, 49);
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.FromArgb(34, 36, 49);
            }
        }
        private void grillaTarifasExistentes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 40 && e.RowIndex > 0)
            {
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Black;
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.Black;
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Black;
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Black;
                grillaTarifasExistentes.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.Black;
            }
        }
        
        private void CargarComboExposiciones() // completar alternativa
        {
            List<Exposicion> exposiciones = gestor.SedeActual.Exposiciones;
            //foreach (Exposicion exposicion in exposiciones)
            //{
            //    exposicion.Nombre

            //}

            //comboExposiciones.DataSource = exposiciones;
            //comboExposiciones.DisplayMember = "nombre";
            //comboExposiciones.ValueMember = "idExpo";
            //comboExposiciones.SelectedIndex = -1;


        }
        // =====================================================================
    }


}
