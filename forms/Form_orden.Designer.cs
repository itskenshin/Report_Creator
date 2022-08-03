namespace Facturacion.forms
{
    partial class Form_orden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_orden));
            this.Nombre_label = new System.Windows.Forms.Label();
            this.RNC_label = new System.Windows.Forms.Label();
            this.label_NumeroCoti = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelPagina = new System.Windows.Forms.Label();
            this.label_CodigoCliente = new System.Windows.Forms.Label();
            this.label_RFC = new System.Windows.Forms.Label();
            this.label_referencia = new System.Windows.Forms.Label();
            this.label_terminos = new System.Windows.Forms.Label();
            this.label_vendedor = new System.Windows.Forms.Label();
            this.label_moneda = new System.Windows.Forms.Label();
            this.label_emite = new System.Windows.Forms.Label();
            this.gridprodc = new System.Windows.Forms.DataGridView();
            this.ltmlabel = new System.Windows.Forms.Label();
            this.labelCodprod = new System.Windows.Forms.Label();
            this.labeldescripcionproducto = new System.Windows.Forms.Label();
            this.labelbodg = new System.Windows.Forms.Label();
            this.labelcantidad = new System.Windows.Forms.Label();
            this.labelunid = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelImp = new System.Windows.Forms.Label();
            this.porcientodsct = new System.Windows.Forms.Label();
            this.gb_DatosClientes = new System.Windows.Forms.GroupBox();
            this.textBox_RNC = new Facturacion.widgets.RJTextBox();
            this.textBox_nombre = new Facturacion.widgets.RJTextBox();
            this.textBoxCodigoCliente = new Facturacion.widgets.RJTextBox();
            this.textboxRFC = new Facturacion.widgets.RJTextBox();
            this.textBoxReferencia = new Facturacion.widgets.RJTextBox();
            this.textBoxTerminos = new Facturacion.widgets.RJTextBox();
            this.textBoxVendedor = new Facturacion.widgets.RJTextBox();
            this.textBoxMoneda = new Facturacion.widgets.RJTextBox();
            this.textBoxEmite = new Facturacion.widgets.RJTextBox();
            this.textboxFecha = new Facturacion.widgets.RJTextBox();
            this.textBox_numeroCoti = new Facturacion.widgets.RJTextBox();
            this.textboxPagina = new Facturacion.widgets.RJTextBox();
            this.gb_DetallesProducto = new System.Windows.Forms.GroupBox();
            this.impboxx = new Facturacion.widgets.RJTextBox();
            this.labelunit = new System.Windows.Forms.Label();
            this.ltmbox = new Facturacion.widgets.RJTextBox();
            this.boxunid = new Facturacion.widgets.RJTextBox();
            this.codprodcbox = new Facturacion.widgets.RJTextBox();
            this.descriProductBox = new Facturacion.widgets.RJTextBox();
            this.dsctglobalbox = new Facturacion.widgets.RJTextBox();
            this.bodgbox = new Facturacion.widgets.RJTextBox();
            this.boxcantidad = new Facturacion.widgets.RJTextBox();
            this.boxprecio = new Facturacion.widgets.RJTextBox();
            this.borrarbuton = new Facturacion.widgets.RJControls();
            this.cleanbuton = new Facturacion.widgets.RJControls();
            this.botonmenuprincipal = new Facturacion.widgets.RJControls();
            this.butonImprimir = new Facturacion.widgets.RJControls();
            this.botonAgregarProducto = new Facturacion.widgets.RJControls();
            ((System.ComponentModel.ISupportInitialize)(this.gridprodc)).BeginInit();
            this.gb_DatosClientes.SuspendLayout();
            this.gb_DetallesProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Nombre_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nombre_label.Location = new System.Drawing.Point(79, 47);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(61, 16);
            this.Nombre_label.TabIndex = 1;
            this.Nombre_label.Text = "NOMBRE:";
            // 
            // RNC_label
            // 
            this.RNC_label.AutoSize = true;
            this.RNC_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.RNC_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RNC_label.Location = new System.Drawing.Point(103, 88);
            this.RNC_label.Name = "RNC_label";
            this.RNC_label.Size = new System.Drawing.Size(35, 16);
            this.RNC_label.TabIndex = 2;
            this.RNC_label.Text = "RNC:";
            // 
            // label_NumeroCoti
            // 
            this.label_NumeroCoti.AutoSize = true;
            this.label_NumeroCoti.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_NumeroCoti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NumeroCoti.Location = new System.Drawing.Point(795, 86);
            this.label_NumeroCoti.Name = "label_NumeroCoti";
            this.label_NumeroCoti.Size = new System.Drawing.Size(98, 16);
            this.label_NumeroCoti.TabIndex = 5;
            this.label_NumeroCoti.Text = "COTIZACIÓN No:";
            this.label_NumeroCoti.Click += new System.EventHandler(this.label_NumeroCoti_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFecha.Location = new System.Drawing.Point(841, 127);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(50, 16);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "FECHA:";
            // 
            // labelPagina
            // 
            this.labelPagina.AutoSize = true;
            this.labelPagina.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPagina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPagina.Location = new System.Drawing.Point(841, 165);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(51, 16);
            this.labelPagina.TabIndex = 7;
            this.labelPagina.Text = "PÁGINA";
            // 
            // label_CodigoCliente
            // 
            this.label_CodigoCliente.AutoSize = true;
            this.label_CodigoCliente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_CodigoCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_CodigoCliente.Location = new System.Drawing.Point(29, 127);
            this.label_CodigoCliente.Name = "label_CodigoCliente";
            this.label_CodigoCliente.Size = new System.Drawing.Size(109, 16);
            this.label_CodigoCliente.TabIndex = 11;
            this.label_CodigoCliente.Text = "CÓDIGO CLIENTE:";
            // 
            // label_RFC
            // 
            this.label_RFC.AutoSize = true;
            this.label_RFC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_RFC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_RFC.Location = new System.Drawing.Point(106, 165);
            this.label_RFC.Name = "label_RFC";
            this.label_RFC.Size = new System.Drawing.Size(33, 16);
            this.label_RFC.TabIndex = 12;
            this.label_RFC.Text = "RFC:";
            // 
            // label_referencia
            // 
            this.label_referencia.AutoSize = true;
            this.label_referencia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_referencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_referencia.Location = new System.Drawing.Point(423, 48);
            this.label_referencia.Name = "label_referencia";
            this.label_referencia.Size = new System.Drawing.Size(86, 16);
            this.label_referencia.TabIndex = 13;
            this.label_referencia.Text = "REFERENCIA:";
            // 
            // label_terminos
            // 
            this.label_terminos.AutoSize = true;
            this.label_terminos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_terminos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_terminos.Location = new System.Drawing.Point(437, 87);
            this.label_terminos.Name = "label_terminos";
            this.label_terminos.Size = new System.Drawing.Size(71, 16);
            this.label_terminos.TabIndex = 14;
            this.label_terminos.Text = "TÉRMINOS:";
            // 
            // label_vendedor
            // 
            this.label_vendedor.AutoSize = true;
            this.label_vendedor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_vendedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_vendedor.Location = new System.Drawing.Point(432, 125);
            this.label_vendedor.Name = "label_vendedor";
            this.label_vendedor.Size = new System.Drawing.Size(77, 16);
            this.label_vendedor.TabIndex = 15;
            this.label_vendedor.Text = "VENDEDOR:";
            // 
            // label_moneda
            // 
            this.label_moneda.AutoSize = true;
            this.label_moneda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_moneda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_moneda.Location = new System.Drawing.Point(446, 165);
            this.label_moneda.Name = "label_moneda";
            this.label_moneda.Size = new System.Drawing.Size(62, 16);
            this.label_moneda.TabIndex = 16;
            this.label_moneda.Text = "MONEDA:";
            // 
            // label_emite
            // 
            this.label_emite.AutoSize = true;
            this.label_emite.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_emite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_emite.Location = new System.Drawing.Point(844, 48);
            this.label_emite.Name = "label_emite";
            this.label_emite.Size = new System.Drawing.Size(47, 16);
            this.label_emite.TabIndex = 17;
            this.label_emite.Text = "EMITE:";
            // 
            // gridprodc
            // 
            this.gridprodc.AllowUserToAddRows = false;
            this.gridprodc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridprodc.Location = new System.Drawing.Point(12, 412);
            this.gridprodc.Name = "gridprodc";
            this.gridprodc.Size = new System.Drawing.Size(1346, 275);
            this.gridprodc.TabIndex = 25;
            // 
            // ltmlabel
            // 
            this.ltmlabel.AutoSize = true;
            this.ltmlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ltmlabel.ForeColor = System.Drawing.Color.Red;
            this.ltmlabel.Location = new System.Drawing.Point(111, 39);
            this.ltmlabel.Name = "ltmlabel";
            this.ltmlabel.Size = new System.Drawing.Size(30, 16);
            this.ltmlabel.TabIndex = 32;
            this.ltmlabel.Text = "LTM";
            // 
            // labelCodprod
            // 
            this.labelCodprod.AutoSize = true;
            this.labelCodprod.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCodprod.ForeColor = System.Drawing.Color.Red;
            this.labelCodprod.Location = new System.Drawing.Point(35, 78);
            this.labelCodprod.Name = "labelCodprod";
            this.labelCodprod.Size = new System.Drawing.Size(102, 16);
            this.labelCodprod.TabIndex = 33;
            this.labelCodprod.Text = "COD. PRODUCTO";
            // 
            // labeldescripcionproducto
            // 
            this.labeldescripcionproducto.AutoSize = true;
            this.labeldescripcionproducto.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labeldescripcionproducto.ForeColor = System.Drawing.Color.Red;
            this.labeldescripcionproducto.Location = new System.Drawing.Point(13, 117);
            this.labeldescripcionproducto.Name = "labeldescripcionproducto";
            this.labeldescripcionproducto.Size = new System.Drawing.Size(128, 16);
            this.labeldescripcionproducto.TabIndex = 34;
            this.labeldescripcionproducto.Text = "DESCRIPCION PROD.";
            // 
            // labelbodg
            // 
            this.labelbodg.AutoSize = true;
            this.labelbodg.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelbodg.ForeColor = System.Drawing.Color.Red;
            this.labelbodg.Location = new System.Drawing.Point(468, 38);
            this.labelbodg.Name = "labelbodg";
            this.labelbodg.Size = new System.Drawing.Size(43, 16);
            this.labelbodg.TabIndex = 35;
            this.labelbodg.Text = "BODG.";
            // 
            // labelcantidad
            // 
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelcantidad.ForeColor = System.Drawing.Color.Red;
            this.labelcantidad.Location = new System.Drawing.Point(435, 81);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(69, 16);
            this.labelcantidad.TabIndex = 40;
            this.labelcantidad.Text = "CANTIDAD";
            // 
            // labelunid
            // 
            this.labelunid.AutoSize = true;
            this.labelunid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelunid.ForeColor = System.Drawing.Color.Red;
            this.labelunid.Location = new System.Drawing.Point(743, -14);
            this.labelunid.Name = "labelunid";
            this.labelunid.Size = new System.Drawing.Size(33, 16);
            this.labelunid.TabIndex = 41;
            this.labelunid.Text = "Unid";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPrecio.ForeColor = System.Drawing.Color.Red;
            this.labelPrecio.Location = new System.Drawing.Point(453, 119);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(51, 16);
            this.labelPrecio.TabIndex = 42;
            this.labelPrecio.Text = "PRECIO";
            // 
            // labelImp
            // 
            this.labelImp.AutoSize = true;
            this.labelImp.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelImp.ForeColor = System.Drawing.Color.Red;
            this.labelImp.Location = new System.Drawing.Point(844, 41);
            this.labelImp.Name = "labelImp";
            this.labelImp.Size = new System.Drawing.Size(41, 16);
            this.labelImp.TabIndex = 43;
            this.labelImp.Text = "Imp.%";
            // 
            // porcientodsct
            // 
            this.porcientodsct.AutoSize = true;
            this.porcientodsct.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.porcientodsct.ForeColor = System.Drawing.Color.DarkViolet;
            this.porcientodsct.Location = new System.Drawing.Point(793, 117);
            this.porcientodsct.Name = "porcientodsct";
            this.porcientodsct.Size = new System.Drawing.Size(104, 16);
            this.porcientodsct.TabIndex = 57;
            this.porcientodsct.Text = "%.Dscto. GLOBAL";
            // 
            // gb_DatosClientes
            // 
            this.gb_DatosClientes.Controls.Add(this.textBox_RNC);
            this.gb_DatosClientes.Controls.Add(this.textBox_nombre);
            this.gb_DatosClientes.Controls.Add(this.textBoxCodigoCliente);
            this.gb_DatosClientes.Controls.Add(this.textboxRFC);
            this.gb_DatosClientes.Controls.Add(this.textBoxReferencia);
            this.gb_DatosClientes.Controls.Add(this.textBoxTerminos);
            this.gb_DatosClientes.Controls.Add(this.textBoxVendedor);
            this.gb_DatosClientes.Controls.Add(this.textBoxMoneda);
            this.gb_DatosClientes.Controls.Add(this.textBoxEmite);
            this.gb_DatosClientes.Controls.Add(this.label_emite);
            this.gb_DatosClientes.Controls.Add(this.Nombre_label);
            this.gb_DatosClientes.Controls.Add(this.RNC_label);
            this.gb_DatosClientes.Controls.Add(this.label_CodigoCliente);
            this.gb_DatosClientes.Controls.Add(this.label_RFC);
            this.gb_DatosClientes.Controls.Add(this.label_referencia);
            this.gb_DatosClientes.Controls.Add(this.label_terminos);
            this.gb_DatosClientes.Controls.Add(this.label_vendedor);
            this.gb_DatosClientes.Controls.Add(this.label_moneda);
            this.gb_DatosClientes.Controls.Add(this.textboxFecha);
            this.gb_DatosClientes.Controls.Add(this.label_NumeroCoti);
            this.gb_DatosClientes.Controls.Add(this.labelFecha);
            this.gb_DatosClientes.Controls.Add(this.labelPagina);
            this.gb_DatosClientes.Controls.Add(this.textBox_numeroCoti);
            this.gb_DatosClientes.Controls.Add(this.textboxPagina);
            this.gb_DatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosClientes.Location = new System.Drawing.Point(12, 12);
            this.gb_DatosClientes.Name = "gb_DatosClientes";
            this.gb_DatosClientes.Size = new System.Drawing.Size(1189, 214);
            this.gb_DatosClientes.TabIndex = 64;
            this.gb_DatosClientes.TabStop = false;
            this.gb_DatosClientes.Text = "Datos Clientes";
            // 
            // textBox_RNC
            // 
            this.textBox_RNC.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_RNC.BorderColor = System.Drawing.Color.Blue;
            this.textBox_RNC.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox_RNC.BorderSize = 1;
            this.textBox_RNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RNC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_RNC.Location = new System.Drawing.Point(146, 80);
            this.textBox_RNC.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RNC.Multiline = false;
            this.textBox_RNC.Name = "textBox_RNC";
            this.textBox_RNC.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_RNC.PasswordChar = false;
            this.textBox_RNC.Size = new System.Drawing.Size(273, 31);
            this.textBox_RNC.TabIndex = 4;
            this.textBox_RNC.Texts = "";
            this.textBox_RNC.UnderlineStyle = true;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_nombre.BorderColor = System.Drawing.Color.Blue;
            this.textBox_nombre.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox_nombre.BorderSize = 1;
            this.textBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_nombre.Location = new System.Drawing.Point(146, 39);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nombre.Multiline = false;
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_nombre.PasswordChar = false;
            this.textBox_nombre.Size = new System.Drawing.Size(273, 31);
            this.textBox_nombre.TabIndex = 3;
            this.textBox_nombre.Texts = "";
            this.textBox_nombre.UnderlineStyle = true;
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCodigoCliente.BorderColor = System.Drawing.Color.Blue;
            this.textBoxCodigoCliente.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxCodigoCliente.BorderSize = 1;
            this.textBoxCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(146, 119);
            this.textBoxCodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigoCliente.Multiline = false;
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCodigoCliente.PasswordChar = false;
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(273, 31);
            this.textBoxCodigoCliente.TabIndex = 18;
            this.textBoxCodigoCliente.Texts = "";
            this.textBoxCodigoCliente.UnderlineStyle = true;
            // 
            // textboxRFC
            // 
            this.textboxRFC.BackColor = System.Drawing.SystemColors.Window;
            this.textboxRFC.BorderColor = System.Drawing.Color.Blue;
            this.textboxRFC.BorderFocusColor = System.Drawing.Color.Red;
            this.textboxRFC.BorderSize = 1;
            this.textboxRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxRFC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textboxRFC.Location = new System.Drawing.Point(146, 158);
            this.textboxRFC.Margin = new System.Windows.Forms.Padding(4);
            this.textboxRFC.Multiline = false;
            this.textboxRFC.Name = "textboxRFC";
            this.textboxRFC.Padding = new System.Windows.Forms.Padding(7);
            this.textboxRFC.PasswordChar = false;
            this.textboxRFC.Size = new System.Drawing.Size(273, 31);
            this.textboxRFC.TabIndex = 19;
            this.textboxRFC.Texts = "";
            this.textboxRFC.UnderlineStyle = true;
            // 
            // textBoxReferencia
            // 
            this.textBoxReferencia.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxReferencia.BorderColor = System.Drawing.Color.Blue;
            this.textBoxReferencia.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxReferencia.BorderSize = 1;
            this.textBoxReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReferencia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxReferencia.Location = new System.Drawing.Point(518, 39);
            this.textBoxReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReferencia.Multiline = false;
            this.textBoxReferencia.Name = "textBoxReferencia";
            this.textBoxReferencia.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxReferencia.PasswordChar = false;
            this.textBoxReferencia.Size = new System.Drawing.Size(273, 31);
            this.textBoxReferencia.TabIndex = 20;
            this.textBoxReferencia.Texts = "";
            this.textBoxReferencia.UnderlineStyle = true;
            // 
            // textBoxTerminos
            // 
            this.textBoxTerminos.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTerminos.BorderColor = System.Drawing.Color.Blue;
            this.textBoxTerminos.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxTerminos.BorderSize = 1;
            this.textBoxTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTerminos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxTerminos.Location = new System.Drawing.Point(519, 79);
            this.textBoxTerminos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTerminos.Multiline = false;
            this.textBoxTerminos.Name = "textBoxTerminos";
            this.textBoxTerminos.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxTerminos.PasswordChar = false;
            this.textBoxTerminos.Size = new System.Drawing.Size(273, 31);
            this.textBoxTerminos.TabIndex = 21;
            this.textBoxTerminos.Texts = "";
            this.textBoxTerminos.UnderlineStyle = true;
            // 
            // textBoxVendedor
            // 
            this.textBoxVendedor.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVendedor.BorderColor = System.Drawing.Color.Blue;
            this.textBoxVendedor.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxVendedor.BorderSize = 1;
            this.textBoxVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVendedor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxVendedor.Location = new System.Drawing.Point(520, 119);
            this.textBoxVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVendedor.Multiline = false;
            this.textBoxVendedor.Name = "textBoxVendedor";
            this.textBoxVendedor.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxVendedor.PasswordChar = false;
            this.textBoxVendedor.Size = new System.Drawing.Size(273, 31);
            this.textBoxVendedor.TabIndex = 22;
            this.textBoxVendedor.Texts = "";
            this.textBoxVendedor.UnderlineStyle = true;
            // 
            // textBoxMoneda
            // 
            this.textBoxMoneda.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMoneda.BorderColor = System.Drawing.Color.Blue;
            this.textBoxMoneda.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxMoneda.BorderSize = 1;
            this.textBoxMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoneda.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxMoneda.Location = new System.Drawing.Point(519, 158);
            this.textBoxMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoneda.Multiline = false;
            this.textBoxMoneda.Name = "textBoxMoneda";
            this.textBoxMoneda.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxMoneda.PasswordChar = false;
            this.textBoxMoneda.Size = new System.Drawing.Size(273, 31);
            this.textBoxMoneda.TabIndex = 23;
            this.textBoxMoneda.Texts = "";
            this.textBoxMoneda.UnderlineStyle = true;
            // 
            // textBoxEmite
            // 
            this.textBoxEmite.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmite.BorderColor = System.Drawing.Color.Blue;
            this.textBoxEmite.BorderFocusColor = System.Drawing.Color.Red;
            this.textBoxEmite.BorderSize = 1;
            this.textBoxEmite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmite.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxEmite.Location = new System.Drawing.Point(898, 39);
            this.textBoxEmite.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmite.Multiline = false;
            this.textBoxEmite.Name = "textBoxEmite";
            this.textBoxEmite.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxEmite.PasswordChar = false;
            this.textBoxEmite.Size = new System.Drawing.Size(273, 31);
            this.textBoxEmite.TabIndex = 24;
            this.textBoxEmite.Texts = "";
            this.textBoxEmite.UnderlineStyle = true;
            // 
            // textboxFecha
            // 
            this.textboxFecha.BackColor = System.Drawing.SystemColors.Window;
            this.textboxFecha.BorderColor = System.Drawing.Color.Blue;
            this.textboxFecha.BorderFocusColor = System.Drawing.Color.Red;
            this.textboxFecha.BorderSize = 1;
            this.textboxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFecha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textboxFecha.Location = new System.Drawing.Point(899, 119);
            this.textboxFecha.Margin = new System.Windows.Forms.Padding(4);
            this.textboxFecha.Multiline = false;
            this.textboxFecha.Name = "textboxFecha";
            this.textboxFecha.Padding = new System.Windows.Forms.Padding(7);
            this.textboxFecha.PasswordChar = false;
            this.textboxFecha.Size = new System.Drawing.Size(273, 31);
            this.textboxFecha.TabIndex = 9;
            this.textboxFecha.Texts = "";
            this.textboxFecha.UnderlineStyle = true;
            // 
            // textBox_numeroCoti
            // 
            this.textBox_numeroCoti.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_numeroCoti.BorderColor = System.Drawing.Color.Blue;
            this.textBox_numeroCoti.BorderFocusColor = System.Drawing.Color.Red;
            this.textBox_numeroCoti.BorderSize = 1;
            this.textBox_numeroCoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_numeroCoti.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_numeroCoti.Location = new System.Drawing.Point(898, 80);
            this.textBox_numeroCoti.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_numeroCoti.Multiline = false;
            this.textBox_numeroCoti.Name = "textBox_numeroCoti";
            this.textBox_numeroCoti.Padding = new System.Windows.Forms.Padding(7);
            this.textBox_numeroCoti.PasswordChar = false;
            this.textBox_numeroCoti.Size = new System.Drawing.Size(273, 31);
            this.textBox_numeroCoti.TabIndex = 8;
            this.textBox_numeroCoti.Texts = "";
            this.textBox_numeroCoti.UnderlineStyle = true;
            // 
            // textboxPagina
            // 
            this.textboxPagina.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPagina.BorderColor = System.Drawing.Color.Blue;
            this.textboxPagina.BorderFocusColor = System.Drawing.Color.Red;
            this.textboxPagina.BorderSize = 1;
            this.textboxPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPagina.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textboxPagina.Location = new System.Drawing.Point(899, 158);
            this.textboxPagina.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPagina.Multiline = false;
            this.textboxPagina.Name = "textboxPagina";
            this.textboxPagina.Padding = new System.Windows.Forms.Padding(7);
            this.textboxPagina.PasswordChar = false;
            this.textboxPagina.Size = new System.Drawing.Size(273, 31);
            this.textboxPagina.TabIndex = 10;
            this.textboxPagina.Texts = "";
            this.textboxPagina.UnderlineStyle = true;
            // 
            // gb_DetallesProducto
            // 
            this.gb_DetallesProducto.Controls.Add(this.impboxx);
            this.gb_DetallesProducto.Controls.Add(this.labelunit);
            this.gb_DetallesProducto.Controls.Add(this.ltmbox);
            this.gb_DetallesProducto.Controls.Add(this.ltmlabel);
            this.gb_DetallesProducto.Controls.Add(this.boxunid);
            this.gb_DetallesProducto.Controls.Add(this.labelCodprod);
            this.gb_DetallesProducto.Controls.Add(this.porcientodsct);
            this.gb_DetallesProducto.Controls.Add(this.codprodcbox);
            this.gb_DetallesProducto.Controls.Add(this.descriProductBox);
            this.gb_DetallesProducto.Controls.Add(this.dsctglobalbox);
            this.gb_DetallesProducto.Controls.Add(this.labeldescripcionproducto);
            this.gb_DetallesProducto.Controls.Add(this.labelImp);
            this.gb_DetallesProducto.Controls.Add(this.labelbodg);
            this.gb_DetallesProducto.Controls.Add(this.labelcantidad);
            this.gb_DetallesProducto.Controls.Add(this.labelunid);
            this.gb_DetallesProducto.Controls.Add(this.labelPrecio);
            this.gb_DetallesProducto.Controls.Add(this.bodgbox);
            this.gb_DetallesProducto.Controls.Add(this.boxcantidad);
            this.gb_DetallesProducto.Controls.Add(this.boxprecio);
            this.gb_DetallesProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DetallesProducto.Location = new System.Drawing.Point(12, 232);
            this.gb_DetallesProducto.Name = "gb_DetallesProducto";
            this.gb_DetallesProducto.Size = new System.Drawing.Size(1189, 162);
            this.gb_DetallesProducto.TabIndex = 65;
            this.gb_DetallesProducto.TabStop = false;
            this.gb_DetallesProducto.Text = "Detalles Producto";
            // 
            // impboxx
            // 
            this.impboxx.BackColor = System.Drawing.SystemColors.Window;
            this.impboxx.BorderColor = System.Drawing.Color.Red;
            this.impboxx.BorderFocusColor = System.Drawing.Color.Red;
            this.impboxx.BorderSize = 1;
            this.impboxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impboxx.ForeColor = System.Drawing.SystemColors.GrayText;
            this.impboxx.Location = new System.Drawing.Point(902, 32);
            this.impboxx.Margin = new System.Windows.Forms.Padding(4);
            this.impboxx.Multiline = false;
            this.impboxx.Name = "impboxx";
            this.impboxx.Padding = new System.Windows.Forms.Padding(7);
            this.impboxx.PasswordChar = false;
            this.impboxx.Size = new System.Drawing.Size(269, 31);
            this.impboxx.TabIndex = 64;
            this.impboxx.Texts = "";
            this.impboxx.UnderlineStyle = true;
            // 
            // labelunit
            // 
            this.labelunit.AutoSize = true;
            this.labelunit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelunit.ForeColor = System.Drawing.Color.Red;
            this.labelunit.Location = new System.Drawing.Point(855, 78);
            this.labelunit.Name = "labelunit";
            this.labelunit.Size = new System.Drawing.Size(36, 16);
            this.labelunit.TabIndex = 63;
            this.labelunit.Text = "UNIT";
            // 
            // ltmbox
            // 
            this.ltmbox.BackColor = System.Drawing.SystemColors.Window;
            this.ltmbox.BorderColor = System.Drawing.Color.Red;
            this.ltmbox.BorderFocusColor = System.Drawing.Color.Red;
            this.ltmbox.BorderSize = 1;
            this.ltmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltmbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ltmbox.Location = new System.Drawing.Point(150, 32);
            this.ltmbox.Margin = new System.Windows.Forms.Padding(4);
            this.ltmbox.Multiline = false;
            this.ltmbox.Name = "ltmbox";
            this.ltmbox.Padding = new System.Windows.Forms.Padding(7);
            this.ltmbox.PasswordChar = false;
            this.ltmbox.Size = new System.Drawing.Size(269, 31);
            this.ltmbox.TabIndex = 36;
            this.ltmbox.Texts = "";
            this.ltmbox.UnderlineStyle = true;
            // 
            // boxunid
            // 
            this.boxunid.BackColor = System.Drawing.SystemColors.Window;
            this.boxunid.BorderColor = System.Drawing.Color.Red;
            this.boxunid.BorderFocusColor = System.Drawing.Color.Red;
            this.boxunid.BorderSize = 1;
            this.boxunid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxunid.ForeColor = System.Drawing.SystemColors.GrayText;
            this.boxunid.Location = new System.Drawing.Point(903, 71);
            this.boxunid.Margin = new System.Windows.Forms.Padding(4);
            this.boxunid.Multiline = false;
            this.boxunid.Name = "boxunid";
            this.boxunid.Padding = new System.Windows.Forms.Padding(7);
            this.boxunid.PasswordChar = false;
            this.boxunid.Size = new System.Drawing.Size(269, 31);
            this.boxunid.TabIndex = 48;
            this.boxunid.Texts = "";
            this.boxunid.UnderlineStyle = true;
            // 
            // codprodcbox
            // 
            this.codprodcbox.BackColor = System.Drawing.SystemColors.Window;
            this.codprodcbox.BorderColor = System.Drawing.Color.Red;
            this.codprodcbox.BorderFocusColor = System.Drawing.Color.Red;
            this.codprodcbox.BorderSize = 1;
            this.codprodcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codprodcbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.codprodcbox.Location = new System.Drawing.Point(150, 71);
            this.codprodcbox.Margin = new System.Windows.Forms.Padding(4);
            this.codprodcbox.Multiline = false;
            this.codprodcbox.Name = "codprodcbox";
            this.codprodcbox.Padding = new System.Windows.Forms.Padding(7);
            this.codprodcbox.PasswordChar = false;
            this.codprodcbox.Size = new System.Drawing.Size(269, 31);
            this.codprodcbox.TabIndex = 37;
            this.codprodcbox.Texts = "";
            this.codprodcbox.UnderlineStyle = true;
            // 
            // descriProductBox
            // 
            this.descriProductBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriProductBox.BorderColor = System.Drawing.Color.Red;
            this.descriProductBox.BorderFocusColor = System.Drawing.Color.Red;
            this.descriProductBox.BorderSize = 1;
            this.descriProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriProductBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.descriProductBox.Location = new System.Drawing.Point(150, 110);
            this.descriProductBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriProductBox.Multiline = true;
            this.descriProductBox.Name = "descriProductBox";
            this.descriProductBox.Padding = new System.Windows.Forms.Padding(7);
            this.descriProductBox.PasswordChar = false;
            this.descriProductBox.Size = new System.Drawing.Size(266, 31);
            this.descriProductBox.TabIndex = 38;
            this.descriProductBox.Texts = "";
            this.descriProductBox.UnderlineStyle = true;
            // 
            // dsctglobalbox
            // 
            this.dsctglobalbox.BackColor = System.Drawing.SystemColors.Window;
            this.dsctglobalbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dsctglobalbox.BorderFocusColor = System.Drawing.Color.Red;
            this.dsctglobalbox.BorderSize = 2;
            this.dsctglobalbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsctglobalbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dsctglobalbox.Location = new System.Drawing.Point(903, 109);
            this.dsctglobalbox.Margin = new System.Windows.Forms.Padding(4);
            this.dsctglobalbox.Multiline = false;
            this.dsctglobalbox.Name = "dsctglobalbox";
            this.dsctglobalbox.Padding = new System.Windows.Forms.Padding(7);
            this.dsctglobalbox.PasswordChar = false;
            this.dsctglobalbox.Size = new System.Drawing.Size(269, 31);
            this.dsctglobalbox.TabIndex = 58;
            this.dsctglobalbox.Texts = "";
            this.dsctglobalbox.UnderlineStyle = true;
            // 
            // bodgbox
            // 
            this.bodgbox.BackColor = System.Drawing.SystemColors.Window;
            this.bodgbox.BorderColor = System.Drawing.Color.Red;
            this.bodgbox.BorderFocusColor = System.Drawing.Color.Red;
            this.bodgbox.BorderSize = 1;
            this.bodgbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodgbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bodgbox.Location = new System.Drawing.Point(520, 32);
            this.bodgbox.Margin = new System.Windows.Forms.Padding(4);
            this.bodgbox.Multiline = true;
            this.bodgbox.Name = "bodgbox";
            this.bodgbox.Padding = new System.Windows.Forms.Padding(7);
            this.bodgbox.PasswordChar = false;
            this.bodgbox.Size = new System.Drawing.Size(269, 31);
            this.bodgbox.TabIndex = 39;
            this.bodgbox.Texts = "";
            this.bodgbox.UnderlineStyle = true;
            // 
            // boxcantidad
            // 
            this.boxcantidad.BackColor = System.Drawing.SystemColors.Window;
            this.boxcantidad.BorderColor = System.Drawing.Color.Red;
            this.boxcantidad.BorderFocusColor = System.Drawing.Color.Red;
            this.boxcantidad.BorderSize = 1;
            this.boxcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxcantidad.ForeColor = System.Drawing.SystemColors.GrayText;
            this.boxcantidad.Location = new System.Drawing.Point(521, 71);
            this.boxcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.boxcantidad.Multiline = false;
            this.boxcantidad.Name = "boxcantidad";
            this.boxcantidad.Padding = new System.Windows.Forms.Padding(7);
            this.boxcantidad.PasswordChar = false;
            this.boxcantidad.Size = new System.Drawing.Size(269, 31);
            this.boxcantidad.TabIndex = 47;
            this.boxcantidad.Texts = "";
            this.boxcantidad.UnderlineStyle = true;
            // 
            // boxprecio
            // 
            this.boxprecio.BackColor = System.Drawing.SystemColors.Window;
            this.boxprecio.BorderColor = System.Drawing.Color.Red;
            this.boxprecio.BorderFocusColor = System.Drawing.Color.Red;
            this.boxprecio.BorderSize = 1;
            this.boxprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxprecio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.boxprecio.Location = new System.Drawing.Point(521, 110);
            this.boxprecio.Margin = new System.Windows.Forms.Padding(4);
            this.boxprecio.Multiline = false;
            this.boxprecio.Name = "boxprecio";
            this.boxprecio.Padding = new System.Windows.Forms.Padding(7);
            this.boxprecio.PasswordChar = false;
            this.boxprecio.Size = new System.Drawing.Size(269, 31);
            this.boxprecio.TabIndex = 49;
            this.boxprecio.Texts = "";
            this.boxprecio.UnderlineStyle = true;
            // 
            // borrarbuton
            // 
            this.borrarbuton.BackColor = System.Drawing.Color.Red;
            this.borrarbuton.BackgroundColor = System.Drawing.Color.Red;
            this.borrarbuton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.borrarbuton.BorderRadius = 10;
            this.borrarbuton.BorderSize = 0;
            this.borrarbuton.FlatAppearance.BorderSize = 0;
            this.borrarbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarbuton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarbuton.ForeColor = System.Drawing.Color.White;
            this.borrarbuton.Location = new System.Drawing.Point(1223, 336);
            this.borrarbuton.Margin = new System.Windows.Forms.Padding(10);
            this.borrarbuton.Name = "borrarbuton";
            this.borrarbuton.Size = new System.Drawing.Size(128, 63);
            this.borrarbuton.TabIndex = 56;
            this.borrarbuton.Text = "BORRAR";
            this.borrarbuton.TextColor = System.Drawing.Color.White;
            this.borrarbuton.UseVisualStyleBackColor = false;
            this.borrarbuton.Click += new System.EventHandler(this.borrarbuton_Click);
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
            this.cleanbuton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanbuton.ForeColor = System.Drawing.Color.White;
            this.cleanbuton.Location = new System.Drawing.Point(1223, 253);
            this.cleanbuton.Margin = new System.Windows.Forms.Padding(10);
            this.cleanbuton.Name = "cleanbuton";
            this.cleanbuton.Size = new System.Drawing.Size(128, 63);
            this.cleanbuton.TabIndex = 55;
            this.cleanbuton.Text = "LIMPIAR CASILLAS";
            this.cleanbuton.TextColor = System.Drawing.Color.White;
            this.cleanbuton.UseVisualStyleBackColor = false;
            this.cleanbuton.Click += new System.EventHandler(this.cleanbuton_Click);
            // 
            // botonmenuprincipal
            // 
            this.botonmenuprincipal.BackColor = System.Drawing.Color.DarkKhaki;
            this.botonmenuprincipal.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.botonmenuprincipal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonmenuprincipal.BorderRadius = 10;
            this.botonmenuprincipal.BorderSize = 0;
            this.botonmenuprincipal.FlatAppearance.BorderSize = 0;
            this.botonmenuprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonmenuprincipal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonmenuprincipal.ForeColor = System.Drawing.Color.White;
            this.botonmenuprincipal.Location = new System.Drawing.Point(1223, 24);
            this.botonmenuprincipal.Margin = new System.Windows.Forms.Padding(10);
            this.botonmenuprincipal.Name = "botonmenuprincipal";
            this.botonmenuprincipal.Size = new System.Drawing.Size(128, 52);
            this.botonmenuprincipal.TabIndex = 54;
            this.botonmenuprincipal.Text = "MENU";
            this.botonmenuprincipal.TextColor = System.Drawing.Color.White;
            this.botonmenuprincipal.UseVisualStyleBackColor = false;
            this.botonmenuprincipal.Click += new System.EventHandler(this.rjControls1_Click);
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
            this.butonImprimir.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonImprimir.ForeColor = System.Drawing.Color.White;
            this.butonImprimir.Location = new System.Drawing.Point(1223, 170);
            this.butonImprimir.Margin = new System.Windows.Forms.Padding(10);
            this.butonImprimir.Name = "butonImprimir";
            this.butonImprimir.Size = new System.Drawing.Size(128, 63);
            this.butonImprimir.TabIndex = 27;
            this.butonImprimir.Text = "TERMINAR E IMPRIMIR";
            this.butonImprimir.TextColor = System.Drawing.Color.White;
            this.butonImprimir.UseVisualStyleBackColor = false;
            this.butonImprimir.Click += new System.EventHandler(this.butonImprimir_Click);
            // 
            // botonAgregarProducto
            // 
            this.botonAgregarProducto.BackColor = System.Drawing.Color.Blue;
            this.botonAgregarProducto.BackgroundColor = System.Drawing.Color.Blue;
            this.botonAgregarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonAgregarProducto.BorderRadius = 10;
            this.botonAgregarProducto.BorderSize = 0;
            this.botonAgregarProducto.FlatAppearance.BorderSize = 0;
            this.botonAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregarProducto.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.botonAgregarProducto.Location = new System.Drawing.Point(1223, 90);
            this.botonAgregarProducto.Margin = new System.Windows.Forms.Padding(10);
            this.botonAgregarProducto.Name = "botonAgregarProducto";
            this.botonAgregarProducto.Size = new System.Drawing.Size(128, 63);
            this.botonAgregarProducto.TabIndex = 26;
            this.botonAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.botonAgregarProducto.TextColor = System.Drawing.Color.White;
            this.botonAgregarProducto.UseVisualStyleBackColor = false;
            this.botonAgregarProducto.Click += new System.EventHandler(this.botonAgregarProducto_Click);
            // 
            // Form_orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 690);
            this.Controls.Add(this.gb_DetallesProducto);
            this.Controls.Add(this.gb_DatosClientes);
            this.Controls.Add(this.borrarbuton);
            this.Controls.Add(this.cleanbuton);
            this.Controls.Add(this.botonmenuprincipal);
            this.Controls.Add(this.butonImprimir);
            this.Controls.Add(this.botonAgregarProducto);
            this.Controls.Add(this.gridprodc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_orden";
            this.Text = "Orden_compra_reporte";
            this.Load += new System.EventHandler(this.Form_cotiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridprodc)).EndInit();
            this.gb_DatosClientes.ResumeLayout(false);
            this.gb_DatosClientes.PerformLayout();
            this.gb_DetallesProducto.ResumeLayout(false);
            this.gb_DetallesProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.Label RNC_label;
        private widgets.RJTextBox textBox_nombre;
        private widgets.RJTextBox textBox_RNC;
        private System.Windows.Forms.Label label_NumeroCoti;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelPagina;
        private widgets.RJTextBox textBox_numeroCoti;
        private widgets.RJTextBox textboxFecha;
        private widgets.RJTextBox textboxPagina;
        private System.Windows.Forms.Label label_CodigoCliente;
        private System.Windows.Forms.Label label_RFC;
        private System.Windows.Forms.Label label_referencia;
        private System.Windows.Forms.Label label_terminos;
        private System.Windows.Forms.Label label_vendedor;
        private System.Windows.Forms.Label label_moneda;
        private System.Windows.Forms.Label label_emite;
        private widgets.RJTextBox textBoxCodigoCliente;
        private widgets.RJTextBox textboxRFC;
        private widgets.RJTextBox textBoxReferencia;
        private widgets.RJTextBox textBoxTerminos;
        private widgets.RJTextBox textBoxVendedor;
        private widgets.RJTextBox textBoxMoneda;
        private widgets.RJTextBox textBoxEmite;
        private System.Windows.Forms.DataGridView gridprodc;
        private widgets.RJControls botonAgregarProducto;
        private widgets.RJControls butonImprimir;
        private System.Windows.Forms.Label ltmlabel;
        private System.Windows.Forms.Label labelCodprod;
        private System.Windows.Forms.Label labeldescripcionproducto;
        private System.Windows.Forms.Label labelbodg;
        private widgets.RJTextBox ltmbox;
        private widgets.RJTextBox codprodcbox;
        private widgets.RJTextBox descriProductBox;
        private widgets.RJTextBox bodgbox;
        private System.Windows.Forms.Label labelcantidad;
        private System.Windows.Forms.Label labelunid;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelImp;
        private widgets.RJTextBox boxcantidad;
        private widgets.RJTextBox boxunid;
        private widgets.RJTextBox boxprecio;
        private widgets.RJControls botonmenuprincipal;
        private widgets.RJControls cleanbuton;
        private widgets.RJControls borrarbuton;
        private System.Windows.Forms.Label porcientodsct;
        private widgets.RJTextBox dsctglobalbox;

        private System.Windows.Forms.GroupBox gb_DatosClientes;
        private System.Windows.Forms.GroupBox gb_DetallesProducto;
        private System.Windows.Forms.Label labelunit;
        private widgets.RJTextBox impboxx;
    }


}
