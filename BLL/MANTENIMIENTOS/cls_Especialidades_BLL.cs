﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;
using System.Configuration;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Especialidades_BLL
    {

        // LISTAR Y FILTRAR
        public void List_Especialidades(ref cls_Especialidades_DAL Obj_Especialidad_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            if (Obj_Especialidad_DAL.iIdEspecialidad == 0)
            {
                Obj_Especialidad_DAL.DtParametros = null;
                Obj_Especialidad_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.ESPECIALIDADES", ConfigurationManager.AppSettings["LISTAR_ESPECIALIDADES"], null);
            }
            else
            {
                Obj_Especialidad_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Especialidad_DAL.DtParametros);

                Obj_Especialidad_DAL.DtParametros.Rows.Add("@Id_Especialidad", "1", Obj_Especialidad_DAL.iIdEspecialidad);

                Obj_Especialidad_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.ESPECIALIDADES", ConfigurationManager.AppSettings["FILTRAR_ESPECIALIDADES"], Obj_Especialidad_DAL.DtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Especialidades(ref cls_Especialidades_DAL Obj_Especialidad_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Especialidad_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Especialidad_DAL.DtParametros);

            Obj_Especialidad_DAL.DtParametros.Rows.Add("@Nombre_Especialidad", "6", Obj_Especialidad_DAL.sNombreEspecialidad);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Especialidad_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_ESPECIALIDADES"], "NORMAL", Obj_Especialidad_DAL.DtParametros);
        }


        public void Modificar_Especialidades(ref cls_Especialidades_DAL Obj_Especialidad_DAL)
        {
 
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();



            Obj_Especialidad_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Especialidad_DAL.DtParametros);

            Obj_Especialidad_DAL.DtParametros.Rows.Add("@Id_Especialidad", "1", Obj_Especialidad_DAL.iIdEspecialidad);
            Obj_Especialidad_DAL.DtParametros.Rows.Add("@Nombre_Especialidad", "6", Obj_Especialidad_DAL.sNombreEspecialidad);



            Obj_Especialidad_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_ESPECIALIDADES"], "NORMAL", Obj_Especialidad_DAL.DtParametros);


        }

        //ELIMINAR

        public void Eliminar_Especialidades(ref cls_Especialidades_DAL Obj_Especialidad_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Especialidad_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Especialidad_DAL.DtParametros);

            Obj_Especialidad_DAL.DtParametros.Rows.Add("@Id_Especialidad", "1", Obj_Especialidad_DAL.iIdEspecialidad);

            Obj_Especialidad_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_ESPECIALIDADES"], "NORMAL", Obj_Especialidad_DAL.DtParametros);
        }
    }
}
