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
                CargarCLientes();
                CargarEspecialidad();
                CargarDoctor();

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
        private void CargarCLientes()
        {
            Obj_Citas_DAL.iIdCliente = 0;
            Obj_Citas_BLL.Desplegar_Clientes(ref Obj_Citas_DAL);



            Obj_Citas_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA CEDULA---");

            ddl_Id_Cliente.DataSource = null;
            ddl_Id_Cliente.DataTextField = "NOMBRE_CLIENTE";
            ddl_Id_Cliente.DataValueField = "ID_CLIENTE";
            ddl_Id_Cliente.DataSource = Obj_Citas_DAL.dtDatos;
            ddl_Id_Cliente.DataBind();

            ddl_Id_Cliente.SelectedValue = "0";
        }

        private void CargarEspecialidad()
        {
            Obj_Citas_DAL.iIdEspecialidad = 0;
            Obj_Citas_BLL.Desplegar_Especialidad(ref Obj_Citas_DAL);



            Obj_Citas_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UNA ESPECIALIDAD ---");

            ddl_Nombre_Especialidad.DataSource = null;
            ddl_Nombre_Especialidad.DataTextField = "NOMBRE_ESPECIALIDAD";
            ddl_Nombre_Especialidad.DataValueField = "ID_ESPECIALIDAD";
            ddl_Nombre_Especialidad.DataSource = Obj_Citas_DAL.dtDatos;
            ddl_Nombre_Especialidad.DataBind();

            ddl_Nombre_Especialidad.SelectedValue = "0";
        }
        private void CargarDoctor()
        {
            Obj_Citas_DAL.iIdDoctor = 0;
            Obj_Citas_BLL.Desplegar_Doctores(ref Obj_Citas_DAL);



            Obj_Citas_DAL.dtDatos.Rows.Add("0", "--- SELECCIONE UN DOCTOR ---");

            ddl_Nombre_Doctor.DataSource = null;
            ddl_Nombre_Doctor.DataTextField = "NOMBRE_DOCTOR";
            ddl_Nombre_Doctor.DataValueField = "ID_DOCTOR";
            ddl_Nombre_Doctor.DataSource = Obj_Citas_DAL.dtDatos;
            ddl_Nombre_Doctor.DataBind();

            ddl_Nombre_Doctor.SelectedValue = "0";
        }
        #endregion
        protected void btnFiltar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            /* if (string.IsNullOrEmpty(Txt_Cliente.Text))
             {
                 string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                 ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                 return;
             }
             else */
            if (string.IsNullOrEmpty(ddl_Nombre_Especialidad.Text))
            {
                string script = String.Format(@"<script type='text/javascript'>alert('Existen campos vacios' );</script>", "0033");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                return;
            }
            else if (string.IsNullOrEmpty(ddl_Nombre_Doctor.Text))
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

            // Obj_Citas_DAL.iIdCliente = int.Parse(Txt_Cliente.Text);
            Obj_Citas_DAL.iIdEspecialidad = int.Parse(ddl_Nombre_Especialidad.Text);
            Obj_Citas_DAL.iIdDoctor = int.Parse(ddl_Nombre_Doctor.Text);
            Obj_Citas_DAL.dtFecha = DateTime.Parse(Txt_Fecha.Text);



            Obj_Citas_BLL.Guardar_Citas(ref Obj_Citas_DAL);

            ddl_Id_Cliente.SelectedValue = "0";
            ddl_Nombre_Especialidad.SelectedValue= "0";
            ddl_Nombre_Doctor.SelectedValue = "0";
            Txt_Fecha.Text = string.Empty;
            txtFiltrar.Text = string.Empty;
            CargarDatos();


        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Obj_Citas_DAL.iIdCita = int.Parse(txtFiltrar.Text);
            //Obj_Citas_DAL.iIdCliente = int.Parse(Txt_Cliente.Text);
            Obj_Citas_DAL.iIdEspecialidad = int.Parse(ddl_Nombre_Especialidad.Text);
            Obj_Citas_DAL.iIdDoctor = int.Parse(ddl_Nombre_Doctor.Text);
            Obj_Citas_DAL.dtFecha = DateTime.Parse(Txt_Fecha.Text);

            Obj_Citas_BLL.Modificar_Citas(ref Obj_Citas_DAL);

            ddl_Id_Cliente.SelectedValue = "0";
            ddl_Nombre_Especialidad.SelectedValue = "0";
            ddl_Nombre_Doctor.SelectedValue = "0";
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



        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Txt_Fecha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}