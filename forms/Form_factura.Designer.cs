namespace Facturacion
{
    partial class Form_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_factura));
            this.rncbox = new Facturacion.widgets.RJTextBox();
            this.rnclabel = new System.Windows.Forms.Label();
            this.clientelabel = new System.Windows.Forms.Label();
            this.clientebox = new Facturacion.widgets.RJTextBox();
            this.direccionlabel = new System.Windows.Forms.Label();
            this.tellabel = new System.Windows.Forms.Label();
            this.vendedorlabel = new System.Windows.Forms.Label();
            this.dirrecionbox = new Facturacion.widgets.RJTextBox();
            this.telbox = new Facturacion.widgets.RJTextBox();
            this.vendedorbox = new Facturacion.widgets.RJTextBox();
            this.nfclabel = new System.Windows.Forms.Label();
            this.nfcbox = new Facturacion.widgets.RJTextBox();
            this.numerolabel = new System.Windows.Forms.Label();
            this.fechalabel = new System.Windows.Forms.Label();
            this.condicioneslabel = new System.Windows.Forms.Label();
            this.vencimientolabel = new System.Windows.Forms.Label();
            this.ordenlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numerobox = new Facturacion.widgets.RJTextBox();
            this.fechabox = new Facturacion.widgets.RJTextBox();
            this.condibox = new Facturacion.widgets.RJTextBox();
            this.vencibox = new Facturacion.widgets.RJTextBox();
            this.ordenbox = new Facturacion.widgets.RJTextBox();
            this.pagbox = new Facturacion.widgets.RJTextBox();
            this.gridfactura = new System.Windows.Forms.DataGridView();
            this.reflabel = new System.Windows.Forms.Label();
            this.cantidadlabl = new System.Windows.Forms.Label();
            this.descripcionlabel = new System.Windows.Forms.Label();
            this.preeciunilabl = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.refbox = new Facturacion.widgets.RJTextBox();
            this.cantidadbox = new Facturacion.widgets.RJTextBox();
            this.descrbox = new Facturacion.widgets.RJTextBox();
            this.preciunibox = new Facturacion.widgets.RJTextBox();
            this.totalbox = new Facturacion.widgets.RJTextBox();
            this.cleanbuton = new Facturacion.widgets.RJControls();
            this.botonmenuprincipal = new Facturacion.widgets.RJControls();
            this.butonImprimir = new Facturacion.widgets.RJControls();
            this.botonAgregarProducto = new Facturacion.widgets.RJControls();
            this.obralabeel = new System.Windows.Forms.Label();
            this.obrabox = new Facturacion.widgets.RJTextBox();
            this.valorbrutolabel = new System.Windows.Forms.Label();
            this.descuentolabeel = new System.Windows.Forms.Label();
            this.descuentobox = new Facturacion.widgets.RJTextBox();
            this.impustolabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brutobox = new Facturacion.widgets.RJTextBox();
            this.impuestobox = new Facturacion.widgets.RJTextBox();
            this.vavlornetbox = new Facturacion.widgets.RJTextBox();
            this.borrarbuton = new Facturacion.widgets.RJControls();
            this.gb_DetallesProductos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_DetallesFactura = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridfactura)).BeginInit();
            this.gb_DetallesProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_DetallesFactura.SuspendLayout();
            this.SuspendLayout();
            // 

            // labeldetalles
            // 
            this.labeldetalles.AutoSize = true;
            this.labeldetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldetalles.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labeldetalles.Location = new System.Drawing.Point(51, 26);
            this.labeldetalles.Name = "labeldetalles";
            this.labeldetalles.Size = new System.Drawing.Size(195, 25);
            this.labeldetalles.TabIndex = 1;
            this.labeldetalles.Text = "Detalles Generales";
            // 

            // rncbox
            // 
            this.rncbox.BackColor = System.Drawing.SystemColors.Window;
            this.rncbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rncbox.BorderFocusColor = System.Drawing.Color.Red;
            this.rncbox.BorderSize = 1;
            this.rncbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rncbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.rncbox.Location = new System.Drawing.Point(120, 40);
            this.rncbox.Margin = new System.Windows.Forms.Padding(4);
            this.rncbox.Multiline = false;
            this.rncbox.Name = "rncbox";
            this.rncbox.Padding = new System.Windows.Forms.Padding(10);
            this.rncbox.PasswordChar = false;
            this.rncbox.Size = new System.Drawing.Size(271, 37);
            this.rncbox.TabIndex = 2;
            this.rncbox.Texts = "";
            this.rncbox.UnderlineStyle = true;
            // 
            // rnclabel
            // 
            this.rnclabel.AutoSize = true;

            this.rnclabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnclabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rnclabel.Location = new System.Drawing.Point(74, 48);

            this.rnclabel.Name = "rnclabel";
            this.rnclabel.Size = new System.Drawing.Size(33, 16);
            this.rnclabel.TabIndex = 32;
            this.rnclabel.Text = "RNC";
            // 
            // clientelabel
            // 
            this.clientelabel.AutoSize = true;

            this.clientelabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientelabel.Location = new System.Drawing.Point(48, 84);

            this.clientelabel.Name = "clientelabel";
            this.clientelabel.Size = new System.Drawing.Size(59, 16);
            this.clientelabel.TabIndex = 33;
            this.clientelabel.Text = "CLIENTE";
            // 
            // clientebox
            // 
            this.clientebox.BackColor = System.Drawing.SystemColors.Window;
            this.clientebox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.clientebox.BorderFocusColor = System.Drawing.Color.Red;
            this.clientebox.BorderSize = 1;
            this.clientebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientebox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.clientebox.Location = new System.Drawing.Point(120, 79);
            this.clientebox.Margin = new System.Windows.Forms.Padding(4);
            this.clientebox.Multiline = false;
            this.clientebox.Name = "clientebox";
            this.clientebox.Padding = new System.Windows.Forms.Padding(10);
            this.clientebox.PasswordChar = false;
            this.clientebox.Size = new System.Drawing.Size(271, 37);
            this.clientebox.TabIndex = 34;
            this.clientebox.Texts = "";
            this.clientebox.UnderlineStyle = true;
            // 
            // direccionlabel
            // 
            this.direccionlabel.AutoSize = true;

            this.direccionlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionlabel.Location = new System.Drawing.Point(33, 123);

            this.direccionlabel.Name = "direccionlabel";
            this.direccionlabel.Size = new System.Drawing.Size(74, 16);
            this.direccionlabel.TabIndex = 35;
            this.direccionlabel.Text = "DIRECCION";
            // 
            // tellabel
            // 
            this.tellabel.AutoSize = true;

            this.tellabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellabel.Location = new System.Drawing.Point(38, 164);

            this.tellabel.Name = "tellabel";
            this.tellabel.Size = new System.Drawing.Size(69, 16);
            this.tellabel.TabIndex = 36;
            this.tellabel.Text = "TELEFONO";
            // 
            // vendedorlabel
            // 
            this.vendedorlabel.AutoSize = true;

            this.vendedorlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorlabel.Location = new System.Drawing.Point(32, 203);

            this.vendedorlabel.Name = "vendedorlabel";
            this.vendedorlabel.Size = new System.Drawing.Size(75, 16);
            this.vendedorlabel.TabIndex = 37;
            this.vendedorlabel.Text = "VENDEDOR";
            // 
            // dirrecionbox
            // 
            this.dirrecionbox.BackColor = System.Drawing.SystemColors.Window;
            this.dirrecionbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dirrecionbox.BorderFocusColor = System.Drawing.Color.Red;
            this.dirrecionbox.BorderSize = 1;
            this.dirrecionbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirrecionbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dirrecionbox.Location = new System.Drawing.Point(120, 118);
            this.dirrecionbox.Margin = new System.Windows.Forms.Padding(4);
            this.dirrecionbox.Multiline = false;
            this.dirrecionbox.Name = "dirrecionbox";
            this.dirrecionbox.Padding = new System.Windows.Forms.Padding(10);
            this.dirrecionbox.PasswordChar = false;
            this.dirrecionbox.Size = new System.Drawing.Size(271, 37);
            this.dirrecionbox.TabIndex = 38;
            this.dirrecionbox.Texts = "";
            this.dirrecionbox.UnderlineStyle = true;
            this.dirrecionbox.Load += new System.EventHandler(this.dirrecionbox_Load);
            // 
            // telbox
            // 
            this.telbox.BackColor = System.Drawing.SystemColors.Window;
            this.telbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.telbox.BorderFocusColor = System.Drawing.Color.Red;
            this.telbox.BorderSize = 1;
            this.telbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.telbox.Location = new System.Drawing.Point(120, 157);
            this.telbox.Margin = new System.Windows.Forms.Padding(4);
            this.telbox.Multiline = false;
            this.telbox.Name = "telbox";
            this.telbox.Padding = new System.Windows.Forms.Padding(10);
            this.telbox.PasswordChar = false;
            this.telbox.Size = new System.Drawing.Size(271, 37);
            this.telbox.TabIndex = 39;
            this.telbox.Texts = "";
            this.telbox.UnderlineStyle = true;
            // 
            // vendedorbox
            // 
            this.vendedorbox.BackColor = System.Drawing.SystemColors.Window;
            this.vendedorbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vendedorbox.BorderFocusColor = System.Drawing.Color.Red;
            this.vendedorbox.BorderSize = 1;
            this.vendedorbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.vendedorbox.Location = new System.Drawing.Point(120, 196);
            this.vendedorbox.Margin = new System.Windows.Forms.Padding(4);
            this.vendedorbox.Multiline = false;
            this.vendedorbox.Name = "vendedorbox";
            this.vendedorbox.Padding = new System.Windows.Forms.Padding(10);
            this.vendedorbox.PasswordChar = false;
            this.vendedorbox.Size = new System.Drawing.Size(271, 37);
            this.vendedorbox.TabIndex = 40;
            this.vendedorbox.Texts = "";
            this.vendedorbox.UnderlineStyle = true;
            // 
            // nfclabel
            // 
            this.nfclabel.AutoSize = true;

            this.nfclabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfclabel.Location = new System.Drawing.Point(75, 242);

            this.nfclabel.Name = "nfclabel";
            this.nfclabel.Size = new System.Drawing.Size(32, 16);
            this.nfclabel.TabIndex = 41;
            this.nfclabel.Text = "NFC";
            // 
            // nfcbox
            // 
            this.nfcbox.BackColor = System.Drawing.SystemColors.Window;
            this.nfcbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nfcbox.BorderFocusColor = System.Drawing.Color.Red;
            this.nfcbox.BorderSize = 1;
            this.nfcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfcbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nfcbox.Location = new System.Drawing.Point(120, 235);
            this.nfcbox.Margin = new System.Windows.Forms.Padding(4);
            this.nfcbox.Multiline = false;
            this.nfcbox.Name = "nfcbox";
            this.nfcbox.Padding = new System.Windows.Forms.Padding(10);
            this.nfcbox.PasswordChar = false;
            this.nfcbox.Size = new System.Drawing.Size(270, 37);
            this.nfcbox.TabIndex = 42;
            this.nfcbox.Texts = "";
            this.nfcbox.UnderlineStyle = true;
            // 

            // numerolabel
            // 
            this.numerolabel.AutoSize = true;
            this.numerolabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerolabel.Location = new System.Drawing.Point(43, 46);

            this.numerolabel.Name = "numerolabel";
            this.numerolabel.Size = new System.Drawing.Size(60, 16);
            this.numerolabel.TabIndex = 45;
            this.numerolabel.Text = "NUMERO";
            this.numerolabel.Click += new System.EventHandler(this.numerolabel_Click);
            // 
            // fechalabel
            // 
            this.fechalabel.AutoSize = true;

            this.fechalabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechalabel.Location = new System.Drawing.Point(53, 85);

            this.fechalabel.Name = "fechalabel";
            this.fechalabel.Size = new System.Drawing.Size(48, 16);
            this.fechalabel.TabIndex = 46;
            this.fechalabel.Text = "FECHA";
            // 
            // condicioneslabel
            // 
            this.condicioneslabel.AutoSize = true;

            this.condicioneslabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condicioneslabel.Location = new System.Drawing.Point(10, 123);

            this.condicioneslabel.Name = "condicioneslabel";
            this.condicioneslabel.Size = new System.Drawing.Size(91, 16);
            this.condicioneslabel.TabIndex = 47;
            this.condicioneslabel.Text = "CONDICIONES";
            // 
            // vencimientolabel
            // 
            this.vencimientolabel.AutoSize = true;

            this.vencimientolabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencimientolabel.Location = new System.Drawing.Point(11, 162);

            this.vencimientolabel.Name = "vencimientolabel";
            this.vencimientolabel.Size = new System.Drawing.Size(91, 16);
            this.vencimientolabel.TabIndex = 48;
            this.vencimientolabel.Text = "VENCIMIENTO";
            // 
            // ordenlabel
            // 
            this.ordenlabel.AutoSize = true;

            this.ordenlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ordenlabel.Location = new System.Drawing.Point(33, 202);

            this.ordenlabel.Name = "ordenlabel";
            this.ordenlabel.Size = new System.Drawing.Size(70, 16);
            this.ordenlabel.TabIndex = 49;
            this.ordenlabel.Text = "ORDEN.NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;

            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(30, 240);

            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "PAGINA.NO";
            // 
            // numerobox
            // 
            this.numerobox.BackColor = System.Drawing.SystemColors.Window;
            this.numerobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.numerobox.BorderFocusColor = System.Drawing.Color.Red;
            this.numerobox.BorderSize = 1;
            this.numerobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerobox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numerobox.Location = new System.Drawing.Point(119, 39);
            this.numerobox.Margin = new System.Windows.Forms.Padding(4);
            this.numerobox.Multiline = false;
            this.numerobox.Name = "numerobox";
            this.numerobox.Padding = new System.Windows.Forms.Padding(10);
            this.numerobox.PasswordChar = false;
            this.numerobox.Size = new System.Drawing.Size(271, 37);
            this.numerobox.TabIndex = 51;
            this.numerobox.Texts = "";
            this.numerobox.UnderlineStyle = true;
            this.numerobox.Load += new System.EventHandler(this.numerobox_Load);
            // 
            // fechabox
            // 
            this.fechabox.BackColor = System.Drawing.SystemColors.Window;
            this.fechabox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.fechabox.BorderFocusColor = System.Drawing.Color.Red;
            this.fechabox.BorderSize = 1;
            this.fechabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechabox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.fechabox.Location = new System.Drawing.Point(119, 78);
            this.fechabox.Margin = new System.Windows.Forms.Padding(4);
            this.fechabox.Multiline = false;
            this.fechabox.Name = "fechabox";
            this.fechabox.Padding = new System.Windows.Forms.Padding(10);
            this.fechabox.PasswordChar = false;
            this.fechabox.Size = new System.Drawing.Size(271, 37);
            this.fechabox.TabIndex = 52;
            this.fechabox.Texts = "";
            this.fechabox.UnderlineStyle = true;
            this.fechabox.Load += new System.EventHandler(this.fechabox_Load);
            // 
            // condibox
            // 
            this.condibox.BackColor = System.Drawing.SystemColors.Window;
            this.condibox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.condibox.BorderFocusColor = System.Drawing.Color.Red;
            this.condibox.BorderSize = 1;
            this.condibox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condibox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.condibox.Location = new System.Drawing.Point(119, 117);
            this.condibox.Margin = new System.Windows.Forms.Padding(4);
            this.condibox.Multiline = false;
            this.condibox.Name = "condibox";
            this.condibox.Padding = new System.Windows.Forms.Padding(10);
            this.condibox.PasswordChar = false;
            this.condibox.Size = new System.Drawing.Size(271, 37);
            this.condibox.TabIndex = 53;
            this.condibox.Texts = "";
            this.condibox.UnderlineStyle = true;
            this.condibox.Load += new System.EventHandler(this.condibox_Load);
            // 
            // vencibox
            // 
            this.vencibox.BackColor = System.Drawing.SystemColors.Window;
            this.vencibox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vencibox.BorderFocusColor = System.Drawing.Color.Red;
            this.vencibox.BorderSize = 1;
            this.vencibox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vencibox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.vencibox.Location = new System.Drawing.Point(119, 156);
            this.vencibox.Margin = new System.Windows.Forms.Padding(4);
            this.vencibox.Multiline = false;
            this.vencibox.Name = "vencibox";
            this.vencibox.Padding = new System.Windows.Forms.Padding(10);
            this.vencibox.PasswordChar = false;
            this.vencibox.Size = new System.Drawing.Size(271, 37);
            this.vencibox.TabIndex = 54;
            this.vencibox.Texts = "";
            this.vencibox.UnderlineStyle = true;
            this.vencibox.Load += new System.EventHandler(this.vencibox_Load);
            // 
            // ordenbox
            // 
            this.ordenbox.BackColor = System.Drawing.SystemColors.Window;
            this.ordenbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ordenbox.BorderFocusColor = System.Drawing.Color.Red;
            this.ordenbox.BorderSize = 1;
            this.ordenbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ordenbox.Location = new System.Drawing.Point(120, 195);
            this.ordenbox.Margin = new System.Windows.Forms.Padding(4);
            this.ordenbox.Multiline = false;
            this.ordenbox.Name = "ordenbox";
            this.ordenbox.Padding = new System.Windows.Forms.Padding(10);
            this.ordenbox.PasswordChar = false;
            this.ordenbox.Size = new System.Drawing.Size(270, 37);
            this.ordenbox.TabIndex = 55;
            this.ordenbox.Texts = "";
            this.ordenbox.UnderlineStyle = true;
            // 
            // pagbox
            // 
            this.pagbox.BackColor = System.Drawing.SystemColors.Window;
            this.pagbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pagbox.BorderFocusColor = System.Drawing.Color.Red;
            this.pagbox.BorderSize = 1;
            this.pagbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pagbox.Location = new System.Drawing.Point(120, 234);
            this.pagbox.Margin = new System.Windows.Forms.Padding(4);
            this.pagbox.Multiline = false;
            this.pagbox.Name = "pagbox";
            this.pagbox.Padding = new System.Windows.Forms.Padding(10);
            this.pagbox.PasswordChar = false;
            this.pagbox.Size = new System.Drawing.Size(270, 37);
            this.pagbox.TabIndex = 56;
            this.pagbox.Texts = "";
            this.pagbox.UnderlineStyle = true;
            // 
            // gridfactura
            // 
            this.gridfactura.AllowUserToAddRows = false;
            this.gridfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridfactura.Location = new System.Drawing.Point(444, 303);
            this.gridfactura.Name = "gridfactura";
            this.gridfactura.Size = new System.Drawing.Size(914, 364);
            this.gridfactura.TabIndex = 57;
            // 


            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(764, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Detalles Productos";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(735, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 2);
            this.label4.TabIndex = 59;
            // 

            // reflabel
            // 
            this.reflabel.AutoSize = true;
            this.reflabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflabel.Location = new System.Drawing.Point(75, 44);
            this.reflabel.Name = "reflabel";
            this.reflabel.Size = new System.Drawing.Size(31, 16);
            this.reflabel.TabIndex = 63;
            this.reflabel.Text = "REF";
            // 
            // cantidadlabl
            // 
            this.cantidadlabl.AutoSize = true;
            this.cantidadlabl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadlabl.Location = new System.Drawing.Point(36, 84);
            this.cantidadlabl.Name = "cantidadlabl";
            this.cantidadlabl.Size = new System.Drawing.Size(70, 16);
            this.cantidadlabl.TabIndex = 64;
            this.cantidadlabl.Text = "CANTIDAD";
            // 
            // descripcionlabel
            // 
            this.descripcionlabel.AutoSize = true;
            this.descripcionlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionlabel.Location = new System.Drawing.Point(16, 123);
            this.descripcionlabel.Name = "descripcionlabel";
            this.descripcionlabel.Size = new System.Drawing.Size(90, 16);
            this.descripcionlabel.TabIndex = 65;
            this.descripcionlabel.Text = "DESCRIPCION";
            // 
            // preeciunilabl
            // 
            this.preeciunilabl.AutoSize = true;
            this.preeciunilabl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.preeciunilabl.Location = new System.Drawing.Point(412, 44);
            this.preeciunilabl.Name = "preeciunilabl";
            this.preeciunilabl.Size = new System.Drawing.Size(86, 16);
            this.preeciunilabl.TabIndex = 66;
            this.preeciunilabl.Text = "PRECIO UNIT.";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.totallabel.Location = new System.Drawing.Point(455, 84);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(43, 16);
            this.totallabel.TabIndex = 67;
            this.totallabel.Text = "TOTAL";
            // 
            // refbox
            // 
            this.refbox.BackColor = System.Drawing.SystemColors.Window;
            this.refbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.refbox.BorderFocusColor = System.Drawing.Color.Red;
            this.refbox.BorderSize = 1;
            this.refbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.refbox.Location = new System.Drawing.Point(117, 37);
            this.refbox.Margin = new System.Windows.Forms.Padding(4);
            this.refbox.Multiline = false;
            this.refbox.Name = "refbox";
            this.refbox.Padding = new System.Windows.Forms.Padding(7);
            this.refbox.PasswordChar = false;
            this.refbox.Size = new System.Drawing.Size(272, 31);
            this.refbox.TabIndex = 68;
            this.refbox.Texts = "";
            this.refbox.UnderlineStyle = true;
            // 
            // cantidadbox
            // 
            this.cantidadbox.BackColor = System.Drawing.SystemColors.Window;
            this.cantidadbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cantidadbox.BorderFocusColor = System.Drawing.Color.Red;
            this.cantidadbox.BorderSize = 1;
            this.cantidadbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cantidadbox.Location = new System.Drawing.Point(117, 76);
            this.cantidadbox.Margin = new System.Windows.Forms.Padding(4);
            this.cantidadbox.Multiline = false;
            this.cantidadbox.Name = "cantidadbox";
            this.cantidadbox.Padding = new System.Windows.Forms.Padding(7);
            this.cantidadbox.PasswordChar = false;
            this.cantidadbox.Size = new System.Drawing.Size(272, 31);
            this.cantidadbox.TabIndex = 69;
            this.cantidadbox.Texts = "";
            this.cantidadbox.UnderlineStyle = true;
            // 
            // descrbox
            // 
            this.descrbox.BackColor = System.Drawing.SystemColors.Window;
            this.descrbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.descrbox.BorderFocusColor = System.Drawing.Color.Red;
            this.descrbox.BorderSize = 1;
            this.descrbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.descrbox.Location = new System.Drawing.Point(117, 115);
            this.descrbox.Margin = new System.Windows.Forms.Padding(4);
            this.descrbox.Multiline = false;
            this.descrbox.Name = "descrbox";
            this.descrbox.Padding = new System.Windows.Forms.Padding(7);
            this.descrbox.PasswordChar = false;
            this.descrbox.Size = new System.Drawing.Size(272, 31);
            this.descrbox.TabIndex = 70;
            this.descrbox.Texts = "";
            this.descrbox.UnderlineStyle = true;
            // 
            // preciunibox
            // 
            this.preciunibox.BackColor = System.Drawing.SystemColors.Window;
            this.preciunibox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.preciunibox.BorderFocusColor = System.Drawing.Color.Red;
            this.preciunibox.BorderSize = 1;
            this.preciunibox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciunibox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.preciunibox.Location = new System.Drawing.Point(508, 37);
            this.preciunibox.Margin = new System.Windows.Forms.Padding(4);
            this.preciunibox.Multiline = false;
            this.preciunibox.Name = "preciunibox";
            this.preciunibox.Padding = new System.Windows.Forms.Padding(7);
            this.preciunibox.PasswordChar = false;
            this.preciunibox.Size = new System.Drawing.Size(268, 31);
            this.preciunibox.TabIndex = 71;
            this.preciunibox.Texts = "";
            this.preciunibox.UnderlineStyle = true;
            // 
            // totalbox
            // 
            this.totalbox.BackColor = System.Drawing.SystemColors.Window;
            this.totalbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.totalbox.BorderFocusColor = System.Drawing.Color.Red;
            this.totalbox.BorderSize = 1;
            this.totalbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.totalbox.Location = new System.Drawing.Point(508, 76);
            this.totalbox.Margin = new System.Windows.Forms.Padding(4);
            this.totalbox.Multiline = false;
            this.totalbox.Name = "totalbox";
            this.totalbox.Padding = new System.Windows.Forms.Padding(7);
            this.totalbox.PasswordChar = false;
            this.totalbox.Size = new System.Drawing.Size(268, 31);
            this.totalbox.TabIndex = 72;
            this.totalbox.Texts = "";
            this.totalbox.UnderlineStyle = true;
            // 
            // cleanbuton
            // 
            this.cleanbuton.BackColor = System.Drawing.Color.SeaGreen;
            this.cleanbuton.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.cleanbuton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cleanbuton.BorderRadius = 10;
            this.cleanbuton.BorderSize = 0;
            this.cleanbuton.FlatAppearance.BorderSize = 0;
            this.cleanbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanbuton.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanbuton.ForeColor = System.Drawing.Color.White;
            this.cleanbuton.Location = new System.Drawing.Point(1258, 239);
            this.cleanbuton.Margin = new System.Windows.Forms.Padding(5);
            this.cleanbuton.Name = "cleanbuton";
            this.cleanbuton.Size = new System.Drawing.Size(100, 45);
            this.cleanbuton.TabIndex = 76;
            this.cleanbuton.Text = "LIMPIAR CASILLAS";
            this.cleanbuton.TextColor = System.Drawing.Color.White;
            this.cleanbuton.UseVisualStyleBackColor = false;
            this.cleanbuton.Click += new System.EventHandler(this.cleanbuton_Click);
            // 
            // botonmenuprincipal
            // 
            this.botonmenuprincipal.BackColor = System.Drawing.Color.Crimson;
            this.botonmenuprincipal.BackgroundColor = System.Drawing.Color.Crimson;
            this.botonmenuprincipal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonmenuprincipal.BorderRadius = 10;
            this.botonmenuprincipal.BorderSize = 0;
            this.botonmenuprincipal.FlatAppearance.BorderSize = 0;
            this.botonmenuprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonmenuprincipal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmenuprincipal.ForeColor = System.Drawing.Color.White;
            this.botonmenuprincipal.Location = new System.Drawing.Point(1258, 15);
            this.botonmenuprincipal.Margin = new System.Windows.Forms.Padding(5);
            this.botonmenuprincipal.Name = "botonmenuprincipal";
            this.botonmenuprincipal.Size = new System.Drawing.Size(100, 45);
            this.botonmenuprincipal.TabIndex = 75;
            this.botonmenuprincipal.Text = "MENU";
            this.botonmenuprincipal.TextColor = System.Drawing.Color.White;
            this.botonmenuprincipal.UseVisualStyleBackColor = false;
            this.botonmenuprincipal.Click += new System.EventHandler(this.botonmenuprincipal_Click);
            // 
            // butonImprimir
            // 
            this.butonImprimir.BackColor = System.Drawing.Color.RoyalBlue;
            this.butonImprimir.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.butonImprimir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butonImprimir.BorderRadius = 10;
            this.butonImprimir.BorderSize = 0;
            this.butonImprimir.FlatAppearance.BorderSize = 0;
            this.butonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonImprimir.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonImprimir.ForeColor = System.Drawing.Color.White;
            this.butonImprimir.Location = new System.Drawing.Point(1258, 127);
            this.butonImprimir.Margin = new System.Windows.Forms.Padding(5);
            this.butonImprimir.Name = "butonImprimir";
            this.butonImprimir.Size = new System.Drawing.Size(100, 45);
            this.butonImprimir.TabIndex = 74;
            this.butonImprimir.Text = "Terminar e Imprimir";
            this.butonImprimir.TextColor = System.Drawing.Color.White;
            this.butonImprimir.UseVisualStyleBackColor = false;
            this.butonImprimir.Click += new System.EventHandler(this.butonImprimir_Click);
            // 
            // botonAgregarProducto
            // 
            this.botonAgregarProducto.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonAgregarProducto.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonAgregarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonAgregarProducto.BorderRadius = 10;
            this.botonAgregarProducto.BorderSize = 0;
            this.botonAgregarProducto.FlatAppearance.BorderSize = 0;
            this.botonAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregarProducto.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.botonAgregarProducto.Location = new System.Drawing.Point(1258, 71);
            this.botonAgregarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.botonAgregarProducto.Name = "botonAgregarProducto";
            this.botonAgregarProducto.Size = new System.Drawing.Size(100, 45);
            this.botonAgregarProducto.TabIndex = 73;
            this.botonAgregarProducto.Text = "Agregar Producto";
            this.botonAgregarProducto.TextColor = System.Drawing.Color.White;
            this.botonAgregarProducto.UseVisualStyleBackColor = false;
            this.botonAgregarProducto.Click += new System.EventHandler(this.botonAgregarProducto_Click);
            // 
            // obralabeel
            // 
            this.obralabeel.AutoSize = true;

            this.obralabeel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obralabeel.Location = new System.Drawing.Point(67, 281);

            this.obralabeel.Name = "obralabeel";
            this.obralabeel.Size = new System.Drawing.Size(40, 16);
            this.obralabeel.TabIndex = 77;
            this.obralabeel.Text = "OBRA";
            // 
            // obrabox
            // 
            this.obrabox.BackColor = System.Drawing.SystemColors.Window;
            this.obrabox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.obrabox.BorderFocusColor = System.Drawing.Color.Red;
            this.obrabox.BorderSize = 1;
            this.obrabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrabox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.obrabox.Location = new System.Drawing.Point(120, 274);
            this.obrabox.Margin = new System.Windows.Forms.Padding(4);
            this.obrabox.Multiline = false;
            this.obrabox.Name = "obrabox";
            this.obrabox.Padding = new System.Windows.Forms.Padding(10);
            this.obrabox.PasswordChar = false;
            this.obrabox.Size = new System.Drawing.Size(271, 37);
            this.obrabox.TabIndex = 78;
            this.obrabox.Texts = "";
            this.obrabox.UnderlineStyle = true;
            // 
            // valorbrutolabel
            // 
            this.valorbrutolabel.AutoSize = true;
            this.valorbrutolabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.valorbrutolabel.Location = new System.Drawing.Point(410, 123);
            this.valorbrutolabel.Name = "valorbrutolabel";
            this.valorbrutolabel.Size = new System.Drawing.Size(88, 16);
            this.valorbrutolabel.TabIndex = 79;
            this.valorbrutolabel.Text = "VALOR BRUTO";
            // 
            // descuentolabeel
            // 
            this.descuentolabeel.AutoSize = true;
            this.descuentolabeel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentolabeel.Location = new System.Drawing.Point(24, 163);
            this.descuentolabeel.Name = "descuentolabeel";
            this.descuentolabeel.Size = new System.Drawing.Size(82, 16);
            this.descuentolabeel.TabIndex = 81;
            this.descuentolabeel.Text = "DESCUENTO";
            // 
            // descuentobox
            // 
            this.descuentobox.BackColor = System.Drawing.SystemColors.Window;
            this.descuentobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.descuentobox.BorderFocusColor = System.Drawing.Color.Red;
            this.descuentobox.BorderSize = 1;
            this.descuentobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentobox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.descuentobox.Location = new System.Drawing.Point(117, 154);
            this.descuentobox.Margin = new System.Windows.Forms.Padding(4);
            this.descuentobox.Multiline = false;
            this.descuentobox.Name = "descuentobox";
            this.descuentobox.Padding = new System.Windows.Forms.Padding(7);
            this.descuentobox.PasswordChar = false;
            this.descuentobox.Size = new System.Drawing.Size(272, 31);
            this.descuentobox.TabIndex = 82;
            this.descuentobox.Texts = "";
            this.descuentobox.UnderlineStyle = true;
            // 
            // impustolabel
            // 
            this.impustolabel.AutoSize = true;
            this.impustolabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.impustolabel.Location = new System.Drawing.Point(429, 163);
            this.impustolabel.Name = "impustolabel";
            this.impustolabel.Size = new System.Drawing.Size(69, 16);
            this.impustolabel.TabIndex = 83;
            this.impustolabel.Text = "IMPUESTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "VALOR NETO";
            // 
            // brutobox
            // 
            this.brutobox.BackColor = System.Drawing.SystemColors.Window;
            this.brutobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.brutobox.BorderFocusColor = System.Drawing.Color.Red;
            this.brutobox.BorderSize = 1;
            this.brutobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brutobox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.brutobox.Location = new System.Drawing.Point(508, 115);
            this.brutobox.Margin = new System.Windows.Forms.Padding(4);
            this.brutobox.Multiline = false;
            this.brutobox.Name = "brutobox";
            this.brutobox.Padding = new System.Windows.Forms.Padding(7);
            this.brutobox.PasswordChar = false;
            this.brutobox.Size = new System.Drawing.Size(268, 31);
            this.brutobox.TabIndex = 86;
            this.brutobox.Texts = "";
            this.brutobox.UnderlineStyle = true;
            // 
            // impuestobox
            // 
            this.impuestobox.BackColor = System.Drawing.SystemColors.Window;
            this.impuestobox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.impuestobox.BorderFocusColor = System.Drawing.Color.Red;
            this.impuestobox.BorderSize = 1;
            this.impuestobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impuestobox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.impuestobox.Location = new System.Drawing.Point(508, 154);
            this.impuestobox.Margin = new System.Windows.Forms.Padding(4);
            this.impuestobox.Multiline = false;
            this.impuestobox.Name = "impuestobox";
            this.impuestobox.Padding = new System.Windows.Forms.Padding(7);
            this.impuestobox.PasswordChar = false;
            this.impuestobox.Size = new System.Drawing.Size(268, 31);
            this.impuestobox.TabIndex = 87;
            this.impuestobox.Texts = "";
            this.impuestobox.UnderlineStyle = true;
            // 
            // vavlornetbox
            // 
            this.vavlornetbox.BackColor = System.Drawing.SystemColors.Window;
            this.vavlornetbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.vavlornetbox.BorderFocusColor = System.Drawing.Color.Red;
            this.vavlornetbox.BorderSize = 1;
            this.vavlornetbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vavlornetbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.vavlornetbox.Location = new System.Drawing.Point(117, 193);
            this.vavlornetbox.Margin = new System.Windows.Forms.Padding(4);
            this.vavlornetbox.Multiline = false;
            this.vavlornetbox.Name = "vavlornetbox";
            this.vavlornetbox.Padding = new System.Windows.Forms.Padding(7);
            this.vavlornetbox.PasswordChar = false;
            this.vavlornetbox.Size = new System.Drawing.Size(272, 31);
            this.vavlornetbox.TabIndex = 88;
            this.vavlornetbox.Texts = "";
            this.vavlornetbox.UnderlineStyle = true;
            // 
            // borrarbuton
            // 
            this.borrarbuton.BackColor = System.Drawing.Color.BlueViolet;
            this.borrarbuton.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.borrarbuton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borrarbuton.BorderRadius = 10;
            this.borrarbuton.BorderSize = 0;
            this.borrarbuton.FlatAppearance.BorderSize = 0;
            this.borrarbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarbuton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarbuton.ForeColor = System.Drawing.Color.White;
            this.borrarbuton.Location = new System.Drawing.Point(1258, 183);
            this.borrarbuton.Margin = new System.Windows.Forms.Padding(5);
            this.borrarbuton.Name = "borrarbuton";
            this.borrarbuton.Size = new System.Drawing.Size(100, 45);
            this.borrarbuton.TabIndex = 89;
            this.borrarbuton.Text = "BORRAR";
            this.borrarbuton.TextColor = System.Drawing.Color.White;
            this.borrarbuton.UseVisualStyleBackColor = false;
            this.borrarbuton.Click += new System.EventHandler(this.borrarbuton_Click);
            // 
            // gb_DetallesProductos
            // 
            this.gb_DetallesProductos.Controls.Add(this.cantidadbox);
            this.gb_DetallesProductos.Controls.Add(this.reflabel);
            this.gb_DetallesProductos.Controls.Add(this.vavlornetbox);
            this.gb_DetallesProductos.Controls.Add(this.cantidadlabl);
            this.gb_DetallesProductos.Controls.Add(this.impuestobox);
            this.gb_DetallesProductos.Controls.Add(this.descripcionlabel);
            this.gb_DetallesProductos.Controls.Add(this.brutobox);
            this.gb_DetallesProductos.Controls.Add(this.preeciunilabl);
            this.gb_DetallesProductos.Controls.Add(this.label5);
            this.gb_DetallesProductos.Controls.Add(this.totallabel);
            this.gb_DetallesProductos.Controls.Add(this.impustolabel);
            this.gb_DetallesProductos.Controls.Add(this.refbox);
            this.gb_DetallesProductos.Controls.Add(this.descuentobox);
            this.gb_DetallesProductos.Controls.Add(this.descrbox);
            this.gb_DetallesProductos.Controls.Add(this.descuentolabeel);
            this.gb_DetallesProductos.Controls.Add(this.preciunibox);
            this.gb_DetallesProductos.Controls.Add(this.valorbrutolabel);
            this.gb_DetallesProductos.Controls.Add(this.totalbox);
            this.gb_DetallesProductos.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DetallesProductos.Location = new System.Drawing.Point(444, 22);
            this.gb_DetallesProductos.Name = "gb_DetallesProductos";
            this.gb_DetallesProductos.Size = new System.Drawing.Size(795, 237);
            this.gb_DetallesProductos.TabIndex = 90;
            this.gb_DetallesProductos.TabStop = false;
            this.gb_DetallesProductos.Text = "Detalles Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientebox);
            this.groupBox1.Controls.Add(this.rncbox);
            this.groupBox1.Controls.Add(this.rnclabel);
            this.groupBox1.Controls.Add(this.obrabox);
            this.groupBox1.Controls.Add(this.clientelabel);
            this.groupBox1.Controls.Add(this.obralabeel);
            this.groupBox1.Controls.Add(this.direccionlabel);
            this.groupBox1.Controls.Add(this.tellabel);
            this.groupBox1.Controls.Add(this.vendedorlabel);
            this.groupBox1.Controls.Add(this.dirrecionbox);
            this.groupBox1.Controls.Add(this.telbox);
            this.groupBox1.Controls.Add(this.vendedorbox);
            this.groupBox1.Controls.Add(this.nfclabel);
            this.groupBox1.Controls.Add(this.nfcbox);
            this.groupBox1.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 321);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Generales";
            // 
            // gb_DetallesFactura
            // 
            this.gb_DetallesFactura.Controls.Add(this.numerobox);
            this.gb_DetallesFactura.Controls.Add(this.numerolabel);
            this.gb_DetallesFactura.Controls.Add(this.fechalabel);
            this.gb_DetallesFactura.Controls.Add(this.condicioneslabel);
            this.gb_DetallesFactura.Controls.Add(this.vencimientolabel);
            this.gb_DetallesFactura.Controls.Add(this.ordenlabel);
            this.gb_DetallesFactura.Controls.Add(this.label8);
            this.gb_DetallesFactura.Controls.Add(this.fechabox);
            this.gb_DetallesFactura.Controls.Add(this.condibox);
            this.gb_DetallesFactura.Controls.Add(this.vencibox);
            this.gb_DetallesFactura.Controls.Add(this.ordenbox);
            this.gb_DetallesFactura.Controls.Add(this.pagbox);
            this.gb_DetallesFactura.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DetallesFactura.Location = new System.Drawing.Point(12, 359);
            this.gb_DetallesFactura.Name = "gb_DetallesFactura";
            this.gb_DetallesFactura.Size = new System.Drawing.Size(413, 308);
            this.gb_DetallesFactura.TabIndex = 92;
            this.gb_DetallesFactura.TabStop = false;
            this.gb_DetallesFactura.Text = "Detalles Factura";
            // 
            // Form_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 690);
            this.Controls.Add(this.gb_DetallesFactura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_DetallesProductos);
            this.Controls.Add(this.borrarbuton);
            this.Controls.Add(this.cleanbuton);
            this.Controls.Add(this.botonmenuprincipal);
            this.Controls.Add(this.butonImprimir);
            this.Controls.Add(this.botonAgregarProducto);
            this.Controls.Add(this.gridfactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes_Factura";
            this.Load += new System.EventHandler(this.Form_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridfactura)).EndInit();
            this.gb_DetallesProductos.ResumeLayout(false);
            this.gb_DetallesProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_DetallesFactura.ResumeLayout(false);
            this.gb_DetallesFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private widgets.RJTextBox rncbox;
        private System.Windows.Forms.Label rnclabel;
        private System.Windows.Forms.Label clientelabel;
        private widgets.RJTextBox clientebox;
        private System.Windows.Forms.Label direccionlabel;
        private System.Windows.Forms.Label tellabel;
        private System.Windows.Forms.Label vendedorlabel;
        private widgets.RJTextBox dirrecionbox;
        private widgets.RJTextBox telbox;
        private widgets.RJTextBox vendedorbox;
        private System.Windows.Forms.Label nfclabel;
        private widgets.RJTextBox nfcbox;
        private System.Windows.Forms.Label numerolabel;
        private System.Windows.Forms.Label fechalabel;
        private System.Windows.Forms.Label condicioneslabel;
        private System.Windows.Forms.Label vencimientolabel;
        private System.Windows.Forms.Label ordenlabel;
        private System.Windows.Forms.Label label8;
        private widgets.RJTextBox numerobox;
        private widgets.RJTextBox fechabox;
        private widgets.RJTextBox condibox;
        private widgets.RJTextBox vencibox;
        private widgets.RJTextBox ordenbox;
        private widgets.RJTextBox pagbox;
        private System.Windows.Forms.DataGridView gridfactura;
        private System.Windows.Forms.Label reflabel;
        private System.Windows.Forms.Label cantidadlabl;
        private System.Windows.Forms.Label descripcionlabel;
        private System.Windows.Forms.Label preeciunilabl;
        private System.Windows.Forms.Label totallabel;
        private widgets.RJTextBox refbox;
        private widgets.RJTextBox cantidadbox;
        private widgets.RJTextBox descrbox;
        private widgets.RJTextBox preciunibox;
        private widgets.RJTextBox totalbox;
        private widgets.RJControls cleanbuton;
        private widgets.RJControls botonmenuprincipal;
        private widgets.RJControls butonImprimir;
        private widgets.RJControls botonAgregarProducto;
        private System.Windows.Forms.Label obralabeel;
        private widgets.RJTextBox obrabox;
        private System.Windows.Forms.Label valorbrutolabel;
        private System.Windows.Forms.Label descuentolabeel;
        private widgets.RJTextBox descuentobox;
        private System.Windows.Forms.Label impustolabel;
        private System.Windows.Forms.Label label5;
        private widgets.RJTextBox brutobox;
        private widgets.RJTextBox impuestobox;
        private widgets.RJTextBox vavlornetbox;
        private widgets.RJControls borrarbuton;
        private System.Windows.Forms.GroupBox gb_DetallesProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_DetallesFactura;
    }
}

