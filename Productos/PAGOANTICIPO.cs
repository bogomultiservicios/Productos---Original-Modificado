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
    public partial class PAGOANTICIPO : Form
    {
        private Model1 DB = new Model1();
        public PAGOANTICIPO()
        {
            InitializeComponent();
        }

        private void LlenarDatosCliente(int IdCliente,string NombClieDeuda)
        {
            Decimal FaltanteOP = 0;
            var FECHAVENTAG = ""; DateTime HORAVENTAG;
            try
            {
                var busqDeudaClie = from deuda in DB.VENTAs
                                    where deuda.CodCliente==IdCliente &&
                                          deuda.ESTLIN == "ACTIVO"
                                    select deuda;

                foreach (var DeudaClie in busqDeudaClie)
                {
                    FaltanteOP =Convert.ToDecimal( DeudaClie.CANTPAGAR) - Convert.ToDecimal( DeudaClie.ANTICIPO);
                    HORAVENTAG = Convert.ToDateTime(DeudaClie.HORAVENTA.ToString());
                    ListViewItem DeudaClieList = new ListViewItem(NombClieDeuda);
                    DeudaClieList.SubItems.Add(Convert.ToString(DeudaClie.ANTICIPO));
                    DeudaClieList.SubItems.Add(Convert.ToString(FaltanteOP));
                    DeudaClieList.SubItems.Add(DeudaClie.CANTPAGAR.ToString());
                    DeudaClieList.SubItems.Add(Convert.ToDateTime(DeudaClie.FECHAVENTA).ToString("MM/dd/yyyy"));
                    DeudaClieList.SubItems.Add(HORAVENTAG.ToShortTimeString());
                    liviDeudaClie.Items.Add(DeudaClieList);

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error en base de datos, consulte con su Técnico " + a, "ERROR DBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void pagoDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////PAGOANTICIPO AnticipoVen = new PAGOANTICIPO();
            //AnticipoVen.Show();
            //this.Hide();
            MessageBox.Show("Esta sección solo esta abierta para versión de pago y no para la versión Gratuita", "ERROR DE SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gananciasPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REPORGANAPERDI GANPER = new REPORGANAPERDI();
            //GANPER.Show();
            //this.Hide();
            MessageBox.Show("Esta sección solo esta abierta para versión de pago y no para la versión Gratuita", "ERROR DE SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picbEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbMINIMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PAGOANTICIPO_Load(object sender, EventArgs e)
        {

        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGPRODSERV2 Registro = new REGPRODSERV2();
            Registro.Show();
            this.Hide();
        }

        private void btnBUSCARCLIE_Click(object sender, EventArgs e)
        {
            var clieBarriG = ""; var clieDirecG = "";
            var idCliente = 0; var clieTelG = "";
            var NITClie = ""; var clieDeptoG = "";
            /*var CodClieDeuda = 0;*/ var clieMunicipG = "";
            
            //var BusqClie = DB.PROSECLIEs.Where(b => b.NOMBRE == txtNombClie.Text ||  b.NIT=txtNIT.Text);
            var BusqClie = from clie in DB.PROSECLIEs
                           where clie.NOMBRE == txtNombClie.Text && clie.NIT==txtNIT.Text && clie.ESTLIN == "ACTIVO"
                           select clie;
            foreach (var ClieBarri in BusqClie)
            {
                idCliente = ClieBarri.CodCliente;
                clieBarriG = ClieBarri.NOMBRE;
                clieDirecG = ClieBarri.DIRECCION;
                NITClie = ClieBarri.NIT;
                clieTelG = ClieBarri.TELEFONO;
                clieDeptoG = ClieBarri.DEPARTAMENTO;
                clieMunicipG = ClieBarri.MUNICIPIO;


            }

            if ((txtNIT.Text == "") || (txtNombClie.Text == ""))
            {
                MessageBox.Show("Verifique que los campos NOMBRE y NIT esten llenos","ERROR EN CAMPOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (clieBarriG.Trim() == txtNombClie.Text.Trim())
            {
                //colocar aqui si tiene =deuda o no
                
                MessageBox.Show("Cliente Encontrado","DATOS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtNIT.Text = NITClie;
                txtDEPART.Text = clieDeptoG;
                txtMUNICIPIO.Text = clieMunicipG;
                this.LlenarDatosCliente(idCliente, txtNombClie.Text);

            }
            else
            {
                MessageBox.Show("No Se encontro Cliente","DATOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNIT.Text = "";
                txtDEPART.Text = "";
                txtMUNICIPIO.Text = "";
            }

            
            //var BusqClieDeuda = DB.ANTICIPOes.Where(b => b.CodCliente == idCliente && b.ESTLIN == "ACTIVO");
            //foreach (var AnticipoBarri in BusqClieDeuda)
            //{
            //    CodClieDeuda = (int)AnticipoBarri.CodCliente;
            //}
            //if (CodClieDeuda != 0)
            //{
            //    MessageBox.Show("CLIENTE POSEE DEUDA", "DEUDOR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
        }

        private void btnBorrarLinea_Click(object sender, EventArgs e)
        {

        }

        private void btnPAGARAnticipo_Click(object sender, EventArgs e)
        {

            var clieBarriG = ""; var clieDirecG = "";
            var idCliente = 0; var clieTelG = "";
            var NITClie = ""; var clieDeptoG = "";
            /*var CodClieDeuda = 0;*/
            var clieMunicipG = "";

            //var BusqClie = DB.PROSECLIEs.Where(b => b.NOMBRE == txtNombClie.Text ||  b.NIT=txtNIT.Text);
            var BusqClie = from clie in DB.PROSECLIEs
                           where clie.NOMBRE == txtNombClie.Text && clie.NIT == txtNIT.Text && clie.ESTLIN == "ACTIVO"
                           select clie;
            foreach (var ClieBarri in BusqClie)
            {
                idCliente = ClieBarri.CodCliente;
                clieBarriG = ClieBarri.NOMBRE;
                clieDirecG = ClieBarri.DIRECCION;
                NITClie = ClieBarri.NIT;
                clieTelG = ClieBarri.TELEFONO;
                clieDeptoG = ClieBarri.DEPARTAMENTO;
                clieMunicipG = ClieBarri.MUNICIPIO;
            }


            //Valida si se paga totalmente la deuda o solo se ingresa anticipo
            ANTICIPO IngAnticipo = new ANTICIPO();
            VENTA ModifVenta = new VENTA();
            //this.LlenarDatosCliente(idCliente, txtNombClie.Text);
            var busqDeudaClie = from deuda in DB.VENTAs
                                where deuda.CodCliente == idCliente  &&
                                      deuda.ESTLIN == "ACTIVO"
                                select deuda;

            foreach (var DeudaClie in busqDeudaClie)
            {
                //FaltanteOP = Convert.ToDecimal(DeudaClie.CANTPAGAR) - Convert.ToDecimal(DeudaClie.ANTICIPO);
                //HORAVENTAG = Convert.ToDateTime(DeudaClie.HORAVENTA.ToString());
                //ListViewItem DeudaClieList = new ListViewItem(NombClieDeuda);
                //DeudaClieList.SubItems.Add(Convert.ToString(DeudaClie.ANTICIPO));
                //DeudaClieList.SubItems.Add(Convert.ToString(FaltanteOP));
                //DeudaClieList.SubItems.Add(DeudaClie.CANTPAGAR.ToString());
                //DeudaClieList.SubItems.Add(Convert.ToDateTime(DeudaClie.FECHAVENTA).ToString("MM/dd/yyyy"));
                //DeudaClieList.SubItems.Add(HORAVENTAG.ToShortTimeString());
                //liviDeudaClie.Items.Add(DeudaClieList);

            }
            if (chkIngAnticipo.Checked == true)
            {
               // IngAnticipo.CANTANTICIPO
            }
            else
            {

            }
        }

        private void chkIngAnticipo_CheckedChanged(object sender, EventArgs e)
        {
            //Valida si se apertura el ingreso de anticipo
            if (chkIngAnticipo.Checked == true)
            {
                txtIngAnticipo.ReadOnly = false;
                txtIngAnticipo.Enabled = true;
            }
            else
            {
                txtIngAnticipo.Text = "";
                txtIngAnticipo.ReadOnly = true;
                txtIngAnticipo.Enabled = false;
            }
        }

        private void txtIngAnticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion para solo escribir Decimales
            if (Char.IsLetter(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
