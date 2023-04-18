using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;

using System.Configuration;

namespace BLL.MANTENIMIENTOS
{
    public class cls_regiones_BLL
    {
       /* public void List_Filt_TERRITORIOS (ref cls_regiones_DAL Obj_Regiones_DAL )
        {
           WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Regiones_DAL.sTerritoryDescription == string.Empty)
            {
                Obj_Regiones_DAL.DtParametros = null;
                Obj_Regiones_DAL.DtDatos = Obj_WCF.ListarFiltrar("TERRITORIOS", ConfigurationManager.AppSettings["LISTAR_TERRITORIOS"], null);
            }
            else
            {
                Obj_Regiones_DAL.DtParametros = Obj_WCF.Get_DT_Param(Obj_Regiones_DAL.DtParametros);

                Obj_Regiones_DAL.DtParametros.Rows.Add("@FILTRO", "5", Obj_Regiones_DAL.sTerritoryDescription);

                Obj_Regiones_DAL.DtDatos = Obj_WCF.ListarFiltrar("TERRITORIOS", ConfigurationManager.AppSettings["FILTRAR_TERRITORIOS"], Obj_Regiones_DAL.DtParametros);
            }
        }

        public void Guardar_TERRITORIOS(ref cls_regiones_DAL Obj_Regiones_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Regiones_DAL.DtParametros = Obj_WCF.Get_DT_Param(Obj_Regiones_DAL.DtParametros);

            Obj_Regiones_DAL.DtParametros.Rows.Add("@TerritoryID", "6", Obj_Regiones_DAL.sTerritoryID);
            Obj_Regiones_DAL.DtParametros.Rows.Add("@TerritoryDescription", "5", Obj_Regiones_DAL.sTerritoryDescription);
            Obj_Regiones_DAL.DtParametros.Rows.Add("@RegionID", "1", Obj_Regiones_DAL.iRegionId);

            Obj_Regiones_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_TERRITORIOS"], "NORMAL", Obj_Regiones_DAL.DtParametros);
        }

        public void Eliminar_TERRITORIOS(ref cls_regiones_DAL Obj_Regiones_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            Obj_Regiones_DAL.DtParametros = Obj_WCF.Get_DT_Param(Obj_Regiones_DAL.DtParametros);

            Obj_Regiones_DAL.DtParametros.Rows.Add("@TerritoryID", "1", Obj_Regiones_DAL.sTerritoryID);

            Obj_Regiones_DAL.sMsjError = Obj_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_TERRITORIOS"], "NORMAL", Obj_Regiones_DAL.DtParametros);
        }

        public void List_Filt_REGIONES(ref cls_regiones_DAL Obj_Regiones_DAL)
        {
            WCF.BDClient Obj_WCF = new BDClient();

            if (Obj_Regiones_DAL.sTerritoryDescription == string.Empty)
            {
                Obj_Regiones_DAL.DtParametros = null;
                Obj_Regiones_DAL.DtDatos = Obj_WCF.ListarFiltrar("REGIONES", ConfigurationManager.AppSettings["LISTAR_REGIONES"], null);
            }
            else
            {
                Obj_Regiones_DAL.DtParametros = Obj_WCF.Get_DT_Param(Obj_Regiones_DAL.DtParametros);

                Obj_Regiones_DAL.DtParametros.Rows.Add("@FILTRO", "5", Obj_Regiones_DAL.sTerritoryDescription);

                Obj_Regiones_DAL.DtDatos = Obj_WCF.ListarFiltrar("REGIONES", ConfigurationManager.AppSettings["FILTRAR_REGIONES"], Obj_Regiones_DAL.DtParametros);
            }
        }*/

    }
}
