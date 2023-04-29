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
    public partial class Usuarios : System.Web.UI.Page
    {
        cls_Usuario_BLL Obj_Usuario_BLL = new cls_Usuario_BLL();
        cls_Usuario_DAL Obj_Usuario_DAL = new cls_Usuario_DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Txt_Filtrar.Text = string.Empty;
                CargarDatos();

            }

        }
        #region  Metodo
        private void CargarDatos()
        {

            Obj_Usuario_DAL.sNombreUsuario = txtNombre.Text;





            Obj_Usuario_BLL.List_Usuario(ref Obj_Usuario_DAL);

            GridViewUsuarios.DataSource = null;
            GridViewUsuarios.DataSource = Obj_Usuario_DAL.dtDatos;
            GridViewUsuarios.DataBind();
        }
        #endregion

        protected void btnFiltar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Obj_Usuario_DAL.uID_Usuario = Convert.ToUInt32(Txt_Filtrar.Text, 16);
            Obj_Usuario_DAL.sNombreUsuario = txtNombre.Text;
            Obj_Usuario_DAL.sPasswordUsuario = txtPassword.Text;




            Obj_Usuario_BLL.Guardar_Usuario(ref Obj_Usuario_DAL);

            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
            Txt_Filtrar.Text = string.Empty;
            CargarDatos();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Obj_Usuario_DAL.uID_Usuario = Convert.ToUInt32(Txt_Filtrar.Text, 16);
            Obj_Usuario_DAL.sNombreUsuario = txtNombre.Text;
            Obj_Usuario_DAL.sPasswordUsuario = txtPassword.Text;

            Obj_Usuario_BLL.Modificar_Usuario(ref Obj_Usuario_DAL);

            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
            Txt_Filtrar.Text = string.Empty;
            CargarDatos();
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            Obj_Usuario_DAL.uID_Usuario = Convert.ToUInt32(Txt_Filtrar.Text, 16);

            Obj_Usuario_BLL.Eliminar_Usuario(ref Obj_Usuario_DAL);

            Txt_Filtrar.Text = string.Empty;
            CargarDatos();
        }
    }
}