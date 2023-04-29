using DAL.MANTENIMIENTOS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Promociones_BLL
    {
        #region METODOS 

        public void List_Promo(ref cls_Promociones_DAL Obj_Promo_DAL)
        {

            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();


            if (Obj_Promo_DAL.uID_Promocion == 0)
            {
                Obj_Promo_DAL.dtParametros = null;
                Obj_Promo_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.PROMOCIONES", ConfigurationManager.AppSettings["LISTAR_PROMOCIONES"], null);
            }
            else
            {
                Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

                Obj_Promo_DAL.dtParametros.Rows.Add("@ID_PROMOCION", "1", Obj_Promo_DAL.uID_Promocion);

                Obj_Promo_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.PROMOCIONES", ConfigurationManager.AppSettings["FILTRAR_PROMOCIONES"], Obj_Promo_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Promo(ref cls_Promociones_DAL Obj_Promo_DAL)
        {
            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();


            Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

            //Obj_Promo_DAL.dtParametros.Rows.Add("@IDPROMOCION", "1", Obj_Promo_DAL.uID_Promocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@ID_SERVICIO", "1", Obj_Promo_DAL.uID_Servicio);
            Obj_Promo_DAL.dtParametros.Rows.Add("@MONTO_PROMOCION", "3", Obj_Promo_DAL.fMontoPromocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@DETALLE_PROMOCION", "6", Obj_Promo_DAL.sDetallePromocion);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Promo_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_PROMOCIONES"], "aaa", Obj_Promo_DAL.dtParametros);
        }

        public void Modificar_Promo(ref cls_Promociones_DAL Obj_Promo_DAL)
        {

            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();



            Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

            Obj_Promo_DAL.dtParametros.Rows.Add("@ID_PROMOCION", "1", Obj_Promo_DAL.uID_Promocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@ID_SERVICIO", "1", Obj_Promo_DAL.uID_Servicio);
            Obj_Promo_DAL.dtParametros.Rows.Add("@MONTO_PROMOCION", "3", Obj_Promo_DAL.fMontoPromocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@DETALLE_PROMOCION", "6", Obj_Promo_DAL.sDetallePromocion);


            Obj_Promo_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_PROMOCIONES"], "NORMAL", Obj_Promo_DAL.dtParametros);


        }

        //ELIMINAR

        public void Eliminar_Promo(ref cls_Promociones_DAL Obj_Promo_DAL)
        {
            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();

            Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

            Obj_Promo_DAL.dtParametros.Rows.Add("@ID_PROMOCION", "1", Obj_Promo_DAL.uID_Promocion);

            Obj_Promo_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_PROMOCIONES"], "NORMAL", Obj_Promo_DAL.dtParametros);
           
        }
        #endregion
    }
}
