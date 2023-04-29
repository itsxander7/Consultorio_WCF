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
    public partial class Promociones : System.Web.UI.Page
    {
        cls_Promociones_DAL Obj_BLL = new cls_Promociones_DAL();
        cls_Promociones_BLL Obj_DAL = new cls_Promociones_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            cls_Promociones_DAL Obj_Promo_DAL = new cls_Promociones_DAL();
            cls_Promociones_BLL Obj_Promo_BLL = new cls_Promociones_BLL();


           // Obj_Promo_DAL.uID_Promocion = Convert.ToUInt32(txt_IdPromocion.Text.Trim());
            Obj_Promo_DAL.sDetallePromocion = txt_Detalle.Text.Trim();
            Obj_Promo_DAL.fMontoPromocion = float.Parse(txt_Monto.Text.Trim());
            Obj_Promo_DAL.uID_Servicio = Convert.ToUInt32(txt_Servicio.Text.Trim());
            Obj_Promo_BLL.Guardar_Promo(ref Obj_Promo_DAL);
            txt_IdPromocion.Text = "";
            txt_Monto.Text = "";
            txt_Detalle.Text = "";
            txt_Servicio.Text = "";
            CargarDatos();
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            cls_Promociones_DAL Obj_Promo_DAL = new cls_Promociones_DAL();
            cls_Promociones_BLL Obj_Promo_BLL = new cls_Promociones_BLL();

            Obj_Promo_DAL.uID_Promocion = Convert.ToUInt32(txt_IdPromocion.Text.Trim());
            Obj_Promo_DAL.sDetallePromocion = txt_Detalle.Text.Trim();
            Obj_Promo_DAL.fMontoPromocion = float.Parse(txt_Monto.Text.Trim());
            Obj_Promo_DAL.uID_Servicio = Convert.ToUInt32(txt_Servicio.Text.Trim());
            Obj_Promo_BLL.Modificar_Promo(ref Obj_Promo_DAL);
            txt_IdPromocion.Text = "";
            txt_Monto.Text = "";
            txt_Detalle.Text = "";
            txt_Servicio.Text = "";
            CargarDatos();

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            cls_Promociones_DAL Obj_Promo_DAL = new cls_Promociones_DAL();
            cls_Promociones_BLL Obj_Promo_BLL = new cls_Promociones_BLL();

            Obj_Promo_DAL.uID_Promocion = Convert.ToUInt32(txt_IdPromocion.Text.Trim());
            Obj_Promo_BLL.Eliminar_Promo(ref Obj_Promo_DAL);
            txt_IdPromocion.Text = "";
            txt_Monto.Text = "";
            txt_Detalle.Text = "";
            txt_Servicio.Text = "";

            CargarDatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cls_Promociones_DAL Obj_Promo_DAL = new cls_Promociones_DAL();
            cls_Promociones_BLL Obj_Promo_BLL = new cls_Promociones_BLL();

            if (txt_IdPromocion.Text.Trim() != "") { 
            Obj_Promo_DAL.uID_Promocion = Convert.ToUInt32(txt_IdPromocion.Text.Trim());
            Obj_Promo_BLL.List_Promo(ref Obj_Promo_DAL);
            }
            else {

                CargarDatos();
            }

            txt_IdPromocion.Text = "";
            txt_Monto.Text = "";
            txt_Detalle.Text = "";
            txt_Servicio.Text = "";
        }

        private void CargarDatos() {
            cls_Promociones_DAL Obj_Promo_DAL = new cls_Promociones_DAL();
            cls_Promociones_BLL Obj_Promo_BLL = new cls_Promociones_BLL();

            if (txt_IdPromocion.Text.Trim() != "")
            {
                Obj_Promo_DAL.uID_Promocion = Convert.ToUInt32(txt_IdPromocion.Text);
            }
            else
            {
                Obj_Promo_DAL.uID_Promocion = 0;
            }

            Obj_Promo_BLL.List_Promo(ref Obj_Promo_DAL);
            GridView1.DataSource = null;
            GridView1.DataSource = Obj_Promo_DAL.dtDatos;
            GridView1.DataBind();


        }
    }
}