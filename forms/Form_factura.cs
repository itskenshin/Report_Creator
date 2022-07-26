﻿using System;
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
using System.Text.RegularExpressions;

namespace Facturacion
{
    public partial class Form_factura : Form
    {
        public Form_factura()
        {
            InitializeComponent();
        }

        private void Form_factura_Load(object sender, EventArgs e)
        {
            // cuando cargue el form se crean columnas para la tabla
            gridfactura.Columns.Add("REF", "REF");
            gridfactura.Columns.Add("CANTIDAD", "CANTIDAD");
            gridfactura.Columns.Add("DESCRIPCION", "DESCRIPCION");
            gridfactura.Columns.Add("PRECIO UNITARIO", "PRECIO UNITARIO");
            gridfactura.Columns.Add("TOTAL", "TOTAL");


        }

        private void botonmenuprincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            // una condicional para verificar si hay campos vacios si encuentra se mostrara un dialogo
            Regex rx = new Regex(@"^([1-9]\d*(\.)\d*|0?(\.)\d*[1-9]\d*|[1-9]\d*)$");
            if (refbox.Texts == String.Empty || descrbox.Texts == String.Empty ||
                cantidadbox.Texts == String.Empty || preciunibox.Texts == String.Empty
                )

            {
                var messageValuee = MessageBox.Show("Por favor llene los campos de los productos",
                                     "Confirmar",
                                     MessageBoxButtons.OK);

            }
            else if (descrbox.Texts.Length > 75)
            {
                var messageValuee = MessageBox.Show("Por favor introduza una descripcion de producto mas corta",
                                    "Confirmar",
                                    MessageBoxButtons.OK);
            }
            else if (rx.IsMatch(cantidadbox.Texts) != true || rx.IsMatch(preciunibox.Texts) != true || rx.IsMatch(impuestobox.Texts) != true
                || rx.IsMatch(descuentobox.Texts) != true)
            {
                var messageValuee = MessageBox.Show("Por favor introduza valor numericos preferible en decimales ",
                                  "Confirmar",
                                  MessageBoxButtons.OK);
            }

            else
            {
                try
                {
                    int indicarfila = gridfactura.Rows.Add(); // cuando le damos agregar producto nos crea una fila y guardo el indice de esa fila
                    DataGridViewRow fila = gridfactura.Rows[indicarfila]; // guardamos esa fila especifica 

                    // aqui cada celda de la tabla sera remplazada por lo que dijitee en el textbox del formulario
                    fila.Cells["REF"].Value = refbox.Texts;
                    fila.Cells["CANTIDAD"].Value = cantidadbox.Texts;
                    fila.Cells["DESCRIPCION"].Value = descrbox.Texts;
                    fila.Cells["PRECIO UNITARIO"].Value = preciunibox.Texts;
                    decimal suma = decimal.Parse(cantidadbox.Texts) * decimal.Parse(preciunibox.Texts);
                    string re = String.Format("{0:0.00}", suma);
                    fila.Cells["TOTAL"].Value = re;
                    

                    

                }
                catch
                {
                    var messageValuee = MessageBox.Show("Introduzca los campos correctamente",
                                     "Confirmar",
                                     MessageBoxButtons.OK);
                }



            }
        }

        private void cleanbuton_Click(object sender, EventArgs e)
        {   clientebox.Texts = String.Empty;
            nfcbox.Texts = string.Empty;
            rncbox.Texts = string.Empty;
            dirrecionbox.Texts = string.Empty;
            telbox.Texts = string.Empty;
            vendedorbox.Texts = string.Empty;
            obrabox.Texts = string.Empty;
            numerobox.Texts = string.Empty;
            fechabox.Texts = string.Empty;
            condibox.Texts = string.Empty;
            vencibox.Texts = string.Empty;
            ordenbox.Texts = string.Empty;
            pagbox.Texts = string.Empty;
            refbox.Texts = string.Empty;
            cantidadbox.Texts = string.Empty;
            descrbox.Texts = string.Empty;
            preciunibox.Texts = string.Empty;
            
            descuentobox.Texts = string.Empty;
            
            impuestobox.Texts = string.Empty;
            
            
            

        }



        private void butonImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog(); // para guardar 
            saveFile.Filter = "PDF document (*.pdf)|*.pdf";
            saveFile.FileName = DateTime.Now.ToString("probando") + ".pdf"; // el archivo a guardar tendra por default la fecha actual





            // generar un pdf con un html

            string paginahtml_texto = Properties.Resources.index.ToString(); // pasar aqui la plantilla html primero agregar la plantilla a recursos 

            
            paginahtml_texto = paginahtml_texto.Replace("@NFC", nfcbox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@RNC", rncbox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", clientebox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@DIRECCION", dirrecionbox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@VENDEDOR", vendedorbox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@OBRA", obrabox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@NUMERO", numerobox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", fechabox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@CONDICIONES", condibox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@VENCIMIENTO", vencibox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@ORDEN", ordenbox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@PAGINA", pagbox.Texts);
            
            paginahtml_texto = paginahtml_texto.Replace("@DESCUENTO", descuentobox.Texts);
            paginahtml_texto = paginahtml_texto.Replace("@IMPUESTO", impuestobox.Texts);
            
            paginahtml_texto = paginahtml_texto.Replace("@TELEFONO", telbox.Texts);


            string filas = String.Empty;
            decimal total = 0;
            decimal totaldescuento = 0;
            decimal totalimpuesto = 0;
            decimal valorneto = 0;
            foreach (DataGridViewRow row in gridfactura.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["REF"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["CANTIDAD"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["DESCRIPCION"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PRECIO UNITARIO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["TOTAL"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["TOTAL"].Value.ToString());
            }
            if (descuentobox.Texts != String.Empty && impuestobox.Texts != String.Empty)
            {

                totaldescuento = total * ((decimal.Parse(impuestobox.Texts) / 100));
                totalimpuesto = total * ((decimal.Parse(descuentobox.Texts) / 100));
                valorneto = (total - totaldescuento) + totalimpuesto;

                
            }
            string re = String.Format("{0:0.00}", totaldescuento);
            string re2 = String.Format("{0:0.00}", totalimpuesto);
            string re3 = String.Format("{0:0.00}", valorneto);



            paginahtml_texto = paginahtml_texto.Replace("@Filas", filas);
            paginahtml_texto = paginahtml_texto.Replace("@B", total.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@D", re);
            paginahtml_texto = paginahtml_texto.Replace("@I", re2);
            paginahtml_texto = paginahtml_texto.Replace("@V", re3);




            if (saveFile.ShowDialog() == DialogResult.OK) // cuando se muestre la ventana de guardar si le damos ok realizara lo siguiente
            {
                try
                {

                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create)) // va guardar el archivo esto es un streeam async operations
                    {
                        Document pdfDoc = new Document(PageSize.A3, 25, 25, 25, 25); // definiendo caracteristica del pdf

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream); // se encarga de escribir en el pdf lo que se guarda

                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase("")); // podemos agregar una frase al pdf 

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.colorrojo, System.Drawing.Imaging.ImageFormat.Png);

                        img.ScaleToFit(350, 350);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
                        img.SetAbsolutePosition(pdfDoc.LeftMargin + 485 , pdfDoc.Top - 285);
                        pdfDoc.Add(img);

                        using (StringReader sr = new StringReader(paginahtml_texto)) // para leer la estructura html aqui le pasamos el html
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr); // aqui es como diciendo writer ten en cuenta en mi doc de mi pdf que puedas incrustar el html
                        }
                        pdfDoc.Close();

                        stream.Close();

                        var messageValuee = MessageBox.Show("Su archivo se ha descargado correctamente",
                                     "Confirmar",
                                     MessageBoxButtons.OK);


                    }
                }
                catch
                {
                    var messageValuee = MessageBox.Show("Por favor cierre el pdf que se encuentra abierto y vuelve a realizar el proceso de reporte",
                                     "Confirmar",
                                     MessageBoxButtons.OK);
                }
            }
        }

        private void borrarbuton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.gridfactura   .SelectedRows)
            {
                gridfactura.Rows.RemoveAt(item.Index);
            }
        }

        private void cantidadbox_Enter(object sender, EventArgs e)
        {
            cantidadbox.Texts = "";
        }

        private void preciunibox_Enter(object sender, EventArgs e)
        {
            preciunibox.Texts = "";
        }

        private void descuentobox_Enter(object sender, EventArgs e)
        {
            descuentobox.Texts = "";
        }

        private void impuestobox_Enter(object sender, EventArgs e)
        {
            impuestobox.Texts = "";
        }
    }
}
