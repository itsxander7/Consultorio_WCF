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

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();


            if (Obj_Promo_DAL.uID_Promocion == 0)
            {
                Obj_Promo_DAL.dtParametros = null;
                Obj_Promo_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.PROMOCIONES", ConfigurationManager.AppSettings["LISTAR_PROMOCION"], null);
            }
            else
            {
                Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

                Obj_Promo_DAL.dtParametros.Rows.Add("@IdPromocion", "2", Obj_Promo_DAL.uID_Promocion);

                Obj_Promo_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.PROMOCIONES", ConfigurationManager.AppSettings["FILTRAR_PROMOCION"], Obj_Promo_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Promo(ref cls_Promociones_DAL Obj_Promo_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();





            Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

            Obj_Promo_DAL.dtParametros.Rows.Add("@IdPromocion", "2", Obj_Promo_DAL.uID_Promocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@IdServicio", "2", Obj_Promo_DAL.uID_Servicio);
            Obj_Promo_DAL.dtParametros.Rows.Add("@MontoPromocion", "6", Obj_Promo_DAL.fMontoPromocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@DetallePromo", "8", Obj_Promo_DAL.sDetallePromocion);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Promo_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_PROMOCION"], "NORMAL", Obj_Promo_DAL.dtParametros);
        }

        public void Modificar_Promo(ref cls_Promociones_DAL Obj_Promo_DAL)
        {

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();



            Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

            Obj_Promo_DAL.dtParametros.Rows.Add("@IdPromocion", "2", Obj_Promo_DAL.uID_Promocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@IdServicio", "2", Obj_Promo_DAL.uID_Servicio);
            Obj_Promo_DAL.dtParametros.Rows.Add("@MontoPromocion", "6", Obj_Promo_DAL.fMontoPromocion);
            Obj_Promo_DAL.dtParametros.Rows.Add("@DetallePromo", "8", Obj_Promo_DAL.sDetallePromocion);


            Obj_Promo_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_PROMOCION"], "NORMAL", Obj_Promo_DAL.dtParametros);


        }

        //ELIMINAR

        public void Eliminar_Promo(ref cls_Promociones_DAL Obj_Promo_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();

            Obj_Promo_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Promo_DAL.dtParametros);

            Obj_Promo_DAL.dtParametros.Rows.Add("@IdPromocion", "2", Obj_Promo_DAL.uID_Promocion);

            Obj_Promo_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_PROMOCION"], "NORMAL", Obj_Promo_DAL.dtParametros);
        }
        #endregion
    }
}
