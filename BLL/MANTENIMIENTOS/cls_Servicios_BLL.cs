using DAL.MANTENIMIENTOS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Servicios_BLL
    {
        #region METODOS 

        public void List_Servicio(ref cls_Servicios_DAL Obj_Servicio_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            if (Obj_Servicio_DAL.uID_Servicio == 0)
            {
                Obj_Servicio_DAL.dtParametros = null;
                Obj_Servicio_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.SERVICIO", ConfigurationManager.AppSettings["LISTAR_SERVICIO"], null);
            }
            else
            {
                Obj_Servicio_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Servicio_DAL.dtParametros);

                Obj_Servicio_DAL.dtParametros.Rows.Add("@IdServicio", "1", Obj_Servicio_DAL.uID_Servicio);

                Obj_Servicio_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.Servicio", ConfigurationManager.AppSettings["FILTRAR_SERVICIO"], Obj_Servicio_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Servicio(ref cls_Servicios_DAL Obj_Servicio_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();





            Obj_Servicio_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Servicio_DAL.dtParametros);

            Obj_Servicio_DAL.dtParametros.Rows.Add("@IdServicio", "1", Obj_Servicio_DAL.uID_Servicio);
            Obj_Servicio_DAL.dtParametros.Rows.Add("@IdEspecialidad", "1", Obj_Servicio_DAL.uID_Especialidad);
            Obj_Servicio_DAL.dtParametros.Rows.Add("@DetalleServicio", "8", Obj_Servicio_DAL.sDetalleServicio);
            Obj_Servicio_DAL.dtParametros.Rows.Add("@CostoServicio", "6", Obj_Servicio_DAL.fCostoServicio);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Servicio_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_SERVICIO"], "NORMAL", Obj_Servicio_DAL.dtParametros);
        }

        public void Modificar_Servicio(ref cls_Servicios_DAL Obj_Servicio_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();



            Obj_Servicio_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Servicio_DAL.dtParametros);

            Obj_Servicio_DAL.dtParametros.Rows.Add("@IdServicio", "1", Obj_Servicio_DAL.uID_Servicio);
            Obj_Servicio_DAL.dtParametros.Rows.Add("@IdEspecialidad", "1", Obj_Servicio_DAL.uID_Especialidad);
            Obj_Servicio_DAL.dtParametros.Rows.Add("@DetalleServicio", "8", Obj_Servicio_DAL.sDetalleServicio);
            Obj_Servicio_DAL.dtParametros.Rows.Add("@CostoServicio", "6", Obj_Servicio_DAL.fCostoServicio);



            Obj_Servicio_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_SERVICIO"], "NORMAL", Obj_Servicio_DAL.dtParametros);


        }

        //ELIMINAR

        public void Eliminar_Servicio(ref cls_Servicios_DAL Obj_Servicio_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Servicio_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Servicio_DAL.dtParametros);

            Obj_Servicio_DAL.dtParametros.Rows.Add("@IdServicio", "2", Obj_Servicio_DAL.uID_Servicio);

            Obj_Servicio_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_SERVICIO"], "NORMAL", Obj_Servicio_DAL.dtParametros);
        }
        #endregion
    }
}
