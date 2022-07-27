namespace Facturacion
{
    partial class Main
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
            this.label_name_empresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_factura = new Facturacion.widgets.RJControls();
            this.boton_cotizacion = new Facturacion.widgets.RJControls();
            this.buton_Orden = new Facturacion.widgets.RJControls();
            this.SuspendLayout();
            // 
            // label_name_empresa
            // 
            this.label_name_empresa.AutoSize = true;
            this.label_name_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_empresa.Location = new System.Drawing.Point(23, 22);
            this.label_name_empresa.Name = "label_name_empresa";
            this.label_name_empresa.Size = new System.Drawing.Size(167, 25);
            this.label_name_empresa.TabIndex = 0;
            this.label_name_empresa.Text = "ILUMINECA EIRL";
            this.label_name_empresa.Click += new System.EventHandler(this.label_name_empresa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione su opción:";
            // 
            // boton_factura
            // 
            this.boton_factura.BackColor = System.Drawing.Color.Crimson;
            this.boton_factura.BackgroundColor = System.Drawing.Color.Crimson;
            this.boton_factura.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_factura.BorderRadius = 20;
            this.boton_factura.BorderSize = 0;
            this.boton_factura.FlatAppearance.BorderSize = 0;
            this.boton_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_factura.ForeColor = System.Drawing.Color.Black;
            this.boton_factura.Location = new System.Drawing.Point(87, 156);
            this.boton_factura.Name = "boton_factura";
            this.boton_factura.Size = new System.Drawing.Size(222, 69);
            this.boton_factura.TabIndex = 5;
            this.boton_factura.Text = "FACTURA";
            this.boton_factura.TextColor = System.Drawing.Color.Black;
            this.boton_factura.UseVisualStyleBackColor = false;
            this.boton_factura.Click += new System.EventHandler(this.rjControls1_Click);
            // 
            // boton_cotizacion
            // 
            this.boton_cotizacion.BackColor = System.Drawing.Color.Crimson;
            this.boton_cotizacion.BackgroundColor = System.Drawing.Color.Crimson;
            this.boton_cotizacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton_cotizacion.BorderRadius = 20;
            this.boton_cotizacion.BorderSize = 0;
            this.boton_cotizacion.FlatAppearance.BorderSize = 0;
            this.boton_cotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cotizacion.ForeColor = System.Drawing.Color.Black;
            this.boton_cotizacion.Location = new System.Drawing.Point(87, 247);
            this.boton_cotizacion.Name = "boton_cotizacion";
            this.boton_cotizacion.Size = new System.Drawing.Size(222, 67);
            this.boton_cotizacion.TabIndex = 6;
            this.boton_cotizacion.Text = "COTIZACION";
            this.boton_cotizacion.TextColor = System.Drawing.Color.Black;
            this.boton_cotizacion.UseVisualStyleBackColor = false;
            // 
            // buton_Orden
            // 
            this.buton_Orden.BackColor = System.Drawing.Color.Crimson;
            this.buton_Orden.BackgroundColor = System.Drawing.Color.Crimson;
            this.buton_Orden.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buton_Orden.BorderRadius = 20;
            this.buton_Orden.BorderSize = 0;
            this.buton_Orden.FlatAppearance.BorderSize = 0;
            this.buton_Orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_Orden.ForeColor = System.Drawing.Color.Black;
            this.buton_Orden.Location = new System.Drawing.Point(87, 337);
            this.buton_Orden.Name = "buton_Orden";
            this.buton_Orden.Size = new System.Drawing.Size(222, 73);
            this.buton_Orden.TabIndex = 7;
            this.buton_Orden.Text = "ORDEN DE COMPRA";
            this.buton_Orden.TextColor = System.Drawing.Color.Black;
            this.buton_Orden.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(406, 454);
            this.Controls.Add(this.buton_Orden);
            this.Controls.Add(this.boton_cotizacion);
            this.Controls.Add(this.boton_factura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_name_empresa);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador_Reportes 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name_empresa;
        private System.Windows.Forms.Label label1;
        private widgets.RJControls boton_factura;
        private widgets.RJControls boton_cotizacion;
        private widgets.RJControls buton_Orden;
    }
}