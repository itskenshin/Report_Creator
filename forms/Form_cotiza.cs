using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// para maneejar los pdf
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
// para guardar archivos
using System.IO;
namespace Facturacion
{
    public partial class Form_cotiza : Form
    {
        public Form_cotiza()
        {
            InitializeComponent();
        }


        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {   // una condicional para verificar si hay campos vacios si encuentra se mostrara un dialogo
            if (ltmbox.Texts == String.Empty || codprodcbox.Texts == String.Empty || 
                descriProductBox.Texts == String.Empty || bodgbox.Texts == String.Empty || 
                boxcantidad.Texts == String.Empty || boxunid.Texts == String.Empty
                && boxprecio.Texts == String.Empty  || impbox.Texts == String.Empty || impmontobox.Texts == String.Empty)

            {
                var messageValuee = MessageBox.Show("Por favor llene los campos de los productos",
                                     "Confirmar",
                                     MessageBoxButtons.OK);
                
            }
            else
            {   try
                {
                    int indicarfila = gridprodc.Rows.Add(); // cuando le damos agregar producto nos crea una fila y guardo el indice de esa fila
                    DataGridViewRow fila = gridprodc.Rows[indicarfila]; // guardamos esa fila especifica 

                    // aqui cada celda de la tabla sera remplazada por lo que dijitee en el textbox del formulario
                    fila.Cells["Ltm"].Value = ltmbox.Texts; 
                    fila.Cells["Cod.Pro"].Value = codprodcbox.Texts;
                    fila.Cells["Descripcion Producto"].Value = descriProductBox.Texts;
                    fila.Cells["Bodg."].Value = bodgbox.Texts;
                    fila.Cells["Cantidad"].Value = boxcantidad.Texts;
                    fila.Cells["Unid."].Value = boxunid.Texts;
                    fila.Cells["Precio"].Value = boxprecio.Texts;
                    fila.Cells["Dto.%"].Value = boxprecio.Texts;
                    fila.Cells["Imp.%"].Value = impbox.Texts;
                    fila.Cells["Imp.Monto"].Value = impmontobox.Texts;
                    fila.Cells["Importe"].Value = decimal.Parse(boxcantidad.Texts) * decimal.Parse(boxprecio.Texts);

                }
                catch
                {
                    var messageValuee = MessageBox.Show("Introduzca los campos correctamente",
                                     "Confirmar",
                                     MessageBoxButtons.OK);
                }
                


            }



        }

        private void gridprodc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_cotiza_Load(object sender, EventArgs e)
        {   // cuando cargue el form se crean columnas para la tabla
            gridprodc.Columns.Add("Ltm","Ltm");
            gridprodc.Columns.Add("Cod.Pro", "Cod.Pro");
            gridprodc.Columns.Add("Descripcion Producto", "Descripcion Producto");
            gridprodc.Columns.Add("Bodg.", "Bodg.");
            gridprodc.Columns.Add("Cantidad", "Cantidad");
            gridprodc.Columns.Add("Unid.", "Unid.");
            gridprodc.Columns.Add("Precio", "Precio");
            gridprodc.Columns.Add("Dto.%", "Dto.%");
            gridprodc.Columns.Add("Imp.%", "Imp.%");
            gridprodc.Columns.Add("Imp.Monto", "Imp.Monto");
            gridprodc.Columns.Add("Importe", "Importe");

        }

        
        // cuando presionemos el boton imprimir
        private void butonImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog(); // para guardar 
            saveFile.FileName = "NombrarArchivo" + ".pdf"; // el archivo a guardar tendra por default la fecha actual





            // generar un pdf con un html

            string paginahtml_texto = Properties.Resources.cotizacion.ToString(); // pasar aqui la plantilla html primero agregar la plantilla a recursos 

            paginahtml_texto = paginahtml_texto.Replace("@NUMERO", textBox_numeroCoti.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", textboxFecha.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@PAGINA", textboxPagina.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@EMPRESA", textBox_nombre.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@RNC", textBox_RNC.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@CODIGOCLIENTE", textBoxCodigoCliente.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@RFC", textboxRFC.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@REFERENCIA", textBoxReferencia.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@TERMINOS", textBoxTerminos.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@VENDEDOR", textBoxVendedor.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@MONEDA", textBoxMoneda.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@EMITE", textBoxEmite.Texts);

            string filas = String.Empty;
            decimal total = 0;


            foreach (DataGridViewRow row in gridprodc.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Ltm"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cod.Pro"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Bodg."].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Unid."].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Dto.%"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Imp.%"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Imp.Monto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + " </td>";
                filas += "</tr>";

            }
            paginahtml_texto = paginahtml_texto.Replace("@Filas", filas);

            if (saveFile.ShowDialog() == DialogResult.OK) // cuando se muestre la ventana de guardar si le damos ok realizara lo siguiente
            {   
                using (FileStream stream = new FileStream(saveFile.FileName,FileMode.Create)) // va guardar el archivo esto es un streeam async operations
                {
                    Document pdfDoc = new Document(PageSize.A3, 25, 25, 25, 25); // definiendo caracteristica del pdf

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc,stream); // se encarga de escribir en el pdf lo que se guarda

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase("")); // podemos agregar una frase al pdf 

                   using (StringReader sr = new StringReader(paginahtml_texto))// para leer la estructura html aqui le pasamos el html
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr); // aqui es como diciendo writer ten en cuenta en mi doc de mi pdf que puedas incrustar el html
                    }
                    pdfDoc.Close();

                    stream.Close();


                }
                
            }
        }

        private void rjControls1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void cleanbuton_Click(object sender, EventArgs e)
        {
            textBox_nombre.Texts = "";
            textBox_RNC.Texts = "";
            textBoxCodigoCliente.Texts = "";
            textboxRFC.Texts = "";
            textBoxReferencia.Texts = "";
            textBoxTerminos.Texts = "";
            textBoxVendedor.Texts = "";
            textBoxMoneda.Texts = "";
            textBoxEmite.Texts = "";
            textBox_numeroCoti.Texts = "";
            textboxFecha.Texts = "";
            textboxPagina.Texts = "";
            ltmbox.Texts = "";
            codprodcbox.Texts = "";
            descriProductBox.Texts = "";
            bodgbox.Texts = "";
            boxcantidad.Texts = "";
            boxunid.Texts = "";
            boxprecio.Texts = "";
            impbox.Texts = "";
            impmontobox.Texts = "";
            importebox.Texts = "";

        }
    }
}
