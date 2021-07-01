
namespace PPAI_DSI_MUSEO.PantallaVentaEntrada
{
    partial class PantallaVentaEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaVentaEntrada));
            this.label1 = new System.Windows.Forms.Label();
            this.grillaTarifasExistentes = new System.Windows.Forms.DataGridView();
            this.idTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNuevaEntrada = new System.Windows.Forms.GroupBox();
            this.comboExposiciones = new System.Windows.Forms.ComboBox();
            this.botonCalcularTotal = new System.Windows.Forms.Button();
            this.txtTipoVisita = new System.Windows.Forms.TextBox();
            this.txtTipoEntrada = new System.Windows.Forms.TextBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.txtMaximoEntradas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDTarifa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.lblSedeActual = new System.Windows.Forms.Label();
            this.lbl99 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.grillaTarifasExistentes.AllowUserToResizeColumns = false;
            this.grillaTarifasExistentes.AllowUserToResizeRows = false;
            this.grillaTarifasExistentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.grillaTarifasExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaTarifasExistentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grillaTarifasExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaTarifasExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaTarifasExistentes.ColumnHeadersHeight = 24;
            this.grillaTarifasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillaTarifasExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarifa,
            this.monto,
            this.tipoEntrada,
            this.tipoVisita,
            this.montoAdicional});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaTarifasExistentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaTarifasExistentes.EnableHeadersVisualStyles = false;
            this.grillaTarifasExistentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.grillaTarifasExistentes.Location = new System.Drawing.Point(1, 29);
            this.grillaTarifasExistentes.MultiSelect = false;
            this.grillaTarifasExistentes.Name = "grillaTarifasExistentes";
            this.grillaTarifasExistentes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaTarifasExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaTarifasExistentes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grillaTarifasExistentes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grillaTarifasExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaTarifasExistentes.Size = new System.Drawing.Size(461, 421);
            this.grillaTarifasExistentes.TabIndex = 1;
            this.grillaTarifasExistentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTarifasExistentes_CellClick);
            this.grillaTarifasExistentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTarifasExistentes_CellContentClick);
            this.grillaTarifasExistentes.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTarifasExistentes_CellMouseLeave);
            this.grillaTarifasExistentes.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grillaTarifasExistentes_CellMouseMove);
            // 
            // idTarifa
            // 
            this.idTarifa.DataPropertyName = "idTarifa";
            this.idTarifa.HeaderText = "ID";
            this.idTarifa.Name = "idTarifa";
            this.idTarifa.ReadOnly = true;
            this.idTarifa.Width = 35;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 60;
            // 
            // tipoEntrada
            // 
            this.tipoEntrada.DataPropertyName = "idTipoEn";
            this.tipoEntrada.HeaderText = "Tipo de entrada";
            this.tipoEntrada.Name = "tipoEntrada";
            this.tipoEntrada.ReadOnly = true;
            this.tipoEntrada.Width = 124;
            // 
            // tipoVisita
            // 
            this.tipoVisita.DataPropertyName = "tipoVisita";
            this.tipoVisita.HeaderText = "Tipo de visita";
            this.tipoVisita.Name = "tipoVisita";
            this.tipoVisita.ReadOnly = true;
            this.tipoVisita.Width = 124;
            // 
            // montoAdicional
            // 
            this.montoAdicional.DataPropertyName = "montoAdicional";
            this.montoAdicional.HeaderText = "Adicional guía";
            this.montoAdicional.Name = "montoAdicional";
            this.montoAdicional.ReadOnly = true;
            this.montoAdicional.Width = 115;
            // 
            // groupBoxNuevaEntrada
            // 
            this.groupBoxNuevaEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.groupBoxNuevaEntrada.Controls.Add(this.label18);
            this.groupBoxNuevaEntrada.Controls.Add(this.comboExposiciones);
            this.groupBoxNuevaEntrada.Controls.Add(this.botonCalcularTotal);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtTipoVisita);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtTipoEntrada);
            this.groupBoxNuevaEntrada.Controls.Add(this.botonVolver);
            this.groupBoxNuevaEntrada.Controls.Add(this.txtMaximoEntradas);
            this.groupBoxNuevaEntrada.Controls.Add(this.label14);
            this.groupBoxNuevaEntrada.Controls.Add(this.label2);
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
            this.groupBoxNuevaEntrada.Text = "Nueva venta";
            // 
            // comboExposiciones
            // 
            this.comboExposiciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.comboExposiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExposiciones.Enabled = false;
            this.comboExposiciones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboExposiciones.FormattingEnabled = true;
            this.comboExposiciones.Location = new System.Drawing.Point(156, 143);
            this.comboExposiciones.Name = "comboExposiciones";
            this.comboExposiciones.Size = new System.Drawing.Size(121, 21);
            this.comboExposiciones.TabIndex = 92;
            this.comboExposiciones.SelectedIndexChanged += new System.EventHandler(this.comboExposiciones_SelectedIndexChanged);
            // 
            // botonCalcularTotal
            // 
            this.botonCalcularTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonCalcularTotal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCalcularTotal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonCalcularTotal.FlatAppearance.BorderSize = 0;
            this.botonCalcularTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonCalcularTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCalcularTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCalcularTotal.ForeColor = System.Drawing.Color.Black;
            this.botonCalcularTotal.Location = new System.Drawing.Point(246, 185);
            this.botonCalcularTotal.Name = "botonCalcularTotal";
            this.botonCalcularTotal.Size = new System.Drawing.Size(110, 46);
            this.botonCalcularTotal.TabIndex = 91;
            this.botonCalcularTotal.Text = "Calcular total";
            this.botonCalcularTotal.UseVisualStyleBackColor = false;
            this.botonCalcularTotal.Click += new System.EventHandler(this.botonCalcularTotal_Click);
            // 
            // txtTipoVisita
            // 
            this.txtTipoVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTipoVisita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoVisita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtTipoVisita.Location = new System.Drawing.Point(156, 91);
            this.txtTipoVisita.Name = "txtTipoVisita";
            this.txtTipoVisita.ReadOnly = true;
            this.txtTipoVisita.Size = new System.Drawing.Size(200, 20);
            this.txtTipoVisita.TabIndex = 90;
            // 
            // txtTipoEntrada
            // 
            this.txtTipoEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTipoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtTipoEntrada.Location = new System.Drawing.Point(156, 65);
            this.txtTipoEntrada.Name = "txtTipoEntrada";
            this.txtTipoEntrada.ReadOnly = true;
            this.txtTipoEntrada.Size = new System.Drawing.Size(200, 20);
            this.txtTipoEntrada.TabIndex = 89;
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonVolver.Location = new System.Drawing.Point(5, 398);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(82, 34);
            this.botonVolver.TabIndex = 88;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // txtMaximoEntradas
            // 
            this.txtMaximoEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtMaximoEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaximoEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtMaximoEntradas.Location = new System.Drawing.Point(176, 185);
            this.txtMaximoEntradas.Name = "txtMaximoEntradas";
            this.txtMaximoEntradas.ReadOnly = true;
            this.txtMaximoEntradas.Size = new System.Drawing.Size(54, 20);
            this.txtMaximoEntradas.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label14.Location = new System.Drawing.Point(9, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "Entradas disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(216, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "(seleccione en la grilla)";
            // 
            // txtIDTarifa
            // 
            this.txtIDTarifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtIDTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDTarifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtIDTarifa.Location = new System.Drawing.Point(156, 39);
            this.txtIDTarifa.Name = "txtIDTarifa";
            this.txtIDTarifa.ReadOnly = true;
            this.txtIDTarifa.Size = new System.Drawing.Size(54, 20);
            this.txtIDTarifa.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(80, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID tarifa:";
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.label17);
            this.groupBoxDetalle.Controls.Add(this.label16);
            this.groupBoxDetalle.Controls.Add(this.label10);
            this.groupBoxDetalle.Controls.Add(this.label13);
            this.groupBoxDetalle.Controls.Add(this.txtTotal);
            this.groupBoxDetalle.Controls.Add(this.label12);
            this.groupBoxDetalle.Controls.Add(this.txtMontoAdicional);
            this.groupBoxDetalle.Controls.Add(this.label11);
            this.groupBoxDetalle.Controls.Add(this.txtMontoEntrada);
            this.groupBoxDetalle.Controls.Add(this.label8);
            this.groupBoxDetalle.Controls.Add(this.txtNroEntradasDetalle);
            this.groupBoxDetalle.ForeColor = System.Drawing.Color.White;
            this.groupBoxDetalle.Location = new System.Drawing.Point(50, 245);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(271, 142);
            this.groupBoxDetalle.TabIndex = 11;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label17.Location = new System.Drawing.Point(162, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label16.Location = new System.Drawing.Point(162, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(162, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label13.Location = new System.Drawing.Point(99, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtTotal.Location = new System.Drawing.Point(180, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(52, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label12.Location = new System.Drawing.Point(39, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Monto adicional:\r\n";
            // 
            // txtMontoAdicional
            // 
            this.txtMontoAdicional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtMontoAdicional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoAdicional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtMontoAdicional.Location = new System.Drawing.Point(180, 79);
            this.txtMontoAdicional.Name = "txtMontoAdicional";
            this.txtMontoAdicional.ReadOnly = true;
            this.txtMontoAdicional.Size = new System.Drawing.Size(52, 20);
            this.txtMontoAdicional.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(18, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Monto por entrada:\r\n";
            // 
            // txtMontoEntrada
            // 
            this.txtMontoEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtMontoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtMontoEntrada.Location = new System.Drawing.Point(180, 53);
            this.txtMontoEntrada.Name = "txtMontoEntrada";
            this.txtMontoEntrada.ReadOnly = true;
            this.txtMontoEntrada.Size = new System.Drawing.Size(52, 20);
            this.txtMontoEntrada.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(44, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "N° de entradas:";
            // 
            // txtNroEntradasDetalle
            // 
            this.txtNroEntradasDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNroEntradasDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroEntradasDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtNroEntradasDetalle.Location = new System.Drawing.Point(180, 27);
            this.txtNroEntradasDetalle.Name = "txtNroEntradasDetalle";
            this.txtNroEntradasDetalle.ReadOnly = true;
            this.txtNroEntradasDetalle.Size = new System.Drawing.Size(52, 20);
            this.txtNroEntradasDetalle.TabIndex = 6;
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonCancelar.FlatAppearance.BorderSize = 0;
            this.botonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.botonConfirmarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.txtNroEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNroEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtNroEntradas.Location = new System.Drawing.Point(176, 211);
            this.txtNroEntradas.Name = "txtNroEntradas";
            this.txtNroEntradas.Size = new System.Drawing.Size(54, 20);
            this.txtNroEntradas.TabIndex = 5;
            // 
            // txtDuracionEstimada
            // 
            this.txtDuracionEstimada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtDuracionEstimada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuracionEstimada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.txtDuracionEstimada.Location = new System.Drawing.Point(156, 117);
            this.txtDuracionEstimada.Name = "txtDuracionEstimada";
            this.txtDuracionEstimada.ReadOnly = true;
            this.txtDuracionEstimada.Size = new System.Drawing.Size(38, 20);
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
            this.label4.Location = new System.Drawing.Point(52, 211);
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
            this.label6.Location = new System.Drawing.Point(4, 117);
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
            this.label7.Location = new System.Drawing.Point(200, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "horas";
            // 
            // groupBoxTarifasExistentes
            // 
            this.groupBoxTarifasExistentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.groupBoxTarifasExistentes.Controls.Add(this.grillaTarifasExistentes);
            this.groupBoxTarifasExistentes.ForeColor = System.Drawing.Color.White;
            this.groupBoxTarifasExistentes.Location = new System.Drawing.Point(380, 53);
            this.groupBoxTarifasExistentes.Name = "groupBoxTarifasExistentes";
            this.groupBoxTarifasExistentes.Size = new System.Drawing.Size(463, 456);
            this.groupBoxTarifasExistentes.TabIndex = 2;
            this.groupBoxTarifasExistentes.TabStop = false;
            this.groupBoxTarifasExistentes.Text = "Tarifas existentes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label15.Location = new System.Drawing.Point(700, 29);
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
            this.labelFechaActual.Location = new System.Drawing.Point(764, 29);
            this.labelFechaActual.Name = "labelFechaActual";
            this.labelFechaActual.Size = new System.Drawing.Size(14, 20);
            this.labelFechaActual.TabIndex = 89;
            this.labelFechaActual.Text = "-";
            // 
            // lblSedeActual
            // 
            this.lblSedeActual.AutoSize = true;
            this.lblSedeActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.lblSedeActual.Location = new System.Drawing.Point(764, 9);
            this.lblSedeActual.Name = "lblSedeActual";
            this.lblSedeActual.Size = new System.Drawing.Size(14, 20);
            this.lblSedeActual.TabIndex = 91;
            this.lblSedeActual.Text = "-";
            // 
            // lbl99
            // 
            this.lbl99.AutoSize = true;
            this.lbl99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.lbl99.Location = new System.Drawing.Point(660, 9);
            this.lbl99.Name = "lbl99";
            this.lbl99.Size = new System.Drawing.Size(98, 20);
            this.lbl99.TabIndex = 90;
            this.lbl99.Text = "Sede actual:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label18.Location = new System.Drawing.Point(61, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 93;
            this.label18.Text = "Exposición:";
            // 
            // PantallaVentaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(854, 521);
            this.Controls.Add(this.lblSedeActual);
            this.Controls.Add(this.lbl99);
            this.Controls.Add(this.labelFechaActual);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBoxTarifasExistentes);
            this.Controls.Add(this.groupBoxNuevaEntrada);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(870, 560);
            this.MinimumSize = new System.Drawing.Size(870, 560);
            this.Name = "PantallaVentaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUSEO - VENTAS";
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAdicional;
        private System.Windows.Forms.Label lblSedeActual;
        private System.Windows.Forms.Label lbl99;
        private System.Windows.Forms.ComboBox comboExposiciones;
        private System.Windows.Forms.Label label18;
    }
}