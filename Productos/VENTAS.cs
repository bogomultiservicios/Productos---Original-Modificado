using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.DATA;

namespace Productos
{
    public partial class VENTAS : Form
    {
        private Model1 DB = new Model1();
        
        public VENTAS()
        {
            InitializeComponent();
        }
        
        private void LlenarDatos()
        {
            liviPRODUSERV.Items.Clear();
            try
            {
                var busqProduList = from ProduList in DB.PROSERVLISTs
                                    where ProduList.PRODUCTO_SERVICIO.Contains(txtBUSQPROSERV.Text) &&
                                          ProduList.ESTLIN == "ACTIVO"
                                    select ProduList;
                foreach (var itemProduServ in busqProduList)
                {
                    ListViewItem listProduServ = new ListViewItem(itemProduServ.PRODUCTO_SERVICIO.ToString());
                    listProduServ.SubItems.Add(itemProduServ.PRECIO.ToString());
                    listProduServ.SubItems.Add(itemProduServ.CLASIFICACION.ToString());
                    listProduServ.SubItems.Add(itemProduServ.STOCK.ToString());
                    liviPRODUSERV.Items.Add(listProduServ);

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error en base de datos, consulte con su Técnico " + a, "ERROR DBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picbMINIMIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picbEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regitroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGPRODSERV2 Registro = new REGPRODSERV2();
            Registro.Show();
            this.Hide();
        }

        private void ventaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VENTAS VENTA = new VENTAS();
            VENTA.Show();
            this.Hide();
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pATRIARCADataSet2.PROSERVLIST' table. You can move, or remove it, as needed.
            this.pROSERVLISTTableAdapter.Fill(this.pATRIARCADataSet2.PROSERVLIST);

        }

        private void pagoDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PAGOANTICIPO AnticipoVen = new PAGOANTICIPO();
            //AnticipoVen.Show();
            //this.Hide();
            MessageBox.Show("Esta sección solo esta abierta para versión de pago y no para la versión Gratuita","ERROR DE SELECCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void gananciasPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REPORGANAPERDI GANPER = new REPORGANAPERDI();
            //GANPER.Show();
            //this.Hide();
            MessageBox.Show("Esta sección solo esta abierta para versión de pago y no para la versión Gratuita", "ERROR DE SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void liViCOMPRAS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAnticipo.Checked == true)
            //{
            //    // Se activa boton Anticipo y se bloquea el boton de PAGO
            //    btnANTICIPO.Enabled = true;
            //    btnPAGAR.Enabled = false;
            //    // SE DESBLOQUEA EL TEXBOX DE ANTICIPO
            //    txtANTICIPO.Enabled = true;
            //    txtANTICIPO.ReadOnly = false;

            //}
            //else
            //{
            //    btnANTICIPO.Enabled = false;
            //    btnPAGAR.Enabled = true;
            //}
        }

        private void dtgvLISTAPROSERV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTOTAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnANTICIPO_Click(object sender, EventArgs e)
        {
            Int32 IDcliente = 0, CantProdServVen = 0, IDVENTA = 0;

            //Se llama al modulo de VENTA
            VENTA FACTURA = new VENTA();
            //Se llama al modulo de Listado de Producos/Servicos Vendidos(LISTPRODUSERVVEN)
            LISTPRODUSERVVEN ListVenClie = new LISTPRODUSERVVEN();

            //Se llama al modulo de ANTICIPO para crear una deuda
            ANTICIPO Deuda = new ANTICIPO();

            try
            {
                var busqCliente = DB.PROSECLIEs.Where(clie => clie.NOMBRE == txtNombClie.Text && clie.NIT == txtNIT.Text && clie.ESTLIN == "ACTIVO");
                foreach (var ClieEncont in busqCliente)
                {
                    IDcliente = ClieEncont.CodCliente;
                }
                foreach (ListViewItem contar in liViCOMPRAS.Items)
                {
                    CantProdServVen += Convert.ToInt32(contar.SubItems[2].Text);
                }



                FACTURA.ESTLIN = "ACTIVO";
                FACTURA.PRODUCTO_SERVICIO = liViCOMPRAS.Items.Count;
                FACTURA.FECHAVENTA = DateTime.Now.Date.ToString("dd/mm/YYYY");
                FACTURA.PRECIO = Convert.ToDecimal(txtTOTAL.Text);
                FACTURA.CANTIDAD = CantProdServVen;
                FACTURA.HORAVENTA = DateTime.Now.TimeOfDay;
                FACTURA.CodCliente = IDcliente;
                FACTURA.ANTICIPO = Convert.ToDecimal(txtANTICIPO.Text);
                FACTURA.CANTPAGAR = Convert.ToDecimal(txtTOTAL.Text);
                FACTURA.ESTPAGO = "DEUDA";
                DB.VENTAs.Add(FACTURA);
                DB.SaveChanges();

                Deuda.ESTLIN= "ACTIVO";
                Deuda.CANTANTICIPO = FACTURA.ANTICIPO;
                Deuda.CodCliente = IDcliente;
                Deuda.PORCENTANTICIPO= (Convert.ToDecimal(txtANTICIPO.Text)*100)/ Convert.ToDecimal(txtTOTAL.Text);
                DB.ANTICIPOes.Add(Deuda);
                DB.SaveChanges();

                var busVenta = DB.VENTAs.Where(ventaClie => ventaClie.CodCliente == IDcliente &&
                                                ventaClie.ESTPAGO == "DEUDA" &&
                                                ventaClie.FECHAVENTA == FACTURA.FECHAVENTA &&
                                                ventaClie.HORAVENTA == FACTURA.HORAVENTA &&
                                                ventaClie.ESTLIN == "ACTIVO");
                foreach (var BusqVentaCod in busVenta)
                {
                    IDVENTA = BusqVentaCod.CODVENTA;
                }
                if (IDVENTA == 0)
                {
                    MessageBox.Show("Error: No se ha encontrado la factura en Base de datos, consulte con su técnico","ERROR BASE DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    foreach (ListViewItem Venta in liViCOMPRAS.Items)
                    {
                        ListVenClie.PRODUCTO_SERVICIO = Venta.SubItems[0].Text;
                        ListVenClie.CODVENTA = IDVENTA;
                        ListVenClie.PRECIO_PRODUCTO = Convert.ToDecimal(Venta.SubItems[1].Text);
                        ListVenClie.CANTIDAD_SOLICITADA = Convert.ToInt32(Venta.SubItems[2].Text);
                        ListVenClie.FECHAVENTA = FACTURA.FECHAVENTA;
                        ListVenClie.HORAVENTA = FACTURA.HORAVENTA;
                        ListVenClie.CODCLIENTE = IDcliente;
                        ListVenClie.SubTotProduServ = Convert.ToDecimal(Venta.SubItems[1].Text) * Convert.ToInt32(Venta.SubItems[2].Text);
                        ListVenClie.ESTLIN = "ACTIVO";
                        DB.LISTPRODUSERVVENs.Add(ListVenClie);
                        DB.SaveChanges();
                        Venta.Remove();
                    }

                    txtTOTAL.Text = "0";
                    txtANTICIPO.Text = "0";
                    lblResulVenMSJ.Text = "Factura Guardada Exitosamente";
                    lblResulVenMSJ.ForeColor = Color.Green;
                    lblResulVenMSJ.Visible = true;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error DBA. " + a, "ERROR EN BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPAGAR_Click(object sender, EventArgs e)
        {
            Int32 IDcliente = 0,CantProdServVen=0,IDVENTA=0;
            
            //Se llama al modulo de VENTA
            VENTA FACTURA = new VENTA();
            //Se llama al modulo de Listado de Producos/Servicos Vendidos(LISTPRODUSERVVEN)
            LISTPRODUSERVVEN ListVenClie = new LISTPRODUSERVVEN();

            try
            { 
                var busqCliente = DB.PROSECLIEs.Where(clie=> clie.NOMBRE==txtNombClie.Text && clie.NIT==txtNIT.Text && clie.ESTLIN=="ACTIVO");
                foreach (var ClieEncont in busqCliente)
                {
                    IDcliente = ClieEncont.CodCliente;
                }
                foreach (ListViewItem contar in liViCOMPRAS.Items)
                {
                    CantProdServVen += Convert.ToInt32(contar.SubItems[2].Text);
                }

                
                
                FACTURA.ESTLIN = "ACTIVO";
                FACTURA.PRODUCTO_SERVICIO = liViCOMPRAS.Items.Count;
                FACTURA.FECHAVENTA =DateTime.Now.Date.ToString("dd/MM/yyyy");
                FACTURA.PRECIO = Convert.ToDecimal(txtTOTAL.Text);
                FACTURA.CANTIDAD = CantProdServVen;
                FACTURA.HORAVENTA = DateTime.Now.TimeOfDay;
                FACTURA.CodCliente = IDcliente;
                FACTURA.ANTICIPO = Convert.ToDecimal(txtANTICIPO.Text);
                FACTURA.CANTPAGAR = Convert.ToDecimal(txtTOTAL.Text);
                FACTURA.ESTPAGO = "CANCELADO";
                DB.VENTAs.Add(FACTURA);
                DB.SaveChanges();

                
                var busVenta = DB.VENTAs.Where(ventaClie => ventaClie.CodCliente == IDcliente &&
                                                ventaClie.ESTPAGO == "CANCELADO" &&
                                                ventaClie.FECHAVENTA == FACTURA.FECHAVENTA &&
                                                ventaClie.HORAVENTA == FACTURA.HORAVENTA &&
                                                ventaClie.ESTLIN == "ACTIVO");
                foreach (var BusqVentaCod in busVenta)
                {
                    IDVENTA = BusqVentaCod.CODVENTA;
                }


                 foreach (ListViewItem Venta in liViCOMPRAS.Items)
                 {
                     ListVenClie.PRODUCTO_SERVICIO = Venta.SubItems[0].Text;
                     ListVenClie.CODVENTA = IDVENTA;
                     ListVenClie.PRECIO_PRODUCTO = Convert.ToDecimal(Venta.SubItems[1].Text);
                     ListVenClie.CANTIDAD_SOLICITADA = Convert.ToInt32(Venta.SubItems[2].Text);
                     ListVenClie.FECHAVENTA = FACTURA.FECHAVENTA;
                     ListVenClie.HORAVENTA = FACTURA.HORAVENTA;
                     ListVenClie.CODCLIENTE = IDcliente;
                     ListVenClie.SubTotProduServ = Convert.ToDecimal(Venta.SubItems[1].Text) * Convert.ToInt32(Venta.SubItems[2].Text);
                     ListVenClie.ESTLIN = "ACTIVO";
                     DB.LISTPRODUSERVVENs.Add(ListVenClie);
                     DB.SaveChanges();
                     Venta.Remove();
                 }
                txtTOTAL.Text = "0";
                txtANTICIPO.Text = "0";
                lblResulVenMSJ.Text = "¡Factura Guardada y \nPagada Exitosamente!";
                lblResulVenMSJ.ForeColor = Color.Green;
                lblResulVenMSJ.Visible = true;

            }
            catch(Exception a)
            {
                MessageBox.Show("Error DBA. "+ a,"ERROR EN BASE DE DATOS",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnBORRARLINEA_Click(object sender, EventArgs e)
        {
            double CalcLinBorrada=0, DisminTotal=0;
            Int32 IDProduServ = 0, CalcStock = 0;      
            int CodProServ = 0; 
            string DBProducto="", ClasifProduServ="", NombProduPrueba="";
            bool ESTAPRODUSERVE;
            DisminTotal = Convert.ToDouble(txtTOTAL.Text);
            //REMUEVE LA LINEA O LAS LINEAS SELECCIONADAS DEL LISTVIEW
            foreach (ListViewItem lista in liViCOMPRAS.SelectedItems)
            {
                //BUSCA EL PRODUCTO QUE SE VA A ACTUALIZAR
                string NombProduServ = lista.SubItems[0].Text;
           
                var busqLista = DB.PROSERVLISTs.Where(B => B.PRODUCTO_SERVICIO == NombProduServ && B.ESTLIN == "ACTIVO");
                foreach(var RecorreLista in busqLista)
                {
                    //NombProduPrueba = RecorreLista.PRODUCTO_SERVICIO;
                    CodProServ = RecorreLista.CODPROSERVLIST;
                    ClasifProduServ = RecorreLista.CLASIFICACION;
                }
                if (ClasifProduServ == "PRODUCTO")
                {
                    var BusqProdu = DB.PRODUCTOes.Where(b => b.PRODUCTO1 == NombProduServ && b.ESTLIN == "ACTIVO");
                    //RECORRE LOS DATOS ENCONTRADOS Y ASIGNA VALORES A LAS VARIABLES


                    foreach (var ProduMod in BusqProdu)
                    {
                        IDProduServ = ProduMod.CODPRODUCTO;
                        DBProducto = ProduMod.PRODUCTO1;
                        CalcStock = Convert.ToInt32(ProduMod.STOCK);
                    }
                    //Calculo para devolución a Stock en el DBA
                    CalcStock = CalcStock + Convert.ToInt32(lista.SubItems[2].Text);

                    //BUSCA EL ID DEL PRODUCTO Y REALIZA LA ACTUALIZACION CON EL NUEVO CALCULO
                    var producto = DB.PRODUCTOes.Find(IDProduServ);
                    producto.ESTLIN = "ACTIVO";
                    producto.STOCK = CalcStock;

                   

                }
               else
                {

                }
            
                       
                //ACTUALIZA LA BASE DE DATOS EN EL CAMPO ESTLIN Y STOCK
                PROSERVLIST listaModif = DB.PROSERVLISTs.Find(CodProServ);
                listaModif.ESTLIN = "ACTIVO";
                if(ClasifProduServ=="PRODUCTO")
                {
                    listaModif.STOCK = CalcStock;
                }
                else
                {
                    listaModif.STOCK = 0;
                }
                DB.Entry(listaModif).State = EntityState.Modified;
                DB.SaveChanges();


                //Calcula los datos de la lista por cada linea seleccionada y la borra
                CalcLinBorrada = CalcLinBorrada + (Convert.ToDouble(lista.SubItems[1].Text)* Convert.ToDouble(lista.SubItems[2].Text));
                //BORRA LA LINEA SECCIONADA
                lista.Remove();
            }
            //Calcula el campo total y manda el nuevo total a el campo txtTOTAL.Text
            DisminTotal = DisminTotal-CalcLinBorrada ;
            txtTOTAL.Text = DisminTotal.ToString();

            //LLena el listView de Productos y Servicios con Datos
            this.LlenarDatos();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtNombClie_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGPRODSERV2 Registro = new REGPRODSERV2();
            Registro.Show();
            this.Hide();
        }

        private void btnAGREGARCLIENTE_Click(object sender, EventArgs e)
        {
            PROSECLIE cliente = new PROSECLIE();
            try
            {
                cliente.ESTLIN = "ACTIVO";
                cliente.NOMBRE = txtNombClie.Text;
                cliente.DIRECCION = txtDIREC.Text;
                cliente.NIT = txtNIT.Text;
                cliente.TELEFONO = txtTEL.Text;
                cliente.DEPARTAMENTO = txtDEPART.Text;
                cliente.MUNICIPIO = txtMUNICIPIO.Text;
                DB.PROSECLIEs.Add(cliente);

                DB.SaveChanges();
                lblResulVenMSJ.Text = "CLIENTE GUARDADO EXITOSAMENTE";
                lblResulVenMSJ.ForeColor = Color.Green;
                lblResulVenMSJ.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: Datos no guardados. " + a);

                lblResulVenMSJ.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                lblResulVenMSJ.ForeColor = Color.Red;
                lblResulVenMSJ.Visible = true;
            }
            
        }

        private void txtNombClie_ENTER(object sender, EventArgs e)
        {
           
        }

        private void txtNombClie_DoubleClick(object sender, EventArgs e)
        {
            var clieBarriG = ""; var clieDirecG = "";            var idCliente = 0;  var clieTelG = "";
            var NITClie = "";    var clieDeptoG = "";
            var CodClieDeuda=0;  var clieMunicipG = "";
            //var BusqClie = DB.PROSECLIEs.Where(b => b.NOMBRE == txtNombClie.Text ||  b.NIT=txtNIT.Text);
            var BusqClie = from clie in DB.PROSECLIEs where clie.NOMBRE == txtNombClie.Text && clie.ESTLIN=="ACTIVO"
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

            if (clieBarriG.Trim() == txtNombClie.Text.Trim())
            {
                //colocar aqui si tiene =deuda o no
                btnAGREGARCLIENTE.Visible = false;
                MessageBox.Show("Cliente Encontrado");
                txtNIT.Text = NITClie;
                txtDIREC.Text = clieDirecG;
                txtTEL.Text = clieTelG;
                txtDEPART.Text = clieDeptoG;
                txtMUNICIPIO.Text = clieMunicipG;

            }
            else
            {

                btnAGREGARCLIENTE.Visible = true;
                txtNIT.Text = "";
                txtDIREC.Text = "";
                txtTEL.Text = "";
                txtDEPART.Text = "";
                txtMUNICIPIO.Text = "";
            }

            var BusqClieDeuda = DB.ANTICIPOes.Where(b => b.CodCliente == idCliente && b.ESTLIN == "ACTIVO");
            foreach (var AnticipoBarri in BusqClieDeuda)
            {
                CodClieDeuda =(int) AnticipoBarri.CodCliente;
            }
            if (CodClieDeuda != 0)
            {
                MessageBox.Show("CLIENTE POSEE DEUDA","DEUDOR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnAGREGPRODSERV_Click(object sender, EventArgs e)
        {


            double Calculo = 0, CantDescuento = 0;
            int cantProduServ, CalcStock = 0, IDProduServ = 0;
            string DBProducto = "";
            
            foreach (ListViewItem ProdView in liviPRODUSERV.SelectedItems)
            {
                if ((ProdView.SubItems[2].Text == "PRODUCTO") &&
                    (ProdView.SubItems[3].Text == "0"))
                {
                    MessageBox.Show("PRODUCTO AGOTADO", "ERROR STOCK", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if ((Convert.ToInt32(txtCantProdServ.Text) > Convert.ToInt32(ProdView.SubItems[3].Text)) &&
                            (ProdView.SubItems[2].Text == "PRODUCTO"))
                    {
                        MessageBox.Show("CANTIDAD SOBREPASA A PRODUCTO ALMACENADO", "ERROR STOCK", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (txtTOTAL.Text == "")
                        {
                            Calculo = 0;
                        }
                        else
                        {
                            Calculo = Convert.ToDouble(txtTOTAL.Text);
                        }

                        if (txtCantProdServ.Text == "")
                        {
                            cantProduServ = 0;
                        }
                        else
                        {
                            cantProduServ = Convert.ToInt32(txtCantProdServ.Text);
                        }

                        CalcStock = Convert.ToInt32(ProdView.SubItems[3].Text) - cantProduServ;

                        //PRODUCTO producto = DB.PRODUCTOes.Find(dtgvLISTAPROSERV.CurrentRow.Cells[0].Value);
                        string NombProduServ = ProdView.SubItems[0].Text;
                        if ((ProdView.SubItems[2].Text == "PRODUCTO") ||
                           (ProdView.SubItems[2].Text == "Producto") ||
                           (ProdView.SubItems[2].Text == "producto"))
                        {
                            var BusqProdu = DB.PRODUCTOes.Where(b => b.PRODUCTO1 == NombProduServ && b.ESTLIN == "ACTIVO");
                            foreach (var ProduMod in BusqProdu)
                            {
                                IDProduServ = ProduMod.CODPRODUCTO;
                                DBProducto = ProduMod.PRODUCTO1;
                            }
                        }


                        if ((ProdView.SubItems[2].Text == "SERVICIO") ||
                           (ProdView.SubItems[2].Text == "Servicio") ||
                           (ProdView.SubItems[2].Text == "servicio"))
                        {
                            var BusqProdu = DB.SERVICIOs.Where(b => b.SERVICIO1 == NombProduServ && b.ESTLIN == "ACTIVO");
                            foreach (var ServiMod in BusqProdu)
                            {
                                IDProduServ = ServiMod.CODIGOSERVICIO;
                                DBProducto = ServiMod.SERVICIO1;
                            }
                        }





                        if ((ProdView.SubItems[2].Text == "PRODUCTO") ||
                          (ProdView.SubItems[2].Text == "Producto") ||
                          (ProdView.SubItems[2].Text == "producto"))
                        {
                            var producto = DB.PRODUCTOes.Find(IDProduServ);
                            producto.ESTLIN = "ACTIVO";
                            producto.STOCK = CalcStock;
                        }

                        if ((ProdView.SubItems[2].Text == "SERVICIO") ||
                          (ProdView.SubItems[2].Text == "Servicio") ||
                          (ProdView.SubItems[2].Text == "servicio"))
                        {
                            var producto = DB.SERVICIOs.Find(IDProduServ);
                            producto.ESTLIN = "ACTIVO";
                            producto.CANTIDAD = 0;
                        }


                        int CodProServ = 0;

                        var listProdu = DB.PROSERVLISTs.Where(b => b.PRODUCTO_SERVICIO == DBProducto && b.ESTLIN == "ACTIVO");

                        foreach (var itemG in listProdu)
                        {
                            CodProServ = itemG.CODPROSERVLIST;
                        }

                        PROSERVLIST listaModif = DB.PROSERVLISTs.Find(CodProServ);
                        listaModif.ESTLIN = "ACTIVO";
                        if ((ProdView.SubItems[2].Text == "PRODUCTO") ||
                          (ProdView.SubItems[2].Text == "Producto") ||
                          (ProdView.SubItems[2].Text == "producto"))
                        {
                            listaModif.STOCK = CalcStock;
                        }
                        else
                        {
                            listaModif.STOCK = 0;
                        }

                        DB.Entry(listaModif).State = EntityState.Modified;
                        DB.SaveChanges();

                        ListViewItem listProduServ = new ListViewItem(ProdView.SubItems[0].Text);
                        listProduServ.SubItems.Add(ProdView.SubItems[1].Text);
                        listProduServ.SubItems.Add(txtCantProdServ.Text);//Cantidad de Productos o servicios
                        listProduServ.SubItems.Add("0");//Descuento 
                        listProduServ.SubItems.Add("0");// Precio con descuento aplicado
                        Calculo = Calculo + (Convert.ToDouble(ProdView.SubItems[1].Text) * cantProduServ);
                        txtTOTAL.Text = Calculo.ToString();
                        liViCOMPRAS.Items.Add(listProduServ);

                        //int contar = liViCOMPRAS.Items.Count;

                        if (Calculo >= 200)
                        {
                            txtDESCUENTO.Text = "5";
                            MessageBox.Show("SE APLICARA EL " + txtDESCUENTO.Text +"%" + " DE DESCUENTO", "DESCUENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CantDescuento = Convert.ToDouble(txtDESCUENTO.Text) / 100;
                            Calculo = 0;



                            foreach (ListViewItem lista in liViCOMPRAS.Items)
                            {
                                lista.SubItems[3].Text = txtDESCUENTO.Text + "%";//Descuento
                                double AplicarDescuento = Convert.ToDouble(lista.SubItems[1].Text) * CantDescuento;
                                double NuevoPrecio = Convert.ToDouble(lista.SubItems[1].Text) - AplicarDescuento;
                                lista.SubItems[4].Text = NuevoPrecio.ToString();
                                Calculo = Calculo + (NuevoPrecio * Convert.ToInt32(lista.SubItems[2].Text));


                            }

                            txtTOTAL.Text = Calculo.ToString();

                        }
                    }


                }//end if-else
            }
            //LLena el listView de Productos y Servicios con Datos
            this.LlenarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double CalcLinBorrada = 0, DisminTotal = 0;
            Int32 IDProduServ = 0, CalcStock = 0;
            string DBProducto = "";
            DisminTotal = Convert.ToDouble(txtTOTAL.Text);
            //REMUEVE LA LINEA O LAS LINEAS SELECCIONADAS DEL LISTVIEW
            foreach (ListViewItem lista in liViCOMPRAS.Items)
            {
                //BUSCA EL PRODUCTO QUE SE VA A ACTUALIZAR
                string NombProduServ = lista.SubItems[0].Text;
                var BusqProdu = DB.PRODUCTOes.Where(b => b.PRODUCTO1 == NombProduServ && b.ESTLIN == "ACTIVO");
                //RECORRE LOS DATOS ENCONTRADOS Y ASIGNA VALORES A LAS VARIABLES
                foreach (var ProduMod in BusqProdu)
                {
                    IDProduServ = ProduMod.CODPRODUCTO;
                    DBProducto = ProduMod.PRODUCTO1;
                    CalcStock = Convert.ToInt32(ProduMod.STOCK);
                }
                //Calculo para devolución a Stock en el DBA
                CalcStock = CalcStock + Convert.ToInt32(lista.SubItems[2].Text);

                //BUSCA EL ID DEL PRODUCTO Y REALIZA LA ACTUALIZACION CON EL NUEVO CALCULO
                var producto = DB.PRODUCTOes.Find(IDProduServ);
                producto.ESTLIN = "ACTIVO";
                producto.STOCK = CalcStock;

                int CodProServ = 0;
                //BUSCA EL PRODUCTO EN LA TABLA LISTA DE PRODUCTOS Y SERVICIOS
               var listProdu = DB.PROSERVLISTs.Where(b => b.PRODUCTO_SERVICIO == DBProducto && b.ESTLIN == "ACTIVO");
                foreach (var itemG in listProdu)
                {
                    CodProServ = itemG.CODPROSERVLIST;
                }

                //ACTUALIZA LA BASE DE DATOS EN EL CAMPO ESTLI Y STOCK
                PROSERVLIST listaModif = DB.PROSERVLISTs.Find(CodProServ);
                listaModif.ESTLIN = "ACTIVO";
                listaModif.STOCK = CalcStock;
                DB.Entry(listaModif).State = EntityState.Modified;
                DB.SaveChanges();


                //Calcula los datos de la lista por cada linea seleccionada y la borra
                CalcLinBorrada = CalcLinBorrada + (Convert.ToDouble(lista.SubItems[1].Text) * Convert.ToDouble(lista.SubItems[2].Text));
                //BORRA LA LINEA SECCIONADA
                lista.Remove();
            }
            //Calcula el campo total y manda el nuevo total a el campo txtTOTAL.Text
            DisminTotal = DisminTotal - CalcLinBorrada;
            txtTOTAL.Text = DisminTotal.ToString();

            //Limpieza de campos
            txtNombClie.Text = "";
            txtNIT.Text = "";
            txtDIREC.Text = "";
            txtTEL.Text = "";
            txtDEPART.Text = "";
            txtMUNICIPIO.Text = "";
            txtCantProdServ.Text = "";
            chkAnticipo.Checked = false;
            txtANTICIPO.Text = "0";
            btnANTICIPO.Enabled = false;
            lblResulVenMSJ.Visible = false;
            lblResulVenMSJ.ForeColor = Color.Black;
            lblResulVenMSJ.Text = "xxx";
            liviPRODUSERV.Items.Clear();
            txtBUSQPROSERV.Text = "";

           
        }

        private void txtBUSQPROSERV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    liviPRODUSERV.Items.Clear();
            //    var busqProduList = from ProduList in DB.PROSERVLISTs
            //                        where ProduList.PRODUCTO_SERVICIO.Contains( txtBUSQPROSERV.Text) &&
            //                              ProduList.ESTLIN == "ACTIVO"
            //                        select ProduList;
            //    foreach(var itemProduServ in busqProduList)
            //    {
            //        ListViewItem listProduServ = new ListViewItem(itemProduServ.PRODUCTO_SERVICIO.ToString());
            //        listProduServ.SubItems.Add(itemProduServ.PRECIO.ToString());
            //        listProduServ.SubItems.Add(itemProduServ.CLASIFICACION.ToString());
            //        listProduServ.SubItems.Add(itemProduServ.STOCK.ToString());
            //        liviPRODUSERV.Items.Add(listProduServ);

            //    }

            //}
            this.LlenarDatos();
        }

        private void txtBUSQPROSERV_TextChanged(object sender, EventArgs e)
        {
            //liviPRODUSERV.Items.Clear();
            //try
            //{
            //    var busqProduList = from ProduList in DB.PROSERVLISTs
            //                        where ProduList.PRODUCTO_SERVICIO.Contains(txtBUSQPROSERV.Text) &&
            //                              ProduList.ESTLIN == "ACTIVO"
            //                        select ProduList;
            //    foreach (var itemProduServ in busqProduList)
            //    {
            //        ListViewItem listProduServ = new ListViewItem(itemProduServ.PRODUCTO_SERVICIO.ToString());
            //        listProduServ.SubItems.Add(itemProduServ.PRECIO.ToString());
            //        listProduServ.SubItems.Add(itemProduServ.CLASIFICACION.ToString());
            //        listProduServ.SubItems.Add(itemProduServ.STOCK.ToString());
            //        liviPRODUSERV.Items.Add(listProduServ);

            //    }
            //}
            //catch(Exception a)
            //{
            //    MessageBox.Show("Error en base de datos, consulte con su Técnico "+ a,"ERROR DBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void liviPRODUSERV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNIT_DoubleClick(object sender, EventArgs e)
        {
            var clieBarriG = ""; var clieDirecG = ""; var idCliente = 0; var clieTelG = "";
            var NITClie = ""; var clieDeptoG = "";
            var CodClieDeuda = 0; var clieMunicipG = "";
            //var BusqClie = DB.PROSECLIEs.Where(b => b.NOMBRE == txtNombClie.Text ||  b.NIT=txtNIT.Text);
            var BusqClie = from clie in DB.PROSECLIEs
                           where clie.NIT == txtNIT.Text && clie.ESTLIN == "ACTIVO"
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

            if (NITClie.Trim() == txtNIT.Text.Trim())
            {
                //colocar aqui si tiene =deuda o no
                btnAGREGARCLIENTE.Visible = false;
                MessageBox.Show("Cliente Encontrado");
                txtNombClie.Text = clieBarriG;
                txtNIT.Text = NITClie;
                txtDIREC.Text = clieDirecG;
                txtTEL.Text = clieTelG;
                txtDEPART.Text = clieDeptoG;
                txtMUNICIPIO.Text = clieMunicipG;

            }
            else
            {

                btnAGREGARCLIENTE.Visible = true;
                txtNIT.Text = "";
                txtDIREC.Text = "";
                txtTEL.Text = "";
                txtDEPART.Text = "";
                txtMUNICIPIO.Text = "";
            }

            var BusqClieDeuda = DB.ANTICIPOes.Where(b => b.CodCliente == idCliente && b.ESTLIN == "ACTIVO");
            foreach (var AnticipoBarri in BusqClieDeuda)
            {
                CodClieDeuda = (int)AnticipoBarri.CodCliente;
            }
            if (CodClieDeuda != 0)
            {
                MessageBox.Show("CLIENTE POSEE DEUDA", "DEUDOR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtANTICIPO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantProdServ_KeyPress(object sender, KeyPressEventArgs e)
        {
           //Evalua que solo se puedan ingresar datos numericos
            if (Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnREPMENS_Click(object sender, EventArgs e)
        {
             String docPath= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String NomArchivo = "BOGO_" + DateTime.Now.Date.ToString("MM-yyyy")+".txt";
            String FechVeri = /*"09/2020";*/ DateTime.Now.Date.ToString("MM/yyyy");
            String FechFinVen = DateTime.Now.Month.ToString() +  DateTime.Now.Year.ToString();

            //== (DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString()
            //var BusqVentas = DB.LISTPRODUSERVVENs.Where(b => b.ESTLIN == "ACTIVO" && b.FECHAVENTA.);
            var BusqVentas = from listVentas in DB.LISTPRODUSERVVENs
                             where listVentas.ESTLIN == "ACTIVO" && (listVentas.FECHAVENTA.Substring(3,7) == FechVeri )
                             select listVentas;


            double cuenta = 0,IVA=0;
            using (StreamWriter documento = new StreamWriter(Path.Combine(docPath, NomArchivo)))
            {
                foreach (var venta in BusqVentas)
                {
                    cuenta = cuenta + Convert.ToDouble(venta.SubTotProduServ);
                    documento.WriteLine(venta.PRODUCTO_SERVICIO.ToString() + " " +
                        venta.FECHAVENTA.ToString() + " " +
                        venta.SubTotProduServ.ToString());
                }
                IVA = cuenta * 0.05;
                documento.WriteLine("Total= Q" + cuenta.ToString());
                documento.WriteLine("Iva a Pagar= Q" + IVA.ToString());
            }

        }

        private void txtCantProdServ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDESCUENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evalua que solo se puedan ingresar datos numericos
            if (Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnDESCUENTO_Click(object sender, EventArgs e)
        {

        }

        private void txtNIT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
