using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;

namespace BLL.MANTENIMIENTOS
{
    class cls_Citas_BLL
    {

        // LISTAR Y FILTRAR
        public void List_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();


            if (Obj_Citas_DAL.ID_CITA == 0)
            {
                Obj_Citas_DAL.DtParametros = null;
                Obj_Citas_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.CLIENTES", ConfigurationManager.AppSettings["LISTAR_CITAS"], null);
            }
            else
            {
                Obj_Citas_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.DtParametros);

                Obj_Citas_DAL.DtParametros.Rows.Add("@id_cita", "1", Obj_Citas_DAL.ID_CLIENTE);

                Obj_Citas_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.CITAS", ConfigurationManager.AppSettings["FILTRAR_CITAS"], Obj_Citas_DAL.DtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Citas(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();





            Obj_Citas_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.DtParametros);

            Obj_Citas_DAL.DtParametros.Rows.Add("@id_cita", "6", Obj_Citas_DAL.ID_CITA);
            Obj_Citas_DAL.DtParametros.Rows.Add("@id_cliente", "6", Obj_Citas_DAL.ID_CLIENTE);
            Obj_Citas_DAL.DtParametros.Rows.Add("@id_especialidad", "6", Obj_Citas_DAL.ID_ESPECIALIDAD);
            Obj_Citas_DAL.DtParametros.Rows.Add("@id_doctor", "6", Obj_Citas_DAL.ID_DOCTOR);
            Obj_Citas_DAL.DtParametros.Rows.Add("@fecha", "6", Obj_Citas_DAL.FECHA);






            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Citas_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_CITAS"], "NORMAL", Obj_Citas_DAL.DtParametros);
        }

        public void Modificar_CITAS(ref cls_Citas_DAL Obj_Citas_DAL)
        {

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();



            Obj_Citas_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.DtParametros);

            Obj_Citas_DAL.DtParametros.Rows.Add("@id_cita", "6", Obj_Citas_DAL.ID_CITA);
            Obj_Citas_DAL.DtParametros.Rows.Add("@id_cliente", "6", Obj_Citas_DAL.ID_CLIENTE);
            Obj_Citas_DAL.DtParametros.Rows.Add("@id_especialidad", "6", Obj_Citas_DAL.ID_ESPECIALIDAD);
            Obj_Citas_DAL.DtParametros.Rows.Add("@id_doctor", "6", Obj_Citas_DAL.ID_DOCTOR);
            Obj_Citas_DAL.DtParametros.Rows.Add("@fecha", "6", Obj_Citas_DAL.FECHA);



            Obj_Citas_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_CITAS"], "NORMAL", Obj_Citas_DAL.DtParametros);


        }

        //ELIMINAR

        public void Eliminar_CITAS(ref cls_Citas_DAL Obj_Citas_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();

            Obj_Citas_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Citas_DAL.DtParametros);

            Obj_Citas_DAL.DtParametros.Rows.Add("@id_cita", "1", Obj_Citas_DAL.ID_CLIENTE);

            Obj_Citas_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_CITAS"], "NORMAL", Obj_Citas_DAL.DtParametros);
        }
    }
}
