using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;
using System.Configuration;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Doctores_BLL
    {

        // LISTAR Y FILTRAR
        public void List_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            if (Obj_Doctores_DAL.iIdDoctor== 0)
            {
                Obj_Doctores_DAL.dtParametros = null;
                Obj_Doctores_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DOCTORES", ConfigurationManager.AppSettings["LISTAR_DOCTORES"], null);
            }
            else
            {
                Obj_Doctores_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctores_DAL.dtParametros);

                Obj_Doctores_DAL.dtParametros.Rows.Add("@ID_Doctor","1", Obj_Doctores_DAL.iIdDoctor);

                Obj_Doctores_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DOCTORES", ConfigurationManager.AppSettings["FILTRAR_DOCTORES"], Obj_Doctores_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Doctores_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctores_DAL.dtParametros);

            Obj_Doctores_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Doctores_DAL.iIdDoctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Cedula", "1", Obj_Doctores_DAL.iCedula);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Id_Especialidad", "1", Obj_Doctores_DAL.iIdEspecialidad);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Nombre_Doctor", "6", Obj_Doctores_DAL.sNombreDoctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Apellido1_Doctor", "6", Obj_Doctores_DAL.sApellido1Doctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Apellido2_Doctor", "6", Obj_Doctores_DAL.sApellido2Doctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Telefono_Doctor", "1", Obj_Doctores_DAL.iTelefonoDoctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Correo_Doctor", "6", Obj_Doctores_DAL.sCorreoDoctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Id_Usuario", "1", Obj_Doctores_DAL.iIdUsuario);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Doctores_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_DOCTOR"], "NORMAL", Obj_Doctores_DAL.dtParametros);
        }

        public void Modificar_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();



            Obj_Doctores_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctores_DAL.dtParametros);

            Obj_Doctores_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Doctores_DAL.iIdDoctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Cedula", "1", Obj_Doctores_DAL.iCedula);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Id_Especialidad", "1", Obj_Doctores_DAL.iIdEspecialidad);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Nombre_Doctor", "6", Obj_Doctores_DAL.sNombreDoctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Apellido1_Doctor", "6", Obj_Doctores_DAL.sApellido1Doctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Apellido2_Doctor", "6", Obj_Doctores_DAL.sApellido2Doctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Telefono_Doctor", "1", Obj_Doctores_DAL.iTelefonoDoctor);
            Obj_Doctores_DAL.dtParametros.Rows.Add("@Correo_Doctor", "6", Obj_Doctores_DAL.sCorreoDoctor);
           



            Obj_Doctores_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_DOCTOR"], "NORMAL", Obj_Doctores_DAL.dtParametros);


        }

        //ELIMINAR

        public void Eliminar_Doctor(ref cls_Doctores_DAL Obj_Doctor_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Doctor_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctor_DAL.dtParametros);

            Obj_Doctor_DAL.dtParametros.Rows.Add("@ID_Doctor", "1", Obj_Doctor_DAL.iIdDoctor);
            Obj_Doctor_DAL.dtParametros.Rows.Add("@Cedula", "1", Obj_Doctor_DAL.iCedula);

            Obj_Doctor_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_DOCTORES"], "NORMAL", Obj_Doctor_DAL.dtParametros);
        }
        public void Desplegar_Especialidad(ref cls_Doctores_DAL Obj_Especialidad_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();



            if (Obj_Especialidad_DAL.iIdEspecialidad == 0)
            {
                Obj_Especialidad_DAL.dtParametros = null;
                Obj_Especialidad_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.ESPECIALIDADES", ConfigurationManager.AppSettings["DESPLEGAR_ESPECIALIDAD"], null);
            }
            else
            {
                Obj_Especialidad_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Especialidad_DAL.dtParametros);
                Obj_Especialidad_DAL.dtParametros.Rows.Add("@ID", "1", Obj_Especialidad_DAL.iIdEspecialidad);
                Obj_Especialidad_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.ESPECIALIDADES", ConfigurationManager.AppSettings["DESPLEGAR_ESPECIALIDAD"], Obj_Especialidad_DAL.dtParametros);
            }
        }
        public void Desplegar_Usuario(ref cls_Doctores_DAL Obj_Especialidad_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();



            if (Obj_Especialidad_DAL.iCedula == 0)
            {
                Obj_Especialidad_DAL.dtParametros = null;
                Obj_Especialidad_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.USUARIOS", ConfigurationManager.AppSettings["DESPLEGAR_USUARIO"], null);
            }
            else
            {
                Obj_Especialidad_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Especialidad_DAL.dtParametros);
                Obj_Especialidad_DAL.dtParametros.Rows.Add("@ID", "1", Obj_Especialidad_DAL.iIdEspecialidad);
                Obj_Especialidad_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.USUARIOS", ConfigurationManager.AppSettings["DESPLEGAR_USUARIO"], Obj_Especialidad_DAL.dtParametros);
            }
        }
    }
}
