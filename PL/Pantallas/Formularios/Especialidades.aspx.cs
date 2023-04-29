using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;
using System;
using System.Web.UI;

namespace PL.Pantallas.Formularios
{
    public partial class Especialidades : System.Web.UI.Page
    {
        cls_Especialidades_BLL Obj_BLL = new cls_Especialidades_BLL();
        cls_Especialidades_DAL Obj_DAL = new cls_Especialidades_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TxtIdEspecialidad.Text = string.Empty;
                CargarDatos();

            }
        }

        #region Metodo
        private void CargarDatos()
        {
          
                Obj_DAL.SNombreEspecialidad = TxtNombreEspecialidad.Text.Trim();
            


            Obj_BLL.List_Especialidades(ref Obj_DAL);

            GridViewEspecialidad.DataSource = null;
            GridViewEspecialidad.DataSource = Obj_DAL.DtDatos;
            GridViewEspecialidad.DataBind();
        }
        #endregion

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombreEspecialidad.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            Obj_DAL.SNombreEspecialidad = TxtNombreEspecialidad.Text.Trim();

            Obj_BLL.Guardar_Especialidades(ref Obj_DAL);

            TxtNombreEspecialidad.Text = string.Empty;
            CargarDatos();

        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtIdEspecialidad.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            Obj_DAL.IIdEspecialidad = int.Parse(TxtIdEspecialidad.Text);
            Obj_DAL.SNombreEspecialidad = TxtNombreEspecialidad.Text.Trim();

            Obj_BLL.Modificar_Especialidades(ref Obj_DAL);

            TxtIdEspecialidad.Text = string.Empty;
            TxtNombreEspecialidad.Text = string.Empty;

            CargarDatos();

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIdEspecialidad.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            Obj_DAL.IIdEspecialidad = int.Parse(TxtIdEspecialidad.Text);

            Obj_BLL.Eliminar_Especialidades(ref Obj_DAL);

            TxtIdEspecialidad.Text = string.Empty;
            CargarDatos();
        }

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}