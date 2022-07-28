using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void rjControls1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_factura form_Factura = new Form_factura();
            form_Factura.Show();
        }

        private void label_name_empresa_Click(object sender, EventArgs e)
        {

        }

        private void boton_cotizacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_cotiza form_Cotiza = new Form_cotiza();
            form_Cotiza.Show();
        }

        private void buton_Orden_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_orden_compra form_Factura = new Form_orden_compra();
            form_Factura.Show();
        }
    }
}
