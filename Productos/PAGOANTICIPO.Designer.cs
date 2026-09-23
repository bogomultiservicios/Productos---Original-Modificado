namespace Productos
{
    partial class PAGOANTICIPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAGOANTICIPO));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regitroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDeudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasPerdidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picbEXIT = new System.Windows.Forms.PictureBox();
            this.picbMINIMIN = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMUNICIPIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDEPART = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombClie = new System.Windows.Forms.TextBox();
            this.btnBUSCARCLIE = new System.Windows.Forms.Button();
            this.btnPAGARAnticipo = new System.Windows.Forms.Button();
            this.liviDeudaClie = new System.Windows.Forms.ListView();
            this.CLIENTE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ANTICIPO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FALTANTE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FECHA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HORA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngAnticipo = new System.Windows.Forms.TextBox();
            this.btnBorrarLinea = new System.Windows.Forms.Button();
            this.chkIngAnticipo = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMINIMIN)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1039, 33);
            this.menuStrip1.TabIndex = 59;
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
            this.ventaDeProductoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.ventaDeProductoToolStripMenuItem.Name = "ventaDeProductoToolStripMenuItem";
            this.ventaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.ventaDeProductoToolStripMenuItem.Text = "Venta de Producto/Servicio";
            this.ventaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.ventaDeProductoToolStripMenuItem_Click);
            // 
            // pagoDeudaToolStripMenuItem
            // 
            this.pagoDeudaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pagoDeudaToolStripMenuItem.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Bold);
            this.pagoDeudaToolStripMenuItem.ForeColor = System.Drawing.Color.LightGreen;
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
            // picbEXIT
            // 
            this.picbEXIT.BackColor = System.Drawing.Color.Transparent;
            this.picbEXIT.Image = ((System.Drawing.Image)(resources.GetObject("picbEXIT.Image")));
            this.picbEXIT.Location = new System.Drawing.Point(993, 12);
            this.picbEXIT.Name = "picbEXIT";
            this.picbEXIT.Size = new System.Drawing.Size(34, 36);
            this.picbEXIT.TabIndex = 62;
            this.picbEXIT.TabStop = false;
            this.picbEXIT.Click += new System.EventHandler(this.picbEXIT_Click);
            // 
            // picbMINIMIN
            // 
            this.picbMINIMIN.BackColor = System.Drawing.Color.Transparent;
            this.picbMINIMIN.Image = ((System.Drawing.Image)(resources.GetObject("picbMINIMIN.Image")));
            this.picbMINIMIN.Location = new System.Drawing.Point(953, 12);
            this.picbMINIMIN.Name = "picbMINIMIN";
            this.picbMINIMIN.Size = new System.Drawing.Size(34, 36);
            this.picbMINIMIN.TabIndex = 61;
            this.picbMINIMIN.TabStop = false;
            this.picbMINIMIN.Click += new System.EventHandler(this.picbMINIMIN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(386, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "MUNICIPIO";
            // 
            // txtMUNICIPIO
            // 
            this.txtMUNICIPIO.Location = new System.Drawing.Point(466, 274);
            this.txtMUNICIPIO.Name = "txtMUNICIPIO";
            this.txtMUNICIPIO.Size = new System.Drawing.Size(225, 20);
            this.txtMUNICIPIO.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(352, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "DEPARTAMENTO";
            // 
            // txtDEPART
            // 
            this.txtDEPART.Location = new System.Drawing.Point(466, 238);
            this.txtDEPART.MaxLength = 25;
            this.txtDEPART.Name = "txtDEPART";
            this.txtDEPART.Size = new System.Drawing.Size(225, 20);
            this.txtDEPART.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(424, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "NIT";
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(466, 208);
            this.txtNIT.MaxLength = 20;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(82, 20);
            this.txtNIT.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(347, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "NOMBRE CLIENTE";
            // 
            // txtNombClie
            // 
            this.txtNombClie.Location = new System.Drawing.Point(466, 179);
            this.txtNombClie.MaxLength = 50;
            this.txtNombClie.Name = "txtNombClie";
            this.txtNombClie.Size = new System.Drawing.Size(225, 20);
            this.txtNombClie.TabIndex = 63;
            // 
            // btnBUSCARCLIE
            // 
            this.btnBUSCARCLIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBUSCARCLIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBUSCARCLIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCARCLIE.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBUSCARCLIE.Location = new System.Drawing.Point(466, 300);
            this.btnBUSCARCLIE.Name = "btnBUSCARCLIE";
            this.btnBUSCARCLIE.Size = new System.Drawing.Size(112, 40);
            this.btnBUSCARCLIE.TabIndex = 71;
            this.btnBUSCARCLIE.Text = "BUSCAR";
            this.btnBUSCARCLIE.UseVisualStyleBackColor = false;
            this.btnBUSCARCLIE.Click += new System.EventHandler(this.btnBUSCARCLIE_Click);
            // 
            // btnPAGARAnticipo
            // 
            this.btnPAGARAnticipo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPAGARAnticipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAGARAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAGARAnticipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPAGARAnticipo.Location = new System.Drawing.Point(466, 637);
            this.btnPAGARAnticipo.Name = "btnPAGARAnticipo";
            this.btnPAGARAnticipo.Size = new System.Drawing.Size(112, 40);
            this.btnPAGARAnticipo.TabIndex = 72;
            this.btnPAGARAnticipo.Text = "PAGAR";
            this.btnPAGARAnticipo.UseVisualStyleBackColor = false;
            this.btnPAGARAnticipo.Click += new System.EventHandler(this.btnPAGARAnticipo_Click);
            // 
            // liviDeudaClie
            // 
            this.liviDeudaClie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CLIENTE,
            this.ANTICIPO,
            this.FALTANTE,
            this.TOTAL,
            this.FECHA,
            this.HORA});
            this.liviDeudaClie.FullRowSelect = true;
            this.liviDeudaClie.Location = new System.Drawing.Point(306, 361);
            this.liviDeudaClie.Name = "liviDeudaClie";
            this.liviDeudaClie.Size = new System.Drawing.Size(721, 205);
            this.liviDeudaClie.TabIndex = 73;
            this.liviDeudaClie.UseCompatibleStateImageBehavior = false;
            this.liviDeudaClie.View = System.Windows.Forms.View.Details;
            // 
            // CLIENTE
            // 
            this.CLIENTE.Text = "CLIENTE";
            this.CLIENTE.Width = 300;
            // 
            // ANTICIPO
            // 
            this.ANTICIPO.Text = "ANTICIPO";
            this.ANTICIPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ANTICIPO.Width = 70;
            // 
            // FALTANTE
            // 
            this.FALTANTE.Text = "FALTANTE";
            this.FALTANTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FALTANTE.Width = 79;
            // 
            // TOTAL
            // 
            this.TOTAL.Text = "TOTAL";
            this.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FECHA
            // 
            this.FECHA.Text = "FECHA VENTA";
            this.FECHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FECHA.Width = 100;
            // 
            // HORA
            // 
            this.HORA.Text = "HORA VENTA";
            this.HORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HORA.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "CODIFICAR 2 TABLAS, LA TABLA DE ANTICIPOS Y LA TABLA DE VENTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(357, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "INGRESO ANTICIPO ";
            // 
            // txtIngAnticipo
            // 
            this.txtIngAnticipo.Enabled = false;
            this.txtIngAnticipo.Location = new System.Drawing.Point(475, 604);
            this.txtIngAnticipo.MaxLength = 20;
            this.txtIngAnticipo.Name = "txtIngAnticipo";
            this.txtIngAnticipo.ReadOnly = true;
            this.txtIngAnticipo.Size = new System.Drawing.Size(82, 20);
            this.txtIngAnticipo.TabIndex = 75;
            this.txtIngAnticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngAnticipo_KeyPress);
            // 
            // btnBorrarLinea
            // 
            this.btnBorrarLinea.BackColor = System.Drawing.Color.DarkRed;
            this.btnBorrarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarLinea.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrarLinea.Location = new System.Drawing.Point(620, 300);
            this.btnBorrarLinea.Name = "btnBorrarLinea";
            this.btnBorrarLinea.Size = new System.Drawing.Size(112, 40);
            this.btnBorrarLinea.TabIndex = 77;
            this.btnBorrarLinea.Text = "BORRAR LINEA";
            this.btnBorrarLinea.UseVisualStyleBackColor = false;
            this.btnBorrarLinea.Click += new System.EventHandler(this.btnBorrarLinea_Click);
            // 
            // chkIngAnticipo
            // 
            this.chkIngAnticipo.AutoSize = true;
            this.chkIngAnticipo.Location = new System.Drawing.Point(584, 606);
            this.chkIngAnticipo.Name = "chkIngAnticipo";
            this.chkIngAnticipo.Size = new System.Drawing.Size(135, 17);
            this.chkIngAnticipo.TabIndex = 78;
            this.chkIngAnticipo.Text = "INGRESAR ANTICIPO";
            this.chkIngAnticipo.UseVisualStyleBackColor = true;
            this.chkIngAnticipo.CheckedChanged += new System.EventHandler(this.chkIngAnticipo_CheckedChanged);
            // 
            // PAGOANTICIPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1039, 731);
            this.Controls.Add(this.chkIngAnticipo);
            this.Controls.Add(this.btnBorrarLinea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIngAnticipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liviDeudaClie);
            this.Controls.Add(this.btnPAGARAnticipo);
            this.Controls.Add(this.btnBUSCARCLIE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMUNICIPIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDEPART);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombClie);
            this.Controls.Add(this.picbEXIT);
            this.Controls.Add(this.picbMINIMIN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PAGOANTICIPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PAGOANTICIPO";
            this.Load += new System.EventHandler(this.PAGOANTICIPO_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbMINIMIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regitroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoDeudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasPerdidasToolStripMenuItem;
        private System.Windows.Forms.PictureBox picbEXIT;
        private System.Windows.Forms.PictureBox picbMINIMIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMUNICIPIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDEPART;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombClie;
        private System.Windows.Forms.Button btnBUSCARCLIE;
        private System.Windows.Forms.Button btnPAGARAnticipo;
        private System.Windows.Forms.ListView liviDeudaClie;
        private System.Windows.Forms.ColumnHeader CLIENTE;
        private System.Windows.Forms.ColumnHeader ANTICIPO;
        private System.Windows.Forms.ColumnHeader FALTANTE;
        private System.Windows.Forms.ColumnHeader TOTAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngAnticipo;
        private System.Windows.Forms.Button btnBorrarLinea;
        private System.Windows.Forms.ColumnHeader FECHA;
        private System.Windows.Forms.ColumnHeader HORA;
        private System.Windows.Forms.CheckBox chkIngAnticipo;
    }
}