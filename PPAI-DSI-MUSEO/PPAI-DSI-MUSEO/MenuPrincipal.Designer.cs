
namespace PPAI_DSI_MUSEO
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.botonRegistrarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.monalisa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monalisa)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRegistrarVenta
            // 
            this.botonRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonRegistrarVenta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonRegistrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.botonRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarVenta.ForeColor = System.Drawing.Color.Black;
            this.botonRegistrarVenta.Location = new System.Drawing.Point(561, 418);
            this.botonRegistrarVenta.Name = "botonRegistrarVenta";
            this.botonRegistrarVenta.Size = new System.Drawing.Size(181, 80);
            this.botonRegistrarVenta.TabIndex = 1;
            this.botonRegistrarVenta.Text = "Registrar venta";
            this.botonRegistrarVenta.UseVisualStyleBackColor = false;
            this.botonRegistrarVenta.Click += new System.EventHandler(this.botonRegistrarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(90, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Haga click en el botón para instanciar el caso de uso.";
            this.label1.Visible = false;
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.Black;
            this.botonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.botonSalir.Location = new System.Drawing.Point(12, 418);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(181, 80);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(208, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "MUSEO PICTÓRICO";
            // 
            // flecha
            // 
            this.flecha.Image = global::PPAI_DSI_MUSEO.Properties.Resources.felcha1;
            this.flecha.Location = new System.Drawing.Point(371, 389);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(184, 139);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 15;
            this.flecha.TabStop = false;
            // 
            // monalisa
            // 
            this.monalisa.Image = global::PPAI_DSI_MUSEO.Properties.Resources.descarga;
            this.monalisa.Location = new System.Drawing.Point(244, 12);
            this.monalisa.Name = "monalisa";
            this.monalisa.Size = new System.Drawing.Size(261, 197);
            this.monalisa.TabIndex = 14;
            this.monalisa.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(754, 521);
            this.Controls.Add(this.flecha);
            this.Controls.Add(this.monalisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRegistrarVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(770, 560);
            this.MinimumSize = new System.Drawing.Size(770, 560);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monalisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegistrarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox monalisa;
        private System.Windows.Forms.PictureBox flecha;
    }
}

