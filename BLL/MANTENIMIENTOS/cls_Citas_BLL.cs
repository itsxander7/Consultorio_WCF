using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Citas_BLL
    {

        #region Metodos
        // LISTAR Y FILTRAR
        public void List_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            if (Obj_Citas_DAL.iIdCita == 0)
            {
                Obj_Citas_DAL.dtParametros = null;
                Obj_Citas_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.CITAS", ConfigurationManager.AppSettings["LISTAR_CITAS"], null);
            }
            else
            {
                Obj_Citas_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.dtParametros);

                Obj_Citas_DAL.dtParametros.Rows.Add("@idCita", "1", Obj_Citas_DAL.iIdCita);

                Obj_Citas_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.CITAS", ConfigurationManager.AppSettings["FILTRAR_CITAS"], Obj_Citas_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Citas_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.dtParametros);

            Obj_Citas_DAL.dtParametros.Rows.Add("@idCliente", "1", Obj_Citas_DAL.iIdCliente);
            Obj_Citas_DAL.dtParametros.Rows.Add("@idEspecialidad", "1", Obj_Citas_DAL.iIdEspecialidad);
            Obj_Citas_DAL.dtParametros.Rows.Add("@idDoctor", "1", Obj_Citas_DAL.iIdDoctor);
            Obj_Citas_DAL.dtParametros.Rows.Add("@fecha", "8", Obj_Citas_DAL.dtFecha);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Citas_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_CITAS"], "insert", Obj_Citas_DAL.dtParametros);
        }

        public void Modificar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            Obj_Citas_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.dtParametros);

            Obj_Citas_DAL.dtParametros.Rows.Add("@id_cita", "6", Obj_Citas_DAL.iIdCita);
            Obj_Citas_DAL.dtParametros.Rows.Add("@id_cliente", "6", Obj_Citas_DAL.iIdCliente);
            Obj_Citas_DAL.dtParametros.Rows.Add("@id_especialidad", "6", Obj_Citas_DAL.iIdEspecialidad);
            Obj_Citas_DAL.dtParametros.Rows.Add("@id_doctor", "6", Obj_Citas_DAL.iIdDoctor);
            Obj_Citas_DAL.dtParametros.Rows.Add("@fecha", "6", Obj_Citas_DAL.dtFecha);


            Obj_Citas_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_CITAS"], "NORMAL", Obj_Citas_DAL.dtParametros);



        }

        //ELIMINAR

        public void Eliminar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Citas_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.dtParametros);

            Obj_Citas_DAL.dtParametros.Rows.Add("@ID_CITA", "1", Obj_Citas_DAL.iIdCita);

            Obj_Citas_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_CITAS"], "NORMAL", Obj_Citas_DAL.dtParametros);
        }
        #endregion
    }
}
