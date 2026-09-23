using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.DATA;

namespace Productos
{
    public partial class REGPRODSERV2 : Form
    {
        private Model1 DB = new Model1();
        public REGPRODSERV2()
        {
            InitializeComponent();
        }

        private void regitroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAGREGARPRO_Click(object sender, EventArgs e)
        {
            PRODUCTO producto = new PRODUCTO();
            PROSERVLIST listado = new PROSERVLIST();
          

                if(( txtNomProdu.Text != " " ||
                    txtCosto.Text != " "||
                    txtCostoVenta.Text != " "||
                    txtPROVEEDOR.Text != " "||
                    txtSTOCK.Text != " ")|| 
                   
                    (txtNomProdu.Text != null ||
                    txtCosto.Text != null ||
                    txtCostoVenta.Text != null ||
                    txtPROVEEDOR.Text != null ||
                    txtSTOCK.Text != null))
            {
                try
                {
                    producto.ESTLIN = "ACTIVO";
                    producto.PRODUCTO1 = txtNomProdu.Text;
                    producto.COSTO =Convert.ToDecimal(txtCosto.Text);
                    producto.COSTOVENTA = Convert.ToDecimal(txtCostoVenta.Text);
                    producto.PROVEEDOR = txtPROVEEDOR.Text;
                    producto.STOCK = Convert.ToInt32(txtSTOCK.Text);
                    producto.IVA = Convert.ToDecimal(txtCostoVenta.Text) * Convert.ToDecimal( 0.05);
                    producto.PRECIO = (Convert.ToDecimal(txtCostoVenta.Text) * Convert.ToDecimal(0.05)) + Convert.ToDecimal(txtCostoVenta.Text);
                    DB.PRODUCTOes.Add(producto);

                    listado.ESTLIN = "ACTIVO";
                    listado.PRODUCTO_SERVICIO = txtNomProdu.Text;
                    listado.PRECIO = producto.PRECIO;
                    listado.CLASIFICACION = "PRODUCTO";
                    listado.STOCK = producto.STOCK;
                    DB.PROSERVLISTs.Add(listado);

                    DB.SaveChanges();
                    txtNomProdu.Text = "";
                    txtCosto.Text = "";
                    txtCostoVenta.Text = "";
                    txtPROVEEDOR.Text = "";
                    txtSTOCK.Text = "";
                    this.pRODUCTOTableAdapter.Fill(this.pATRIARCA5DataSet.PRODUCTO);
                    
                    lblResulPRODUCTO.Text = "PRODUCTO GUARDADO O INGRESADO";
                    lblResulPRODUCTO.Visible = true;
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: Datos no guardados. " + a);
                    
                    lblResulPRODUCTO.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                    lblResulPRODUCTO.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Error: Datos no ingresados en campos", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Error: Codigo Incorrecto, consulte con su Administrador", "Error Código", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                lblResulPRODUCTO.Text = "ERROR: Verifique que TODOS LOS CAMPOS esten llenos";
                lblResulPRODUCTO.Visible = true;
            }
        }

        private void REGPRODSERV2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pATRIARCADataSet1.SERVICIO' table. You can move, or remove it, as needed.
            this.sERVICIOTableAdapter.Fill(this.pATRIARCADataSet1.SERVICIO);
            // TODO: This line of code loads data into the 'pATRIARCA5DataSet.PRODUCTO' table. You can move, or remove it, as needed.
            this.pRODUCTOTableAdapter.Fill(this.pATRIARCA5DataSet.PRODUCTO);

        }

        private void btnELIMINARPROD_Click(object sender, EventArgs e)
        {

            //FORMAS DE EVALUAR DATOS DE UNA CELDA O COLUMNA
            //MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
            //MessageBox.Show(dataGridView1.Columns[dataGridView1.CurrentCell.RowIndex].HeaderText.ToString());
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            
            try
            {
                PRODUCTO producto = DB.PRODUCTOes.Find(dataGridView1.CurrentRow.Cells[0].Value);
                producto.ESTLIN = "BORRADO";
                DB.Entry(producto).State = EntityState.Modified;
                string DBProducto = producto.PRODUCTO1;
                int CodProServ = 0;

                var listProdu = DB.PROSERVLISTs.Where(b => b.PRODUCTO_SERVICIO == DBProducto);
                foreach(var itemG in listProdu)
                {
                    CodProServ = itemG.CODPROSERVLIST;
                }

                PROSERVLIST listaElim = DB.PROSERVLISTs.Find(CodProServ);
                listaElim.ESTLIN = "BORRADO";
                DB.Entry(listaElim).State = EntityState.Modified;
                DB.SaveChanges();

                this.pRODUCTOTableAdapter.Fill(this.pATRIARCA5DataSet.PRODUCTO);
                
                lblResulPRODUCTO.Text = "PRODUCTO ELIMINADO";
                lblResulPRODUCTO.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: Datos no guardados. " + a);
                
                lblResulPRODUCTO.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                lblResulPRODUCTO.Visible = true;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pxbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ventaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VENTAS VENTA = new VENTAS();
            VENTA.Show();
            this.Hide();
        }

        private void pagoDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PAGOANTICIPO AnticipoVen = new PAGOANTICIPO();
            //AnticipoVen.Show();
            //this.Hide();
            MessageBox.Show("Esta sección solo esta abierta para versión de pago y no para la versión Gratuita", "ERROR DE SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gANACIASPERDIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //REPORGANAPERDI GANPER = new REPORGANAPERDI();
            //GANPER.Show();
            //this.Hide();
            MessageBox.Show("Esta sección solo esta abierta para versión de pago y no para la versión Gratuita", "ERROR DE SELECCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarServ_Click(object sender, EventArgs e)
        {
            SERVICIO servicios = new SERVICIO();
            PROSERVLIST listado = new PROSERVLIST();
            //if (txtNombServicio.Text != "")

            if((txtNombServicio.Text != " "|| 
                txtCostoServicio.Text != " "||
                txtCostoVeServicio.Text != " ")||

               (txtNombServicio.Text != null ||
                txtCostoServicio.Text != null ||
                txtCostoVeServicio.Text != null))

            {
                try
                {
                    servicios.ESTLIN = "ACTIVO";
                    servicios.SERVICIO1 = txtNombServicio.Text;
                    servicios.COSTO = Convert.ToDecimal(txtCostoServicio.Text);
                    servicios.COSTOVENTA = Convert.ToDecimal(txtCostoVeServicio.Text);
                    servicios.CANTIDAD = 0 ;
                    servicios.IVA = Convert.ToDecimal(txtCostoVeServicio.Text) * Convert.ToDecimal(0.05);
                    servicios.PRECIO = (Convert.ToDecimal(txtCostoVeServicio.Text) * Convert.ToDecimal(0.05)) + Convert.ToDecimal(txtCostoVeServicio.Text);
                    DB.SERVICIOs.Add(servicios);

                    listado.ESTLIN = "ACTIVO";
                    listado.PRODUCTO_SERVICIO = txtNombServicio.Text;
                    listado.PRECIO = servicios.PRECIO;
                    listado.CLASIFICACION = "Servicio";
                    listado.STOCK = 0;
                    DB.PROSERVLISTs.Add(listado);


                    DB.SaveChanges();
                    txtNombServicio.Text = "";
                    txtCostoServicio.Text = "";
                    txtCostoVeServicio.Text = "";

                    this.sERVICIOTableAdapter.Fill(this.pATRIARCADataSet1.SERVICIO);
                    
                    lblResulServ.Text = "SERVICIO GUARDADO O INGRESADO";
                    lblResulServ.Visible = true;
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: Datos no guardados. " + a);
                    lblResulServ.Visible = true;
                    lblResulServ.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                }
            }
            else
            {
                MessageBox.Show("Error: Datos no ingresados en campos", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                lblResulServ.Text = "ERROR: Verifique que TODOS LOS CAMPOS esten llenos";
                lblResulServ.Visible = true;
            }
        }

        private void btnEliminarServ_Click(object sender, EventArgs e)
        {
            try
            {
                SERVICIO servicios = DB.SERVICIOs.Find(dataGridView2.CurrentRow.Cells[0].Value);
                servicios.ESTLIN = "BORRADO";
                DB.Entry(servicios).State = EntityState.Modified;
                string DBServicio = servicios.SERVICIO1;
                int CodProServ = 0;

                var listProdu = DB.PROSERVLISTs.Where(b => b.PRODUCTO_SERVICIO == DBServicio);
                foreach (var itemG in listProdu)
                {
                    CodProServ = itemG.CODPROSERVLIST;
                }

                PROSERVLIST listaElim = DB.PROSERVLISTs.Find(CodProServ);
                listaElim.ESTLIN = "BORRADO";
                DB.Entry(listaElim).State = EntityState.Modified;
                DB.SaveChanges();

                this.sERVICIOTableAdapter.Fill(this.pATRIARCADataSet1.SERVICIO);
                
                lblResulServ.Text = "SERVICIO ELIMINADO";
                lblResulServ.Visible = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: Datos no guardados. " + a);
                
                lblResulServ.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                lblResulServ.Visible = true;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCostVentProdVist_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBUSCARPRO_Click(object sender, EventArgs e)
        {
            if (txtNombProdEdit.Text == "")
            {
                MessageBox.Show("ERROR, EL CAMPO DE BUSQUEDA ESTA VACIO", "ERRO BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var BusqProd = DB.PRODUCTOes.Where(b => b.PRODUCTO1 == txtNombProdEdit.Text);

                foreach (var itemProd in BusqProd)
                {
                    txtCodPRODUCTO.Text = itemProd.CODPRODUCTO.ToString();
                    txtNomProdVist.Text = itemProd.PRODUCTO1;
                    txtCostVentProdVist.Text = itemProd.COSTOVENTA.ToString();
                    txtCostoProdVist.Text = itemProd.COSTO.ToString();
                    txtSTOCKPRODVIST.Text = itemProd.STOCK.ToString();
                    txtPROVEEPRODVIST.Text = itemProd.PROVEEDOR;
                }
                lblResulEditProd.Text = "BUSQUEDA ENCONTRADA";
                lblResulEditProd.Visible = true;
                txtNombProdEdit.Text = "";
            }
           
        }

        private void btnACTUALIZARPRO_Click(object sender, EventArgs e)
        {
            if ((txtNomProdVist.Text != " " ||
                    txtCostVentProdVist.Text != " " ||
                    txtCostoProdVist.Text != " " ||
                    txtSTOCKPRODVIST.Text != " " ||
                    txtPROVEEPRODVIST.Text != " ") ||

                (txtNomProdVist.Text != null ||
                    txtCostVentProdVist.Text != null ||
                    txtCostoProdVist.Text != null ||
                    txtSTOCKPRODVIST.Text != null ||
                    txtPROVEEPRODVIST.Text != null))
            {
                try
                {
                    Decimal ConverTxtCostoProdVist = Convert.ToDecimal(txtCostoProdVist.Text), 
                        ConvertIVA= Convert.ToDecimal(0.05),
                        ConvertxtCostVentProdVist = Convert.ToDecimal(txtCostVentProdVist.Text);
                    
                    PRODUCTO productoEdit = DB.PRODUCTOes.Find(Convert.ToInt32(txtCodPRODUCTO.Text));
                    productoEdit.ESTLIN = "ACTIVO";

                    productoEdit.PRODUCTO1 = txtNomProdVist.Text;
                    productoEdit.COSTOVENTA = ConvertxtCostVentProdVist;
                    productoEdit.COSTO = ConverTxtCostoProdVist;
                    productoEdit.IVA = ConverTxtCostoProdVist * ConvertIVA;
                    productoEdit.PRECIO = ((ConvertxtCostVentProdVist * ConvertIVA) + ConvertxtCostVentProdVist);
                    productoEdit.STOCK = Convert.ToInt32(txtSTOCKPRODVIST.Text);
                    productoEdit.PROVEEDOR = txtPROVEEPRODVIST.Text;

                    DB.Entry(productoEdit).State = EntityState.Modified;
                    string DBProducto = productoEdit.PRODUCTO1.ToString();
                    Int32 CodProServ = 0;

                    var listProdu = DB.PROSERVLISTs.Where(b => b.PRODUCTO_SERVICIO == DBProducto);
                    foreach (var itemG in listProdu)
                    {
                        CodProServ = itemG.CODPROSERVLIST;
                    }
                    if (CodProServ == 0)
                    {
                        MessageBox.Show("Error: Producto NO ENCONTRADO en DBA, consulte con su tecnico o envie las imagenes y procedimiento a nuestro correo. ", "ERROR DBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    PROSERVLIST listaEDIT = DB.PROSERVLISTs.Find(CodProServ);
                    listaEDIT.ESTLIN = "ACTIVO";
                    listaEDIT.PRODUCTO_SERVICIO = DBProducto;
                    listaEDIT.PRECIO = productoEdit.PRECIO;
                    listaEDIT.STOCK = Convert.ToInt32(txtSTOCKPRODVIST.Text);
                    DB.Entry(listaEDIT).State = EntityState.Modified;
                    DB.SaveChanges();

                    this.pRODUCTOTableAdapter.Fill(this.pATRIARCA5DataSet.PRODUCTO);

                    txtNomProdVist.Text = "";
                    txtCostVentProdVist.Text = "";
                    txtCostoProdVist.Text = "";
                    txtSTOCKPRODVIST.Text = "";
                    txtPROVEEPRODVIST.Text = "";
                    lblResulEditProd.Text = "PRODUCTO ACTUALIZADO";
                    lblResulEditProd.Visible = true;
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: Datos no guardados. " + a);

                    lblResulEditProd.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                    lblResulEditProd.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Error: Datos no ingresados en campos", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblResulEditProd.Text = "ERROR: Verifique que TODOS LOS CAMPOS esten llenos";
                lblResulEditProd.Visible = true;
            }

            
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnBUSCARSERV_Click(object sender, EventArgs e)
        {
            if  (txtNombServEdit.Text == " ")
            {
                MessageBox.Show("ERROR, EL CAMPO DE BUSQUEDA ESTA VACIO", "ERRO BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var BusqServ = DB.SERVICIOs.Where(b => b.SERVICIO1 == txtNombServEdit.Text);

                    foreach (var itemServ in BusqServ)
                    {
                        txtCodServ.Text = itemServ.CODIGOSERVICIO.ToString();
                        txtNombServVist.Text = itemServ.SERVICIO1.ToString();
                        txtCostVenServVist.Text = itemServ.COSTOVENTA.ToString();
                        txtCostoServVist.Text = itemServ.COSTO.ToString();
                        txtCantServVist.Text = itemServ.CANTIDAD.ToString();
                        txtIvaServVist.Text = itemServ.IVA.ToString();
                    }
                    lblResultadoEditServ.Text = "BUSQUEDA ENCONTRADA";
                    lblResultadoEditServ.Visible = true;
                    txtNombServEdit.Text = "";
                }
                catch ( Exception a)
                {

                    MessageBox.Show("Error: Datos no guardados. " + a);

                    lblResulEditProd.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                    lblResulEditProd.Visible = true;
                }
               
            }
        }

        private void btnACTUALIZARSERV_Click(object sender, EventArgs e)
        {
            if ((txtNombServVist.Text != " " ||
                    txtCodServ.Text != " " ||
                    txtCostVenServVist.Text != " " ||
                    txtCostoServVist.Text != " " ||
                    txtIvaServVist.Text != " " ||
                    txtCantServVist.Text != " ") ||

                (txtNombServVist.Text != null ||
                    txtCodServ.Text != null ||
                    txtCostVenServVist.Text != null ||
                    txtCostoServVist.Text != null ||
                    txtIvaServVist.Text != null ||
                    txtCantServVist.Text != null))
            {
                try
                {
                    Decimal ConverTxtCostoServVist = Convert.ToDecimal(txtCostoServVist.Text), 
                        ConvertIVA = Convert.ToDecimal(0.05),
                        ConvertxtCostVenServVist= Convert.ToDecimal(txtCostVenServVist.Text);

                    SERVICIO servicioEdit = DB.SERVICIOs.Find(Convert.ToInt32(txtCodServ.Text));
                    servicioEdit.ESTLIN = "ACTIVO";

                    servicioEdit.SERVICIO1 = txtNombServVist.Text;
                    servicioEdit.COSTOVENTA = ConvertxtCostVenServVist;
                    servicioEdit.COSTO = ConverTxtCostoServVist;
                    servicioEdit.IVA = ConverTxtCostoServVist * ConvertIVA;
                    servicioEdit.PRECIO = ((ConvertxtCostVenServVist * ConvertIVA) + ConvertxtCostVenServVist);
                    servicioEdit.CANTIDAD =  Convert.ToInt16(txtCantServVist.Text);
                   


                    DB.Entry(servicioEdit).State = EntityState.Modified;
                    string DBServicio = servicioEdit.SERVICIO1;
                    Int32 CodServ = 0;

                    var listServi = DB.PROSERVLISTs.Where(b => b.PRODUCTO_SERVICIO == DBServicio);
                    foreach (var itemG in listServi)
                    {
                        CodServ = itemG.CODPROSERVLIST;
                    }
                    if (CodServ == 0)
                    {
                        MessageBox.Show("Error: Servicio NO ENCONTRADO en DBA, consulte con su tecnico o envie las imagenes y procedimiento a nuestro correo. ","ERROR DBA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    PROSERVLIST listaEDIT = DB.PROSERVLISTs.Find(CodServ);
                    listaEDIT.ESTLIN = "ACTIVO";
                    listaEDIT.PRODUCTO_SERVICIO = DBServicio;
                    listaEDIT.PRECIO = servicioEdit.PRECIO;
                    listaEDIT.STOCK = 0;
                    DB.Entry(listaEDIT).State = EntityState.Modified;
                    DB.SaveChanges();

                    this.sERVICIOTableAdapter.Fill(this.pATRIARCADataSet1.SERVICIO);

                    txtNombServVist.Text = "";
                    txtCodServ.Text = "";
                    txtCostVenServVist.Text = "";
                    txtCostoServVist.Text = "";
                    txtIvaServVist.Text = "";
                    txtCantServVist.Text = "";
                    lblResultadoEditServ.Text = "SERVICIO ACTUALIZADO";
                    lblResultadoEditServ.Visible = true;
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error: Datos no guardados. " + a);
                    lblResultadoEditServ.Text = "ERROR DBA, CONSULTE A SOPORTE TÉCNICO";
                    lblResultadoEditServ.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Error: Datos no ingresados en campos", "ERROR DE CAMPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblResultadoEditServ.Text = "ERROR: Verifique que TODOS LOS CAMPOS esten llenos";
                lblResultadoEditServ.Visible = true;
            }

            
        }

        private void pATRIARCA5DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}