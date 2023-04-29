using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.MANTENIMIENTOS;
using BLL.MANTENIMIENTOS;

namespace PL.Pantallas.Formularios
{
    public partial class Facturas : System.Web.UI.Page
    {
        cls_Facturacion_BLL Obj_Factura_BLL = new cls_Facturacion_BLL();
        cls_Facturacion_DAL Obj_Factura_DAL = new cls_Facturacion_DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {

                CargarDatos();

            }
        }

        private void CargarDatos()
        {

            Obj_Factura_BLL.List_Facturas(ref Obj_Factura_DAL);

            GridViewfactura.DataSource = null;
            GridViewfactura.DataSource = Obj_Factura_DAL.dtDatos;
            GridViewfactura.DataBind();
        }
    }
}