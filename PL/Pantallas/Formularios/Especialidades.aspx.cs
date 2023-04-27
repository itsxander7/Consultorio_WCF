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
    public partial class Especialidades : System.Web.UI.Page
    {
        cls_Especialidades_BLL Obj_BLL = new cls_Especialidades_BLL();
        cls_Especialidades_DAL Obj_DAL = new cls_Especialidades_DAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Obj_DAL.IIdEspecialidad =Convert.ToInt32(TxtIdEspecialidad.Text.Trim());

            Obj_BLL.Guardar_Especialidades(ref Obj_DAL); 


        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            Obj_DAL.IIdEspecialidad = Convert.ToInt32(TxtIdEspecialidad.Text.Trim());

            Obj_BLL.Modificar_Especialidades(ref Obj_DAL);

        }
    }
}