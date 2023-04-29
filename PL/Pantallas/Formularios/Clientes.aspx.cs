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
    public partial class Clientes : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();
            cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();



            if (string.IsNullOrEmpty(txt_IdCliente.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else if (string.IsNullOrEmpty(txt_NombreCliente.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else if (string.IsNullOrEmpty(txt_Correo.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else
            {

                Obj_Clientes_DAL.IIdCliente = Convert.ToInt32(txt_IdCliente.Text.Trim());
                Obj_Clientes_DAL.SNombreCliente = txt_NombreCliente.Text.Trim();
                Obj_Clientes_DAL.SApellido1Cliente = txt_PrimerApellido.Text.Trim();
                Obj_Clientes_DAL.SApellido2Cliente = txt_SegundoApellido.Text.Trim();
                Obj_Clientes_DAL.SDireccionCliente = txt_Direccion.Text.Trim();
                Obj_Clientes_DAL.STelefonoCliente = txt_Telefono.Text.Trim();
                Obj_Clientes_DAL.SCorreoCliente = txt_Correo.Text.Trim();
                Obj_Clientes_BLL.Guardar_Clientes(ref Obj_Clientes_DAL);

            }
        }
        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();
            cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();


            Obj_Clientes_DAL.IIdCliente = Convert.ToInt32(txt_IdCliente.Text.Trim());
            Obj_Clientes_DAL.SNombreCliente = txt_NombreCliente.Text.Trim();
            Obj_Clientes_DAL.SApellido1Cliente = txt_PrimerApellido.Text.Trim();
            Obj_Clientes_DAL.SApellido2Cliente = txt_SegundoApellido.Text.Trim();
            Obj_Clientes_DAL.SDireccionCliente = txt_Direccion.Text.Trim();
            Obj_Clientes_DAL.STelefonoCliente = txt_Telefono.Text.Trim();
            Obj_Clientes_DAL.SCorreoCliente = txt_Correo.Text.Trim();
            Obj_Clientes_BLL.Modificar_Clientes(ref Obj_Clientes_DAL);
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();
            cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();

            Obj_Clientes_DAL.IIdCliente = Convert.ToInt32(txt_IdCliente.Text.Trim());
            Obj_Clientes_BLL.Eliminar_Clientes(ref Obj_Clientes_DAL);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();
            cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();

            Obj_Clientes_DAL.IIdCliente = Convert.ToInt32(txt_IdCliente.Text.Trim());
            Obj_Clientes_BLL.List_Clientes(ref Obj_Clientes_DAL);
        }

        protected void txt_IdCliente_TextChanged(object sender, EventArgs e)
        {
          
               
        
        }
    }
}