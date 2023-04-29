using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;

namespace PL.Pantallas.Formularios
{
    public partial class Servicios : System.Web.UI.Page
    {
        cls_Servicios_BLL Obj_BLL = new cls_Servicios_BLL();
        cls_Servicios_DAL Obj_DAL = new cls_Servicios_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                DropDownListServicio.Text = string.Empty;
                CargarDatos();

            }
        }
        private void CargarDatos()
        {

            Obj_DAL.uID_Servicio = Convert.ToUInt32(DropDownListServicio.Text, 16);

            Obj_BLL.List_Servicio(ref Obj_DAL);

            GridViewServicios.DataSource = null;
            GridViewServicios.DataSource = Obj_DAL.dtDatos;
            GridViewServicios.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDetalle.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            Obj_DAL.sDetalleServicio = txtDetalle.Text.Trim();
            Obj_DAL.fCostoServicio = float.Parse(txtCosto.Text.Trim());

            Obj_BLL.Guardar_Servicio(ref Obj_DAL);

            txtDetalle.Text = string.Empty;
            txtCosto.Text = string.Empty;
            CargarDatos();
        }

        protected void btnFiltar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DropDownListServicio.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            Obj_DAL.sDetalleServicio = txtDetalle.Text.Trim();
            Obj_DAL.fCostoServicio = float.Parse(txtCosto.Text.Trim());

            Obj_BLL.Modificar_Servicio(ref Obj_DAL);

            txtDetalle.Text = string.Empty;
            txtCosto.Text = string.Empty;

            CargarDatos();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DropDownListServicio.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            Obj_DAL.uID_Servicio = Convert.ToUInt32(DropDownListServicio.Text, 16);

            Obj_BLL.Eliminar_Servicio(ref Obj_DAL);

            Obj_DAL.sDetalleServicio = txtDetalle.Text.Trim();
            Obj_DAL.fCostoServicio = float.Parse(txtCosto.Text.Trim());

            CargarDatos();
        }
    }
}