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
                CargarCombo();
            }
        }

        private void CargarDatos()
        {

            if (ddl_Filtrar.Text.Trim() != "")
            {
                Obj_Factura_DAL.uID_Factura= Convert.ToUInt32(ddl_Filtrar.Text,16);
            }
            else
            {
                Obj_Factura_DAL.uID_Factura = 0;
            }
            Obj_Factura_BLL.List_Facturas(ref Obj_Factura_DAL);


            GridViewfactura.DataSource = null;
            GridViewfactura.DataSource = Obj_Factura_DAL.dtDatos;
            GridViewfactura.DataBind();

        }

        private void CargarCombo()
        {
            Obj_Factura_DAL.uID_Cliente = 0;
            Obj_Factura_BLL.Cargar_Combo(ref Obj_Factura_DAL);

            Obj_Factura_DAL.dtDatos.Rows.Add(0);

            ddl_Filtrar.DataSource = null;
            ddl_Filtrar.DataTextField = "ID_CLIENTE";
            ddl_Filtrar.DataValueField = "ID_FACTURA";
            ddl_Filtrar.DataSource = Obj_Factura_DAL.dtDatos;
            ddl_Filtrar.DataBind();

            ddl_Filtrar.SelectedValue = "0";
        }

        protected void btn_Filtrar_Click(object sender, EventArgs e)
        {
            CargarDatos();

        }


    }
}