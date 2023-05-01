using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.MANTENIMIENTOS;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Roles_BLL
    {
        // LISTAR Y FILTRAR
        public void List_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            if (Obj_Roles_DAL.uID_Rol == 0)
            {
                Obj_Roles_DAL.dtParametros = null;
                Obj_Roles_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.ROLES", ConfigurationManager.AppSettings["LISTAR_ROLES"], null);
            }
            else
            {
                Obj_Roles_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Roles_DAL.dtParametros);

                Obj_Roles_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_Roles_DAL.uID_Rol);

                Obj_Roles_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.ROLES", ConfigurationManager.AppSettings["FILTRAR_ROLES"], Obj_Roles_DAL.dtParametros);
            }
        }

        //GUARDAR
        public void Guardar_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Roles_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Roles_DAL.dtParametros);

            Obj_Roles_DAL.dtParametros.Rows.Add("@ID_ROL", "1", Obj_Roles_DAL.uID_Rol);
            Obj_Roles_DAL.dtParametros.Rows.Add("@TIPO_ROL", "6", Obj_Roles_DAL.sTipoRol);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Roles_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_ROLES"], "NORMAL", Obj_Roles_DAL.dtParametros);
        }

        //ACTUALIZAR
        public void Modificar_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Roles_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Roles_DAL.dtParametros);

            Obj_Roles_DAL.dtParametros.Rows.Add("@ID_ROL", "1", Obj_Roles_DAL.uID_Rol);
            Obj_Roles_DAL.dtParametros.Rows.Add("@TIPO_ROL", "6", Obj_Roles_DAL.sTipoRol);

            Obj_Roles_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_ROLES"], "NORMAL", Obj_Roles_DAL.dtParametros);

        }

        //ELIMINAR
        public void Eliminar_Roles(ref cls_Roles_DAL Obj_Roles_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Roles_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Roles_DAL.dtParametros);

            Obj_Roles_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_Roles_DAL.uID_Rol);

            Obj_Roles_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_ROLES"], "NORMAL", Obj_Roles_DAL.dtParametros);
        }
    }
}
