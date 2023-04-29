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
    public partial class MetodosPago : System.Web.UI.Page
    {
       cls_MetodosPago_BLL Obj_BLL = new cls_MetodosPago_BLL();
            cls_MetodosPago_DAL Obj_DAL = new cls_MetodosPago_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Obj_DAL.uID_MetodoPago = Convert.ToUInt32(TxtMetododePago.Text.Trim());
            Obj_DAL.sNombreMetodoPago = TxtNombreMetodoPago.Text.Trim();
            Obj_DAL.sDetalleMetodoPago = TxtDetalleMetodoPago.Text.Trim();
            Obj_BLL.Guardar_MetodosPago(ref Obj_DAL);

        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            Obj_DAL.uID_MetodoPago = Convert.ToUInt32(TxtMetododePago.Text.Trim());
            Obj_DAL.sNombreMetodoPago = TxtNombreMetodoPago.Text.Trim();
            Obj_DAL.sDetalleMetodoPago = TxtDetalleMetodoPago.Text.Trim();
            Obj_BLL.Modificar_MetodosPago(ref Obj_DAL);
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Obj_DAL.uID_MetodoPago = Convert.ToUInt32(TxtMetododePago.Text.Trim());
            Obj_BLL.Eliminar_MetodosPago(ref Obj_DAL);
        }

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Obj_DAL.uID_MetodoPago = Convert.ToUInt32(TxtMetododePago.Text.Trim());
            Obj_BLL.List_MetodosPago(ref Obj_DAL);
        }
    }
}