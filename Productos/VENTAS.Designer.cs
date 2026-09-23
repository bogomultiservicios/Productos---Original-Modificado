namespace Productos
{
    partial class VENTAS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VENTAS));
            this.txtANTICIPO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnANTICIPO = new System.Windows.Forms.Button();
            this.chkAnticipo = new System.Windows.Forms.CheckBox();
            this.btnPAGAR = new System.Windows.Forms.Button();
            this.btnBORRARLINEA = new System.Windows.Forms.Button();
            this.liViCOMPRAS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pROSERVLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATRIARCADataSet2 = new Productos.pATRIARCADataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMUNICIPIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDEPART = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTEL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDIREC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombClie = new System.Windows.Forms.TextBox();
            this.picbEXIT = new System.Windows.Forms.PictureBox();
            this.picbMINIMIN = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regitroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDeudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasPerdidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAGREGARCLIENTE = new System.Windows.Forms.Button();
            this.pROSERVLISTTableAdapter = new Productos.pATRIARCADataSet2TableAdapters.PROSERVLISTTableAdapter();
            this.btnAGREGPRODSERV = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantProdServ = new System.Windows.Forms.TextBox();
            this.lblResulVenMSJ = new System.Windows.Forms.Label();
            this.btnLIMPIARTODO = new System.Windows.Forms.Button();
            this.liviPRODUSERV = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBUSQPROSERV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnREPMENS = new System.Windows.Forms.Button();
            this.lblDESCUENTO = new System.Windows.Forms.Label();
            this.txtDESCUENTO = new System.Windows.Forms.TextBox();
            this.lblSimbPorce = new System.Windows.Forms.Label();
            this.btnDESCUENTO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pROSERVLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATRIARCADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMINIMIN)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtANTICIPO
            // 
            this.txtANTICIPO.Enabled = false;
            this.txtANTICIPO.Location = new System.Drawing.Point(898, 611);
            this.txtANTICIPO.Name = "txtANTICIPO";
            this.txtANTICIPO.ReadOnly = true;
            this.txtANTICIPO.Size = new System.Drawing.Size(83, 20);
            this.txtANTICIPO.TabIndex = 57;
            this.txtANTICIPO.Text = "0";
            this.txtANTICIPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtANTICIPO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtANTICIPO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtANTICIPO_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(826, 614);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "ANTICIPO";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Location = new System.Drawing.Point(898, 575);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(83, 20);
            this.txtTOTAL.TabIndex = 55;
            this.txtTOTAL.Text = "0";
            this.txtTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTOTAL.TextChanged += new System.EventHandler(this.txtTOTAL_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(841, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "TOTAL";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnANTICIPO
            // 
            this.btnANTICIPO.BackColor = System.Drawing.Color.DarkRed;
            this.btnANTICIPO.Enabled = false;
            this.btnANTICIPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnANTICIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnANTICIPO.ForeColor = System.Drawing.SystemColors.Control;
            this.btnANTICIPO.Location = new System.Drawing.Point(722, 648);
            this.btnANTICIPO.Name = "btnANTICIPO";
            this.btnANTICIPO.Size = new System.Drawing.Size(95, 43);
            this.btnANTICIPO.TabIndex = 53;
            this.btnANTICIPO.Text = "INGRESAR ANTICIPO";
            this.btnANTICIPO.UseVisualStyleBackColor = false;
            this.btnANTICIPO.Click += new System.EventHandler(this.btnANTICIPO_Click);
            // 
            // chkAnticipo
            // 
            this.chkAnticipo.AutoSize = true;
            this.chkAnticipo.BackColor = System.Drawing.Color.Transparent;
            this.chkAnticipo.Location = new System.Drawing.Point(898, 552);
            this.chkAnticipo.Name = "chkAnticipo";
            this.chkAnticipo.Size = new System.Drawing.Size(76, 17);
            this.chkAnticipo.TabIndex = 52;
            this.chkAnticipo.Text = "ANTICIPO";
            this.chkAnticipo.UseVisualStyleBackColor = false;
            this.chkAnticipo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnPAGAR
            // 
            this.btnPAGAR.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPAGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAGAR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPAGAR.Location = new System.Drawing.Point(829, 650);
            this.btnPAGAR.Name = "btnPAGAR";
            this.btnPAGAR.Size = new System.Drawing.Size(129, 41);
            this.btnPAGAR.TabIndex = 51;
            this.btnPAGAR.Text = "PAGAR";
            this.btnPAGAR.UseVisualStyleBackColor = false;
            this.btnPAGAR.Click += new System.EventHandler(this.btnPAGAR_Click);
            // 
            // btnBORRARLINEA
            // 
            this.btnBORRARLINEA.BackColor = System.Drawing.Color.Indigo;
            this.btnBORRARLINEA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBORRARLINEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBORRARLINEA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBORRARLINEA.Location = new System.Drawing.Point(86, 652);
            this.btnBORRARLINEA.Name = "btnBORRARLINEA";
            this.btnBORRARLINEA.Size = new System.Drawing.Size(129, 37);
            this.btnBORRARLINEA.TabIndex = 50;
            this.btnBORRARLINEA.Text = "BORRAR LINEA";
            this.btnBORRARLINEA.UseVisualStyleBackColor = false;
            this.btnBORRARLINEA.Click += new System.EventHandler(this.btnBORRARLINEA_Click);
            // 
            // liViCOMPRAS
            // 
            this.liViCOMPRAS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader9});
            this.liViCOMPRAS.HideSelection = false;
            this.liViCOMPRAS.Location = new System.Drawing.Point(86, 486);
            this.liViCOMPRAS.Name = "liViCOMPRAS";
            this.liViCOMPRAS.Size = new System.Drawing.Size(720, 160);
            this.liViCOMPRAS.TabIndex = 49;
            this.liViCOMPRAS.UseCompatibleStateImageBehavior = false;
            this.liViCOMPRAS.View = System.Windows.Forms.View.Details;
            this.liViCOMPRAS.SelectedIndexChanged += new System.EventHandler(this.liViCOMPRAS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PRODUCTO/SERVICIO";
            this.columnHeader1.Width = 339;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PRECIO";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CANTIDAD";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 74;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DESCUENTO";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 81;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PRECIO CON DESCUENTO";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 153;
            // 
            // pROSERVLISTBindingSource
            // 
            this.pROSERVLISTBindingSource.DataMember = "PROSERVLIST";
            this.pROSERVLISTBindingSource.DataSource = this.pATRIARCADataSet2;
            // 
            // pATRIARCADataSet2
            // 
            this.pATRIARCADataSet2.DataSetName = "pATRIARCADataSet2";
            this.pATRIARCADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(699, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "MUNICIPIO";
            // 
            // txtMUNICIPIO
            // 
            this.txtMUNICIPIO.Location = new System.Drawing.Point(779, 281);
            this.txtMUNICIPIO.Name = "txtMUNICIPIO";
            this.txtMUNICIPIO.Size = new System.Drawing.Size(225, 20);
            this.txtMUNICIPIO.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(665, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "DEPARTAMENTO";
            // 
            // txtDEPART
            // 
            this.txtDEPART.Location = new System.Drawing.Point(779, 245);
            this.txtDEPART.MaxLength = 25;
            this.txtDEPART.Name = "txtDEPART";
            this.txtDEPART.Size = new System.Drawing.Size(225, 20);
            this.txtDEPART.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(698, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "TELEFONO";
            // 
            // txtTEL
            // 
            this.txtTEL.Location = new System.Drawing.Point(779, 209);
            this.txtTEL.MaxLength = 8;
            this.txtTEL.Name = "txtTEL";
            this.txtTEL.Size = new System.Drawing.Size(91, 20);
            this.txtTEL.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(696, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "DIRECCION";
            // 
            // txtDIREC
            // 
            this.txtDIREC.Location = new System.Drawing.Point(779, 171);
            this.txtDIREC.Name = "txtDIREC";
            this.txtDIREC.Size = new System.Drawing.Size(225, 20);
            this.txtDIREC.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(737, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "NIT";
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(779, 138);
            this.txtNIT.MaxLength = 20;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(82, 20);
            this.txtNIT.TabIndex = 38;
            this.txtNIT.TextChanged += new System.EventHandler(this.txtNIT_TextChanged);
            this.txtNIT.DoubleClick += new System.EventHandler(this.txtNIT_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(660, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "NOMBRE CLIENTE";
            // 
            // txtNombClie
            // 
            this.txtNombClie.Location = new System.Drawing.Point(779, 109);
            this.txtNombClie.MaxLength = 50;
            this.txtNombClie.Name = "txtNombClie";
            this.txtNombClie.Size = new System.Drawing.Size(225, 20);
            this.txtNombClie.TabIndex = 36;
            this.txtNombClie.TextChanged += new System.EventHandler(this.txtNombClie_TextChanged);
            this.txtNombClie.DoubleClick += new System.EventHandler(this.txtNombClie_DoubleClick);
            this.txtNombClie.Enter += new System.EventHandler(this.txtNombClie_ENTER);
            // 
            // picbEXIT
            // 
            this.picbEXIT.BackColor = System.Drawing.Color.Transparent;
            this.picbEXIT.Image = ((System.Drawing.Image)(resources.GetObject("picbEXIT.Image")));
            this.picbEXIT.Location = new System.Drawing.Point(999, 12);
            this.picbEXIT.Name = "picbEXIT";
            this.picbEXIT.Size = new System.Drawing.Size(34, 36);
            this.picbEXIT.TabIndex = 60;
            this.picbEXIT.TabStop = false;
            this.picbEXIT.Click += new System.EventHandler(this.picbEXIT_Click);
            // 
            // picbMINIMIN
            // 
            this.picbMINIMIN.BackColor = System.Drawing.Color.Transparent;
            this.picbMINIMIN.Image = ((System.Drawing.Image)(resources.GetObject("picbMINIMIN.Image")));
            this.picbMINIMIN.Location = new System.Drawing.Point(959, 12);
            this.picbMINIMIN.Name = "picbMINIMIN";
            this.picbMINIMIN.Size = new System.Drawing.Size(34, 36);
            this.picbMINIMIN.TabIndex = 59;
            this.picbMINIMIN.TabStop = false;
            this.picbMINIMIN.Click += new System.EventHandler(this.picbMINIMIN_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regitroDeProductosToolStripMenuItem,
            this.ventaDeProductoToolStripMenuItem,
            this.pagoDeudaToolStripMenuItem,
            this.gananciasPerdidasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 33);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regitroDeProductosToolStripMenuItem
            // 
            this.regitroDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.regitroDeProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.regitroDeProductosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.regitroDeProductosToolStripMenuItem.Name = "regitroDeProductosToolStripMenuItem";
            this.regitroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.regitroDeProductosToolStripMenuItem.Text = "Producto/Servicio";
            this.regitroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.regitroDeProductosToolStripMenuItem_Click);
            // 
            // ventaDeProductoToolStripMenuItem
            // 
            this.ventaDeProductoToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.ventaDeProductoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ventaDeProductoToolStripMenuItem.ForeColor = System.Drawing.Color.LightGreen;
            this.ventaDeProductoToolStripMenuItem.Name = "ventaDeProductoToolStripMenuItem";
            this.ventaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.ventaDeProductoToolStripMenuItem.Text = "Venta de Producto/Servicio";
            this.ventaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.ventaDeProductoToolStripMenuItem_Click);
            // 
            // pagoDeudaToolStripMenuItem
            // 
            this.pagoDeudaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pagoDeudaToolStripMenuItem.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Bold);
            this.pagoDeudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pagoDeudaToolStripMenuItem.Name = "pagoDeudaToolStripMenuItem";
            this.pagoDeudaToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.pagoDeudaToolStripMenuItem.Text = "Pago Deuda";
            this.pagoDeudaToolStripMenuItem.Click += new System.EventHandler(this.pagoDeudaToolStripMenuItem_Click);
            // 
            // gananciasPerdidasToolStripMenuItem
            // 
            this.gananciasPerdidasToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.gananciasPerdidasToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gananciasPerdidasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.gananciasPerdidasToolStripMenuItem.Name = "gananciasPerdidasToolStripMenuItem";
            this.gananciasPerdidasToolStripMenuItem.Size = new System.Drawing.Size(233, 29);
            this.gananciasPerdidasToolStripMenuItem.Text = "Ganancias/Perdidas";
            this.gananciasPerdidasToolStripMenuItem.Click += new System.EventHandler(this.gananciasPerdidasToolStripMenuItem_Click);
            // 
            // btnAGREGARCLIENTE
            // 
            this.btnAGREGARCLIENTE.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAGREGARCLIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGARCLIENTE.Font = new System.Drawing.Font("Stencil Std", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGARCLIENTE.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAGREGARCLIENTE.Location = new System.Drawing.Point(746, 36);
            this.btnAGREGARCLIENTE.Name = "btnAGREGARCLIENTE";
            this.btnAGREGARCLIENTE.Size = new System.Drawing.Size(171, 56);
            this.btnAGREGARCLIENTE.TabIndex = 61;
            this.btnAGREGARCLIENTE.Text = "AGREGAR CLIENTE";
            this.btnAGREGARCLIENTE.UseVisualStyleBackColor = false;
            this.btnAGREGARCLIENTE.Visible = false;
            this.btnAGREGARCLIENTE.Click += new System.EventHandler(this.btnAGREGARCLIENTE_Click);
            // 
            // pROSERVLISTTableAdapter
            // 
            this.pROSERVLISTTableAdapter.ClearBeforeFill = true;
            // 
            // btnAGREGPRODSERV
            // 
            this.btnAGREGPRODSERV.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAGREGPRODSERV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGPRODSERV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAGREGPRODSERV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAGREGPRODSERV.Location = new System.Drawing.Point(829, 485);
            this.btnAGREGPRODSERV.Name = "btnAGREGPRODSERV";
            this.btnAGREGPRODSERV.Size = new System.Drawing.Size(87, 46);
            this.btnAGREGPRODSERV.TabIndex = 63;
            this.btnAGREGPRODSERV.Text = "AGREGAR";
            this.btnAGREGPRODSERV.UseVisualStyleBackColor = false;
            this.btnAGREGPRODSERV.Click += new System.EventHandler(this.btnAGREGPRODSERV_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(932, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "CANTIDAD";
            // 
            // txtCantProdServ
            // 
            this.txtCantProdServ.Location = new System.Drawing.Point(922, 501);
            this.txtCantProdServ.Name = "txtCantProdServ";
            this.txtCantProdServ.Size = new System.Drawing.Size(83, 20);
            this.txtCantProdServ.TabIndex = 65;
            this.txtCantProdServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantProdServ.TextChanged += new System.EventHandler(this.txtCantProdServ_TextChanged);
            this.txtCantProdServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantProdServ_KeyPress);
            // 
            // lblResulVenMSJ
            // 
            this.lblResulVenMSJ.AutoSize = true;
            this.lblResulVenMSJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResulVenMSJ.Location = new System.Drawing.Point(336, 662);
            this.lblResulVenMSJ.Name = "lblResulVenMSJ";
            this.lblResulVenMSJ.Size = new System.Drawing.Size(35, 16);
            this.lblResulVenMSJ.TabIndex = 66;
            this.lblResulVenMSJ.Text = "XXX";
            this.lblResulVenMSJ.Visible = false;
            // 
            // btnLIMPIARTODO
            // 
            this.btnLIMPIARTODO.BackColor = System.Drawing.Color.Brown;
            this.btnLIMPIARTODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPIARTODO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIARTODO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLIMPIARTODO.Location = new System.Drawing.Point(404, 254);
            this.btnLIMPIARTODO.Name = "btnLIMPIARTODO";
            this.btnLIMPIARTODO.Size = new System.Drawing.Size(194, 47);
            this.btnLIMPIARTODO.TabIndex = 67;
            this.btnLIMPIARTODO.Text = "LIMPIAR";
            this.btnLIMPIARTODO.UseVisualStyleBackColor = false;
            this.btnLIMPIARTODO.Click += new System.EventHandler(this.button1_Click);
            // 
            // liviPRODUSERV
            // 
            this.liviPRODUSERV.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.liviPRODUSERV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.liviPRODUSERV.FullRowSelect = true;
            this.liviPRODUSERV.HideSelection = false;
            this.liviPRODUSERV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.liviPRODUSERV.Location = new System.Drawing.Point(339, 359);
            this.liviPRODUSERV.Name = "liviPRODUSERV";
            this.liviPRODUSERV.Size = new System.Drawing.Size(665, 120);
            this.liviPRODUSERV.TabIndex = 68;
            this.liviPRODUSERV.UseCompatibleStateImageBehavior = false;
            this.liviPRODUSERV.View = System.Windows.Forms.View.Details;
            this.liviPRODUSERV.SelectedIndexChanged += new System.EventHandler(this.liviPRODUSERV_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRODUCTO/SERVICIO";
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PRECIO";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CLASIFICACION";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "STOCK";
            // 
            // txtBUSQPROSERV
            // 
            this.txtBUSQPROSERV.Location = new System.Drawing.Point(471, 325);
            this.txtBUSQPROSERV.Name = "txtBUSQPROSERV";
            this.txtBUSQPROSERV.Size = new System.Drawing.Size(446, 20);
            this.txtBUSQPROSERV.TabIndex = 69;
            this.txtBUSQPROSERV.TextChanged += new System.EventHandler(this.txtBUSQPROSERV_TextChanged);
            this.txtBUSQPROSERV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBUSQPROSERV_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "BUSCAR:";
            // 
            // btnREPMENS
            // 
            this.btnREPMENS.BackColor = System.Drawing.Color.Orange;
            this.btnREPMENS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREPMENS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREPMENS.ForeColor = System.Drawing.Color.White;
            this.btnREPMENS.Location = new System.Drawing.Point(404, 154);
            this.btnREPMENS.Name = "btnREPMENS";
            this.btnREPMENS.Size = new System.Drawing.Size(112, 46);
            this.btnREPMENS.TabIndex = 71;
            this.btnREPMENS.Text = "REPORTE MENSUAL";
            this.btnREPMENS.UseVisualStyleBackColor = false;
            this.btnREPMENS.Click += new System.EventHandler(this.btnREPMENS_Click);
            // 
            // lblDESCUENTO
            // 
            this.lblDESCUENTO.AutoSize = true;
            this.lblDESCUENTO.Location = new System.Drawing.Point(389, 213);
            this.lblDESCUENTO.Name = "lblDESCUENTO";
            this.lblDESCUENTO.Size = new System.Drawing.Size(59, 13);
            this.lblDESCUENTO.TabIndex = 72;
            this.lblDESCUENTO.Text = "Descuento";
            // 
            // txtDESCUENTO
            // 
            this.txtDESCUENTO.Enabled = false;
            this.txtDESCUENTO.Location = new System.Drawing.Point(454, 209);
            this.txtDESCUENTO.Name = "txtDESCUENTO";
            this.txtDESCUENTO.ReadOnly = true;
            this.txtDESCUENTO.Size = new System.Drawing.Size(37, 20);
            this.txtDESCUENTO.TabIndex = 73;
            this.txtDESCUENTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDESCUENTO_KeyPress);
            // 
            // lblSimbPorce
            // 
            this.lblSimbPorce.AutoSize = true;
            this.lblSimbPorce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbPorce.Location = new System.Drawing.Point(497, 212);
            this.lblSimbPorce.Name = "lblSimbPorce";
            this.lblSimbPorce.Size = new System.Drawing.Size(20, 17);
            this.lblSimbPorce.TabIndex = 74;
            this.lblSimbPorce.Text = "%";
            // 
            // btnDESCUENTO
            // 
            this.btnDESCUENTO.BackColor = System.Drawing.Color.Yellow;
            this.btnDESCUENTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDESCUENTO.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDESCUENTO.Location = new System.Drawing.Point(523, 206);
            this.btnDESCUENTO.Name = "btnDESCUENTO";
            this.btnDESCUENTO.Size = new System.Drawing.Size(105, 23);
            this.btnDESCUENTO.TabIndex = 75;
            this.btnDESCUENTO.Text = "DESCONTAR";
            this.btnDESCUENTO.UseVisualStyleBackColor = false;
            this.btnDESCUENTO.Visible = false;
            this.btnDESCUENTO.Click += new System.EventHandler(this.btnDESCUENTO_Click);
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1045, 732);
            this.Controls.Add(this.btnDESCUENTO);
            this.Controls.Add(this.lblSimbPorce);
            this.Controls.Add(this.txtDESCUENTO);
            this.Controls.Add(this.lblDESCUENTO);
            this.Controls.Add(this.btnREPMENS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBUSQPROSERV);
            this.Controls.Add(this.liviPRODUSERV);
            this.Controls.Add(this.btnLIMPIARTODO);
            this.Controls.Add(this.lblResulVenMSJ);
            this.Controls.Add(this.txtCantProdServ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAGREGPRODSERV);
            this.Controls.Add(this.btnAGREGARCLIENTE);
            this.Controls.Add(this.picbEXIT);
            this.Controls.Add(this.picbMINIMIN);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtANTICIPO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnANTICIPO);
            this.Controls.Add(this.chkAnticipo);
            this.Controls.Add(this.btnPAGAR);
            this.Controls.Add(this.btnBORRARLINEA);
            this.Controls.Add(this.liViCOMPRAS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMUNICIPIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDEPART);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDIREC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombClie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "VENTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pROSERVLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATRIARCADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMINIMIN)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtANTICIPO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnANTICIPO;
        private System.Windows.Forms.CheckBox chkAnticipo;
        private System.Windows.Forms.Button btnPAGAR;
        private System.Windows.Forms.Button btnBORRARLINEA;
        private System.Windows.Forms.ListView liViCOMPRAS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMUNICIPIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDEPART;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDIREC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombClie;
        private System.Windows.Forms.PictureBox picbEXIT;
        private System.Windows.Forms.PictureBox picbMINIMIN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regitroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeProductoToolStripMenuItem;
        private pATRIARCADataSet2 pATRIARCADataSet2;
        private System.Windows.Forms.BindingSource pROSERVLISTBindingSource;
        private pATRIARCADataSet2TableAdapters.PROSERVLISTTableAdapter pROSERVLISTTableAdapter;
        private System.Windows.Forms.Button btnAGREGARCLIENTE;
        private System.Windows.Forms.ToolStripMenuItem pagoDeudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasPerdidasToolStripMenuItem;
        private System.Windows.Forms.Button btnAGREGPRODSERV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantProdServ;
        private System.Windows.Forms.Label lblResulVenMSJ;
        private System.Windows.Forms.Button btnLIMPIARTODO;
        private System.Windows.Forms.ListView liviPRODUSERV;
        private System.Windows.Forms.TextBox txtBUSQPROSERV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnREPMENS;
        private System.Windows.Forms.Label lblDESCUENTO;
        private System.Windows.Forms.TextBox txtDESCUENTO;
        private System.Windows.Forms.Label lblSimbPorce;
        private System.Windows.Forms.Button btnDESCUENTO;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}