
namespace PPAI_DSI_MUSEO.PantallaVentaEntrada
{
    partial class FormRegistrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.grillaTarifasExistentes = new System.Windows.Forms.DataGridView();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNuevaEntrada = new System.Windows.Forms.GroupBox();
            this.txtMaximoEntradas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboExposiciones = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDTarifa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoAdicional = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMontoEntrada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNroEntradasDetalle = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonConfirmarVenta = new System.Windows.Forms.Button();
            this.txtNroEntradas = new System.Windows.Forms.TextBox();
            this.txtDuracionEstimada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxTarifasExistentes = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.labelFechaActual = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.txtTipoEntrada = new System.Windows.Forms.TextBox();
            this.txtTipoVisita = new System.Windows.Forms.TextBox();
            this.botonCalcularTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarifasExistentes)).BeginInit();
            this.groupBoxNuevaEntrada.SuspendLayout();
            this.groupBoxDetalle.SuspendLayout();
            this.groupBoxTarifasExistentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar venta de entradas";
            // 
            // grillaTarifasExistentes
            // 
            this.grillaTarifasExistentes.AllowUserToAddRows = false;
            this.grillaTarifasExistentes.AllowUserToDeleteRows = false;
            this.grillaTarifasExistentes.BackgroundColor = System.Drawing.Color.Black;
            this.grillaTarifasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarifasExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monto,
            this.tipoEntrada,
            this.tipoVisita,
            this.montoAdicional});
            this.grillaTarifasExistentes.GridColor = System.Drawing.Color.Silver;
            this.grillaTarifasExistentes.Location = new System.Drawing.Point(1, 29);
            this.grillaTarifasExistentes.Name = "grillaTarifasExistentes";
            this.grillaTarifasExistentes.ReadOnly = true;
            this.grillaTarifasExistentes.RowHeadersVisible = false;
            this.grillaTarifasExistentes.Size = new System.Drawing.Size(362, 421);
            this.grillaTarifasExistentes.TabIndex = 1;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 55;
            // 
            // tipoEntrada
            // 
            this.tipoEntrada.HeaderText = "Tipo de entrada";
            this.tipoEntrada.Name = "tipoEntrada";
            this.tipoEntrada.ReadOnly = true;
            this.tipoEntrada.Width = 124;
            // 
            // tipoVisita
            // 
            this.tipoVisita.HeaderText = "Tipo de visita";
            this.tipoVisita.Name = "tipoVisita";
            this.tipoVisita.ReadOnly = true;
            this.tipoVisita.Width = 124;
            // 
            // montoAdicional
            // 
            this.montoAdicional.HeaderText = "Monto adicional";
            this.montoAdicional.Name = "montoAdicional";
            this.montoAdicional.ReadOnly = true;
            this.montoAdicional.Width = 55;
            // 
            // groupBoxNuevaEntrada
            // 
            this.groupBoxNuevaEntrada.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxNuevaEntrada.Controls.Add(this.botonCalcularTotal);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtTipoVisita);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtTipoEntrada);
            this.groupBoxNuevaEntrada.Controls.Add(this.botonVolver);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtMaximoEntradas);
            this.groupBoxNuevaEntrada.Controls.Add(this.label14);
            this.groupBoxNuevaEntrada.Controls.Add(this.label2);
            this.groupBoxNuevaEntrada.Controls.Add(this.comboExposiciones);
            this.groupBoxNuevaEntrada.Controls.Add(this.label10);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtIDTarifa);
            this.groupBoxNuevaEntrada.Controls.Add(this.label9);
            this.groupBoxNuevaEntrada.Controls.Add(this.groupBoxDetalle);
            this.groupBoxNuevaEntrada.Controls.Add(this.botonCancelar);
            this.groupBoxNuevaEntrada.Controls.Add(this.botonConfirmarVenta);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtNroEntradas);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtDuracionEstimada);
            this.groupBoxNuevaEntrada.Controls.Add(this.label3);
            this.groupBoxNuevaEntrada.Controls.Add(this.label4);
            this.groupBoxNuevaEntrada.Controls.Add(this.label5);
            this.groupBoxNuevaEntrada.Controls.Add(this.label6);
            this.groupBoxNuevaEntrada.Controls.Add(this.label7);
            this.groupBoxNuevaEntrada.ForeColor = System.Drawing.Color.White;
            this.groupBoxNuevaEntrada.Location = new System.Drawing.Point(12, 53);
            this.groupBoxNuevaEntrada.Name = "groupBoxNuevaEntrada";
            this.groupBoxNuevaEntrada.Size = new System.Drawing.Size(362, 456);
            this.groupBoxNuevaEntrada.TabIndex = 1;
            this.groupBoxNuevaEntrada.TabStop = false;
            this.groupBoxNuevaEntrada.Text = "Nueva entrada";
            // 
            // txtMaximoEntradas
            // 
            this.txtMaximoEntradas.Enabled = false;
            this.txtMaximoEntradas.Location = new System.Drawing.Point(299, 170);
            this.txtMaximoEntradas.Name = "txtMaximoEntradas";
            this.txtMaximoEntradas.Size = new System.Drawing.Size(57, 20);
            this.txtMaximoEntradas.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label14.Location = new System.Drawing.Point(222, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "Máximo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(216, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "(seleccionar en la grilla)";
            // 
            // comboExposiciones
            // 
            this.comboExposiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExposiciones.FormattingEnabled = true;
            this.comboExposiciones.Location = new System.Drawing.Point(156, 117);
            this.comboExposiciones.Name = "comboExposiciones";
            this.comboExposiciones.Size = new System.Drawing.Size(200, 21);
            this.comboExposiciones.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(61, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Exposición:";
            // 
            // txtIDTarifa
            // 
            this.txtIDTarifa.Enabled = false;
            this.txtIDTarifa.Location = new System.Drawing.Point(156, 36);
            this.txtIDTarifa.Name = "txtIDTarifa";
            this.txtIDTarifa.Size = new System.Drawing.Size(54, 20);
            this.txtIDTarifa.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(80, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID tarifa:";
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.label13);
            this.groupBoxDetalle.Controls.Add(this.txtTotal);
            this.groupBoxDetalle.Controls.Add(this.label12);
            this.groupBoxDetalle.Controls.Add(this.txtMontoAdicional);
            this.groupBoxDetalle.Controls.Add(this.label11);
            this.groupBoxDetalle.Controls.Add(this.txtMontoEntrada);
            this.groupBoxDetalle.Controls.Add(this.label8);
            this.groupBoxDetalle.Controls.Add(this.txtNroEntradasDetalle);
            this.groupBoxDetalle.ForeColor = System.Drawing.Color.White;
            this.groupBoxDetalle.Location = new System.Drawing.Point(36, 245);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(292, 142);
            this.groupBoxDetalle.TabIndex = 11;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label13.Location = new System.Drawing.Point(93, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "TOTAL:  $";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(174, 110);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(73, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label12.Location = new System.Drawing.Point(32, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Monto adicional:  $";
            // 
            // txtMontoAdicional
            // 
            this.txtMontoAdicional.Enabled = false;
            this.txtMontoAdicional.Location = new System.Drawing.Point(174, 84);
            this.txtMontoAdicional.Name = "txtMontoAdicional";
            this.txtMontoAdicional.Size = new System.Drawing.Size(73, 20);
            this.txtMontoAdicional.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(39, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Monto entrada:  $";
            // 
            // txtMontoEntrada
            // 
            this.txtMontoEntrada.Enabled = false;
            this.txtMontoEntrada.Location = new System.Drawing.Point(174, 58);
            this.txtMontoEntrada.Name = "txtMontoEntrada";
            this.txtMontoEntrada.Size = new System.Drawing.Size(73, 20);
            this.txtMontoEntrada.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(38, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "N° de entradas:  $";
            // 
            // txtNroEntradasDetalle
            // 
            this.txtNroEntradasDetalle.Enabled = false;
            this.txtNroEntradasDetalle.Location = new System.Drawing.Point(174, 32);
            this.txtNroEntradasDetalle.Name = "txtNroEntradasDetalle";
            this.txtNroEntradasDetalle.Size = new System.Drawing.Size(73, 20);
            this.txtNroEntradasDetalle.TabIndex = 6;
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.Color.Black;
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonCancelar.FlatAppearance.BorderSize = 0;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonCancelar.Location = new System.Drawing.Point(158, 398);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(82, 34);
            this.botonCancelar.TabIndex = 11;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonConfirmarVenta
            // 
            this.botonConfirmarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonConfirmarVenta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonConfirmarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonConfirmarVenta.FlatAppearance.BorderSize = 0;
            this.botonConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonConfirmarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmarVenta.ForeColor = System.Drawing.Color.Black;
            this.botonConfirmarVenta.Location = new System.Drawing.Point(246, 398);
            this.botonConfirmarVenta.Name = "botonConfirmarVenta";
            this.botonConfirmarVenta.Size = new System.Drawing.Size(110, 34);
            this.botonConfirmarVenta.TabIndex = 10;
            this.botonConfirmarVenta.Text = "Confirmar venta";
            this.botonConfirmarVenta.UseVisualStyleBackColor = false;
            this.botonConfirmarVenta.Click += new System.EventHandler(this.botonConfirmarVenta_Click);
            // 
            // txtNroEntradas
            // 
            this.txtNroEntradas.Location = new System.Drawing.Point(156, 170);
            this.txtNroEntradas.Name = "txtNroEntradas";
            this.txtNroEntradas.Size = new System.Drawing.Size(60, 20);
            this.txtNroEntradas.TabIndex = 5;
            // 
            // txtDuracionEstimada
            // 
            this.txtDuracionEstimada.Enabled = false;
            this.txtDuracionEstimada.Location = new System.Drawing.Point(156, 144);
            this.txtDuracionEstimada.Name = "txtDuracionEstimada";
            this.txtDuracionEstimada.Size = new System.Drawing.Size(60, 20);
            this.txtDuracionEstimada.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(46, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de visita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(32, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "N° de entradas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(26, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(4, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duración estimada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(222, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "minutos";
            // 
            // groupBoxTarifasExistentes
            // 
            this.groupBoxTarifasExistentes.Controls.Add(this.grillaTarifasExistentes);
            this.groupBoxTarifasExistentes.ForeColor = System.Drawing.Color.White;
            this.groupBoxTarifasExistentes.Location = new System.Drawing.Point(380, 53);
            this.groupBoxTarifasExistentes.Name = "groupBoxTarifasExistentes";
            this.groupBoxTarifasExistentes.Size = new System.Drawing.Size(364, 456);
            this.groupBoxTarifasExistentes.TabIndex = 2;
            this.groupBoxTarifasExistentes.TabStop = false;
            this.groupBoxTarifasExistentes.Text = "Tarifas existentes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label15.Location = new System.Drawing.Point(591, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 88;
            this.label15.Text = "Fecha:";
            // 
            // labelFechaActual
            // 
            this.labelFechaActual.AutoSize = true;
            this.labelFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.labelFechaActual.Location = new System.Drawing.Point(655, 16);
            this.labelFechaActual.Name = "labelFechaActual";
            this.labelFechaActual.Size = new System.Drawing.Size(14, 20);
            this.labelFechaActual.TabIndex = 89;
            this.labelFechaActual.Text = "-";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.Color.Black;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonVolver.Location = new System.Drawing.Point(8, 398);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(82, 34);
            this.botonVolver.TabIndex = 88;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // txtTipoEntrada
            // 
            this.txtTipoEntrada.Location = new System.Drawing.Point(156, 65);
            this.txtTipoEntrada.Name = "txtTipoEntrada";
            this.txtTipoEntrada.Size = new System.Drawing.Size(200, 20);
            this.txtTipoEntrada.TabIndex = 89;
            // 
            // txtTipoVisita
            // 
            this.txtTipoVisita.Location = new System.Drawing.Point(156, 91);
            this.txtTipoVisita.Name = "txtTipoVisita";
            this.txtTipoVisita.Size = new System.Drawing.Size(200, 20);
            this.txtTipoVisita.TabIndex = 90;
            // 
            // botonCalcularTotal
            // 
            this.botonCalcularTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonCalcularTotal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCalcularTotal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonCalcularTotal.FlatAppearance.BorderSize = 0;
            this.botonCalcularTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonCalcularTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCalcularTotal.ForeColor = System.Drawing.Color.Black;
            this.botonCalcularTotal.Location = new System.Drawing.Point(246, 205);
            this.botonCalcularTotal.Name = "botonCalcularTotal";
            this.botonCalcularTotal.Size = new System.Drawing.Size(110, 34);
            this.botonCalcularTotal.TabIndex = 91;
            this.botonCalcularTotal.Text = "Calcular Total";
            this.botonCalcularTotal.UseVisualStyleBackColor = false;
            // 
            // FormRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.labelFechaActual);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBoxTarifasExistentes);
            this.Controls.Add(this.groupBoxNuevaEntrada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 560);
            this.MinimumSize = new System.Drawing.Size(770, 560);
            this.Name = "FormRegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nueva venta";
            this.Load += new System.EventHandler(this.RegistrarVentaDeEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarifasExistentes)).EndInit();
            this.groupBoxNuevaEntrada.ResumeLayout(false);
            this.groupBoxNuevaEntrada.PerformLayout();
            this.groupBoxDetalle.ResumeLayout(false);
            this.groupBoxDetalle.PerformLayout();
            this.groupBoxTarifasExistentes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaTarifasExistentes;
        private System.Windows.Forms.GroupBox groupBoxNuevaEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonConfirmarVenta;
        private System.Windows.Forms.TextBox txtNroEntradas;
        private System.Windows.Forms.TextBox txtDuracionEstimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAdicional;
        private System.Windows.Forms.ComboBox comboExposiciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDTarifa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMontoAdicional;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMontoEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNroEntradasDetalle;
        private System.Windows.Forms.GroupBox groupBoxTarifasExistentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaximoEntradas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelFechaActual;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.TextBox txtTipoVisita;
        private System.Windows.Forms.TextBox txtTipoEntrada;
        private System.Windows.Forms.Button botonCalcularTotal;
    }
}