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
            CargarDatos();
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarDoctor();
        }
        private void CargarDatos()
        {
            if (txtBuscarDoctor.Text == string.Empty)
            {
                Obj_DAL.IIdDoctor = 0;
            }
            else
            {
                Obj_DAL.IIdDoctor = Convert.ToInt32(txtBuscarDoctor.Text.Trim());
            }
            Obj_BLL.List_Doctores(ref Obj_DAL);

            dgvDoctores.DataSource = null;
            dgvDoctores.DataSource = Obj_DAL.DtDatos;
            dgvDoctores.DataBind();

        }

        protected void BtnMostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();

        }
        public void InsertarDoctor()
        {
            Obj_DAL.IIdDoctor = Convert.ToInt32(TxtIdDoctor.Text.Trim());
            Obj_DAL.iCedula = Convert.ToInt32(txtCedula.Text.Trim());
            Obj_DAL.IIdEspecialidad = 16;
            Obj_DAL.SNombreDoctor = TxtNombreDoctor.Text.Trim();
            Obj_DAL.SApellido1Doctor = TxtApellido2Doctor.Text.Trim();
            Obj_DAL.SApellido2Doctor = TxtApellido1Doctor.Text.Trim();
            Obj_DAL.iTelefonoDoctor = Convert.ToInt32(TxtTelefonoDoctor.Text.Trim());
            Obj_DAL.SCorreoDoctor = TxtCorreoDoctor.Text.Trim();
            Obj_DAL.IIdUsuario = 123;
            Obj_BLL.Guardar_Doctores(ref Obj_DAL);
            CargarDatos();
        }
        public void EditaDoctor()
        {
            Obj_DAL.IIdDoctor = Convert.ToInt32(TxtIdDoctor.Text.Trim());
            Obj_DAL.iCedula = Convert.ToInt32(txtCedula.Text.Trim());
            Obj_DAL.IIdEspecialidad = 16;
            Obj_DAL.SNombreDoctor = TxtNombreDoctor.Text.Trim();
            Obj_DAL.SApellido1Doctor = TxtApellido2Doctor.Text.Trim();
            Obj_DAL.SApellido2Doctor = TxtApellido1Doctor.Text.Trim();
            Obj_DAL.iTelefonoDoctor = Convert.ToInt32(TxtTelefonoDoctor.Text.Trim());
            Obj_DAL.SCorreoDoctor = TxtCorreoDoctor.Text.Trim();
            Obj_BLL.Modificar_Doctores(ref Obj_DAL);
            CargarDatos();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            EditaDoctor();
        }
    }
}