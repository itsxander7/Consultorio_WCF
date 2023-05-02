using BLL.MANTENIMIENTOS;
using DAL.MANTENIMIENTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL.Pantallas.Formularios
{
    public partial class Doctores : System.Web.UI.Page
    {
        cls_Doctores_BLL Obj_BLL = new cls_Doctores_BLL();
        cls_Doctores_DAL Obj_DAL = new cls_Doctores_DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarEspecialidad();
            CargarDatos();
            CargarUsuario();
        }

        private void CargarDatos()
        {
            if (txtBuscarDoctor.Text == string.Empty)
            {
                Obj_DAL.iIdDoctor = 0;
            }
            else
            {
                Obj_DAL.iIdDoctor = Convert.ToInt32(txtBuscarDoctor.Text.Trim());

            }
            Obj_BLL.List_Doctores(ref Obj_DAL);

            dgvDoctores.DataSource = null;
            dgvDoctores.DataSource = Obj_DAL.dtDatos;
            dgvDoctores.DataBind();

        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();

        }
        public void InsertarDoctor()
        {
            Obj_DAL.iIdDoctor = Convert.ToInt32(TxtIdDoctor.Text.Trim());
            Obj_DAL.iCedula = Convert.ToInt32(txtCedula.Text.Trim());
            Obj_DAL.iIdEspecialidad = 16;
            Obj_DAL.sNombreDoctor = TxtNombreDoctor.Text.Trim();
            Obj_DAL.sApellido1Doctor = TxtApellido2Doctor.Text.Trim();
            Obj_DAL.sApellido2Doctor = TxtApellido1Doctor.Text.Trim();
            Obj_DAL.iTelefonoDoctor = Convert.ToInt32(TxtTelefonoDoctor.Text.Trim());
            Obj_DAL.sCorreoDoctor = TxtCorreoDoctor.Text.Trim();
            Obj_DAL.iIdUsuario = 123;
            Obj_BLL.Guardar_Doctores(ref Obj_DAL);
            CargarDatos();
        }
        public void EditaDoctor()
        {
            Obj_DAL.iIdDoctor = Convert.ToInt32(TxtIdDoctor.Text.Trim());
            Obj_DAL.iCedula = Convert.ToInt32(txtCedula.Text.Trim());
            Obj_DAL.iIdEspecialidad = 16;
            Obj_DAL.sNombreDoctor = TxtNombreDoctor.Text.Trim();
            Obj_DAL.sApellido1Doctor = TxtApellido2Doctor.Text.Trim();
            Obj_DAL.sApellido2Doctor = TxtApellido1Doctor.Text.Trim();
            Obj_DAL.iTelefonoDoctor = Convert.ToInt32(TxtTelefonoDoctor.Text.Trim());
            Obj_DAL.sCorreoDoctor = TxtCorreoDoctor.Text.Trim();
            Obj_BLL.Modificar_Doctores(ref Obj_DAL);
            CargarDatos();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            EditaDoctor();
            CargarDatos();
        }

        protected void btnInsertar_Click1(object sender, EventArgs e)
        {
            InsertarDoctor();
            CargarDatos();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Obj_DAL.iIdDoctor = Convert.ToInt32(TxtIdDoctor.Text.Trim());
            Obj_DAL.iCedula = Convert.ToInt32(txtCedula.Text.Trim());
            Obj_BLL.Eliminar_Doctor(ref Obj_DAL);
            TxtIdDoctor.Text = string.Empty;
            CargarDatos();
        }
        private void CargarEspecialidad()
        {
            Obj_DAL.iIdEspecialidad = 0;
            Obj_BLL.Desplegar_Especialidad(ref Obj_DAL);

            Obj_DAL.dtDatos.Rows.Add("0","--SELECCIONE UNA ESPECIALIDAD--");
            cmbEspecialidad.DataSource = null;
            cmbEspecialidad.DataTextField = "NOMBRE_ESPECIALIDAD";
            cmbEspecialidad.DataValueField = "ID_ESPECIALIDAD";
            cmbEspecialidad.DataSource = Obj_DAL.dtDatos;
            cmbEspecialidad.DataBind();

            cmbEspecialidad.SelectedValue = "0";


        }
        private void CargarUsuario()
        {
            Obj_DAL.iIdUsuario = 0;
            Obj_BLL.Desplegar_Usuario(ref Obj_DAL);

            Obj_DAL.dtDatos.Rows.Add("0", "--SELECCIONE UN USUARIO--");
            cmbUsuario.DataSource = null;
            cmbUsuario.DataTextField = "NOMBRE_USUARIO";
            cmbUsuario.DataValueField = "ID_USUARIO";
            cmbUsuario.DataSource = Obj_DAL.dtDatos;
            cmbUsuario.DataBind();

            cmbUsuario.SelectedValue = "0";


        }

       
    }
}