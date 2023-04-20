using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.MANTENIMIENTOS;
using BLL.MANTENIMIENTOS;

namespace PL
{
    public partial class _Default : Page
    {
        #region VARIABLES GLOBALES 

        cls_Clientes Obj_CLIENTES_DAL = new cls_Clientes();
        cls_Clientes_BLL Obj_CLIENTES_BLL = new cls_Clientes_BLL();

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txt_filtro.Text = string.Empty;
                CargarDatos();
               // CargarCombos();
            }
        }

        protected void btn_filtrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        #region MÉTODOS

        private void CargarDatos()
        {
            if (txt_filtro.Text.Trim() != "")
            {
                Obj_CLIENTES_DAL.ID_CLIENTE = int.Parse(txt_filtro.Text.Trim());
            }
            else
            {

                Obj_CLIENTES_DAL.ID_CLIENTE = 0;
            }


            Obj_CLIENTES_BLL.List_Clientes(ref Obj_CLIENTES_DAL);

            dgv_regiones.DataSource = null;
            dgv_regiones.DataSource = Obj_CLIENTES_DAL.DtDatos;
            dgv_regiones.DataBind();
        }

        private void CargarCombos()
        {
            /* Obj_Regiones_DAL.sTerritoryDescription = "";

             //Obj_Regiones_BLL.List_Filt_REGIONES(ref Obj_Regiones_DAL);

             Obj_Regiones_DAL.DtDatos.Rows.Add("0", "--- SELECCIONE UNA REGIÓN ---");

             ddl_Regiones.DataSource = null;
             ddl_Regiones.DataTextField = "NOMBRE REGIÓN";
             ddl_Regiones.DataValueField = "ID REGIÓN";
             ddl_Regiones.DataSource = Obj_Regiones_DAL.DtDatos;
             ddl_Regiones.DataBind();

             ddl_Regiones.SelectedValue = "0";*/
        }


        #endregion

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Obj_CLIENTES_DAL.ID_CLIENTE = int.Parse(Txt_id.Text);
            Obj_CLIENTES_DAL.NOMBRE_CLIENTE = txt_nombreCliente.Text.Trim();
            Obj_CLIENTES_DAL.APELLIDO1_CLIENTE = txt_apellido1.Text.Trim();
            Obj_CLIENTES_DAL.APELLIDO2_CLIENTE = txt_apellido2.Text.Trim();
            Obj_CLIENTES_DAL.DIRECCION_CLIENTE = txt_direccion.Text.Trim();
            Obj_CLIENTES_DAL.TELEFONO = txt_telefono.Text.Trim();
            Obj_CLIENTES_DAL.CORREO_CLIENTE = txt_correo.Text.Trim();


            Obj_CLIENTES_BLL.Guardar_CLIENTES(ref Obj_CLIENTES_DAL);

            txt_filtro.Text = string.Empty;
            txt_nombreCliente.Text = string.Empty;
            txt_apellido1.Text = string.Empty;
            txt_apellido2.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_correo.Text = string.Empty;
            CargarDatos();

        }

        protected void txt_Eliminar_Click(object sender, EventArgs e)
        {
            Obj_CLIENTES_DAL.ID_CLIENTE = int.Parse(Txt_id.Text);

            Obj_CLIENTES_BLL.Eliminar_CLIENTES(ref Obj_CLIENTES_DAL);

            txt_filtro.Text = string.Empty;
            Txt_id.Text = string.Empty;
            CargarDatos();
        }
    }
}