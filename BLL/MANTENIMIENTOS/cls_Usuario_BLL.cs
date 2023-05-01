using DAL.MANTENIMIENTOS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MANTENIMIENTOS
{
     public class cls_Usuario_BLL
    {
        #region METODOS 

        public void List_Usuario(ref cls_Usuario_DAL Obj_Usuario_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            if (Obj_Usuario_DAL.sNombreUsuario == "")
            {
                Obj_Usuario_DAL.dtParametros = null;
                Obj_Usuario_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.USUARIOS", ConfigurationManager.AppSettings["LISTAR_USUARIO"], null);
            }
            else
            {
                Obj_Usuario_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Usuario_DAL.dtParametros);

                Obj_Usuario_DAL.dtParametros.Rows.Add("@nombreUsuario", "6", Obj_Usuario_DAL.sNombreUsuario);

                Obj_Usuario_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.USUARIOS", ConfigurationManager.AppSettings["FILTRAR_USUARIO"], Obj_Usuario_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Usuario(ref cls_Usuario_DAL Obj_Usuario_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            Obj_Usuario_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Usuario_DAL.dtParametros);

            Obj_Usuario_DAL.dtParametros.Rows.Add("@idUsuario", "1", Obj_Usuario_DAL.uID_Usuario);
            Obj_Usuario_DAL.dtParametros.Rows.Add("@nombreUsuario", "6", Obj_Usuario_DAL.sNombreUsuario);
            Obj_Usuario_DAL.dtParametros.Rows.Add("@contraseñaUsuario", "6", Obj_Usuario_DAL.sPasswordUsuario);


            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Usuario_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_USUARIO"], "NORMAL", Obj_Usuario_DAL.dtParametros);
        }

        public void Modificar_Usuario(ref cls_Usuario_DAL Obj_Usuario_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            Obj_Usuario_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Usuario_DAL.dtParametros);

            Obj_Usuario_DAL.dtParametros.Rows.Add("@idUsuario", "1", Obj_Usuario_DAL.uID_Usuario);
            Obj_Usuario_DAL.dtParametros.Rows.Add("@nombreUsuario", "6", Obj_Usuario_DAL.sNombreUsuario);
            Obj_Usuario_DAL.dtParametros.Rows.Add("@contraseñaUsuario", "6", Obj_Usuario_DAL.sPasswordUsuario);

            Obj_Usuario_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_USUARIO"], "NORMAL", Obj_Usuario_DAL.dtParametros);


        }

        //ELIMINAR

        public void Eliminar_Usuario(ref cls_Usuario_DAL Obj_Usuario_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Usuario_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Usuario_DAL.dtParametros);

            Obj_Usuario_DAL.dtParametros.Rows.Add("@IdUsuario", "2", Obj_Usuario_DAL.uID_Usuario);

            Obj_Usuario_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_USUARIO"], "NORMAL", Obj_Usuario_DAL.dtParametros);
        }
        #endregion
    }
}
