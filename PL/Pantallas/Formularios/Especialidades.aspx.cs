using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                
                CargarDatos();

            }
        }

        #region Metodo
        private void CargarDatos()
        {
            if (txtBuscarEspecialidad.Text == string.Empty)
            {
                Obj_DAL.iIdEspecialidad = 0;
            }
            else
            {
                Obj_DAL.iIdEspecialidad = Convert.ToInt32(txtBuscarEspecialidad.Text.Trim());
            }
            Obj_BLL.List_Especialidades(ref Obj_DAL);

            GridViewEspecialidad.DataSource = null;
            GridViewEspecialidad.DataSource = Obj_DAL.DtDatos;
            GridViewEspecialidad.DataBind();

        }
        #endregion

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {

            Insertar_Especialidad();
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {

            Obj_DAL.iIdEspecialidad = Convert.ToInt32(txtIdEspecialidad.Text.Trim());
            Obj_DAL.sNombreEspecialidad = TxtNombreEspecialidad.Text.Trim();

            Obj_BLL.Modificar_Especialidades(ref Obj_DAL);

            txtIdEspecialidad.Text = string.Empty;
           txtIdEspecialidad.Text = string.Empty;

            CargarDatos();

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
         
            Obj_DAL.iIdEspecialidad = Convert.ToInt32(txtIdEspecialidad.Text.Trim());
            Obj_BLL.Eliminar_Especialidades(ref Obj_DAL);
            txtIdEspecialidad.Text = string.Empty;
            CargarDatos();
        }

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CargarDatos();


        }
        public void Insertar_Especialidad()
        {
            Obj_DAL.sNombreEspecialidad = TxtNombreEspecialidad.Text.Trim();

            Obj_BLL.Guardar_Especialidades(ref Obj_DAL);
            CargarDatos();

        }

        protected void GridViewEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridViewEspecialidad.Rows.Count > 0)
            {
                // Obtener la fila seleccionada
                GridViewRow selectedRow = GridViewEspecialidad.Rows[0];

                // Obtener el valor de una celda específica (por ejemplo, la primera celda)
                string cellValue = selectedRow.Cells[0].ToString();

                // Asignar el valor de la celda al TextBox
                txtIdEspecialidad.Text = cellValue;
            }

        }

       
    }
}