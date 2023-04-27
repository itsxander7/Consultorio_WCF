using DAL.MANTENIMIENTOS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Expediente_BLL
    {
        #region METODOS 

        public void List_Expediente(ref cls_Expediente_DAL Obj_Expediente_DAL)
        {

            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();


            if (Obj_Expediente_DAL.uID_Expediente == 0)
            {
                Obj_Expediente_DAL.dtParametros = null;
                Obj_Expediente_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.EXPEDIENTE", ConfigurationManager.AppSettings["LISTAR_EXPEDIENTE"], null);
            }
            else
            {
                Obj_Expediente_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Expediente_DAL.dtParametros);

                Obj_Expediente_DAL.dtParametros.Rows.Add("@ID_Expediente", "2", Obj_Expediente_DAL.uID_Expediente);

                Obj_Expediente_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.EXPEDIENTE", ConfigurationManager.AppSettings["FILTRAR_EXPEDIENTE"], Obj_Expediente_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Expediente(ref cls_Expediente_DAL Obj_Expediente_DAL)
        {
            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();





            Obj_Expediente_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Expediente_DAL.dtParametros);

            Obj_Expediente_DAL.dtParametros.Rows.Add("@IdExpediente", "2", Obj_Expediente_DAL.uID_Expediente);
            Obj_Expediente_DAL.dtParametros.Rows.Add("@IdCliente", "2", Obj_Expediente_DAL.uID_Cliente);
            Obj_Expediente_DAL.dtParametros.Rows.Add("@IdDoctor", "2", Obj_Expediente_DAL.uID_Doctor);
            Obj_Expediente_DAL.dtParametros.Rows.Add("@DetalleExpediente", "8", Obj_Expediente_DAL.sDetalleExpediente);
           
            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Expediente_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_EXPEDIENTE"], "NORMAL", Obj_Expediente_DAL.dtParametros);
        }

        public void Modificar_Expediente(ref cls_Expediente_DAL Obj_Expediente_DAL)
        {

            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();



            Obj_Expediente_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Expediente_DAL.dtParametros);

            Obj_Expediente_DAL.dtParametros.Rows.Add("@IdExpediente", "2", Obj_Expediente_DAL.uID_Expediente);
            Obj_Expediente_DAL.dtParametros.Rows.Add("@IdCliente", "2", Obj_Expediente_DAL.uID_Cliente);
            Obj_Expediente_DAL.dtParametros.Rows.Add("@IdDoctor", "2", Obj_Expediente_DAL.uID_Doctor);
            Obj_Expediente_DAL.dtParametros.Rows.Add("@DetalleExpediente", "8", Obj_Expediente_DAL.sDetalleExpediente);



            Obj_Expediente_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_EXPEDIENTE"], "NORMAL", Obj_Expediente_DAL.dtParametros);


        }

        //ELIMINAR

        public void Eliminar_Expediente(ref cls_Expediente_DAL Obj_Expediente_DAL)
        {
            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();

            Obj_Expediente_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Expediente_DAL.dtParametros);

            Obj_Expediente_DAL.dtParametros.Rows.Add("@IdExpediente", "2", Obj_Expediente_DAL.uID_Expediente);

            Obj_Expediente_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_EXPEDIENTE"], "NORMAL", Obj_Expediente_DAL.dtParametros);
        }
        #endregion
    }
}

