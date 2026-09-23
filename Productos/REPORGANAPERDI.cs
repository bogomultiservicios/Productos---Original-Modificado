using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.DATA;

namespace Productos
{
    public partial class REPORGANAPERDI : Form
    {
        private Model1 DB = new Model1();
        public REPORGANAPERDI()
        {
            InitializeComponent();
        }

        private void pagoDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PAGOANTICIPO AnticipoVen = new PAGOANTICIPO();
            //AnticipoVen.Show();
            this.Hide();
        }

        private void ventaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VENTAS VENTA = new VENTAS();
            VENTA.Show();
            this.Hide();
        }

        private void regitroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGPRODSERV2 Registro = new REGPRODSERV2();
            Registro.Show();
            this.Hide();
        }

        private void gananciasPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REPORGANAPERDI GANPER = new REPORGANAPERDI();
            GANPER.Show();
            this.Hide();
        }

        private void picbEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbMINIMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void REPORGANAPERDI_Load(object sender, EventArgs e)
        {

        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGPRODSERV2 Registro = new REGPRODSERV2();
            Registro.Show();
            this.Hide();
        }
    }
}
