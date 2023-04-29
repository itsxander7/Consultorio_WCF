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
    public partial class Citas : System.Web.UI.Page
    {
        cls_Citas_DAL Obj_Citas_DAL = new cls_Citas_DAL();
        cls_Citas_BLL Obj_Citas_BLL = new cls_Citas_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtFiltrar.Text = string.Empty;
                CargarDatos();

            }
        }

        #region Metodo
        private void CargarDatos()
        {
            if (txtFiltrar.Text.Trim() != "")
            {
                Obj_Citas_DAL.iIdCita = int.Parse(txtFiltrar.Text);
            }
            else
            {

                Obj_Citas_DAL.iIdCita = 0;
            }



            Obj_Citas_BLL.List_Citas(ref Obj_Citas_DAL);

            gdvCitas.DataSource = null;
            gdvCitas.DataSource = Obj_Citas_DAL.dtDatos;
            gdvCitas.DataBind();
        }
        #endregion
        protected void btnFiltar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Txt_Cliente.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else if (string.IsNullOrEmpty(Txt_Especialidad.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else if (string.IsNullOrEmpty(Txt_Doctor.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else if (string.IsNullOrEmpty(Txt_Fecha.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }

            Obj_Citas_DAL.iIdCliente = int.Parse(Txt_Cliente.Text);
            Obj_Citas_DAL.iIdEspecialidad = int.Parse(Txt_Especialidad.Text);
            Obj_Citas_DAL.iIdDoctor = int.Parse(Txt_Doctor.Text);
            Obj_Citas_DAL.dtFecha = DateTime.Parse(Txt_Fecha.Text);



            Obj_Citas_BLL.Guardar_Citas(ref Obj_Citas_DAL);

            Txt_Cliente.Text = string.Empty;
            Txt_Especialidad.Text = string.Empty;
            Txt_Doctor.Text = string.Empty;
            Txt_Fecha.Text = string.Empty;
            txtFiltrar.Text = string.Empty;
            CargarDatos();


        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Obj_Citas_DAL.iIdCita = int.Parse(txtFiltrar.Text);
            Obj_Citas_DAL.iIdCliente = int.Parse(Txt_Cliente.Text);
            Obj_Citas_DAL.iIdEspecialidad = int.Parse(Txt_Especialidad.Text);
            Obj_Citas_DAL.iIdDoctor = int.Parse(Txt_Doctor.Text);
            Obj_Citas_DAL.dtFecha = DateTime.Parse(Txt_Fecha.Text);

            Obj_Citas_BLL.Modificar_Citas(ref Obj_Citas_DAL);

            Txt_Cliente.Text = string.Empty;
            Txt_Especialidad.Text = string.Empty;
            Txt_Doctor.Text = string.Empty;
            Txt_Fecha.Text = string.Empty;
            txtFiltrar.Text = string.Empty;
            CargarDatos();

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            Obj_Citas_DAL.iIdCita = int.Parse(txtFiltrar.Text);

            Obj_Citas_BLL.Eliminar_Citas(ref Obj_Citas_DAL);

            txtFiltrar.Text = string.Empty;
            CargarDatos();
        }
    }
}