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


            if (Obj_Doctores_DAL.IIdDoctor== 0)
            {
                Obj_Doctores_DAL.DtParametros = null;
                Obj_Doctores_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DOCTORES", ConfigurationManager.AppSettings["LISTAR_DOCTORES"], null);
            }
            else
            {
                Obj_Doctores_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctores_DAL.DtParametros);

                Obj_Doctores_DAL.DtParametros.Rows.Add("@Cedula","1", Obj_Doctores_DAL.iCedula);

                Obj_Doctores_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DOCTORES", ConfigurationManager.AppSettings["FILTRAR_DOCTORES"], Obj_Doctores_DAL.DtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Doctores_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctores_DAL.DtParametros);

            Obj_Doctores_DAL.DtParametros.Rows.Add("@ID_Doctor", "1", Obj_Doctores_DAL.IIdDoctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Cedula", "1", Obj_Doctores_DAL.iCedula);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Id_Especialidad", "1", Obj_Doctores_DAL.IIdEspecialidad);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Nombre_Doctor", "6", Obj_Doctores_DAL.SNombreDoctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Apellido1_Doctor", "6", Obj_Doctores_DAL.SApellido1Doctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Apellido2_Doctor", "6", Obj_Doctores_DAL.SApellido2Doctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Telefono_Doctor", "1", Obj_Doctores_DAL.iTelefonoDoctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Correo_Doctor", "6", Obj_Doctores_DAL.SCorreoDoctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Id_Usuario", "1", Obj_Doctores_DAL.IIdUsuario);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Doctores_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["INSERTAR_DOCTORES"], "NORMAL", Obj_Doctores_DAL.DtParametros);
        }

        public void Modificar_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();



            Obj_Doctores_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctores_DAL.DtParametros);

            Obj_Doctores_DAL.DtParametros.Rows.Add("@ID_Doctor", "1", Obj_Doctores_DAL.IIdDoctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Cedula", "1", Obj_Doctores_DAL.iCedula);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Id_Especialidad", "1", Obj_Doctores_DAL.IIdEspecialidad);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Nombre_Doctor", "6", Obj_Doctores_DAL.SNombreDoctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Apellido1_Doctor", "6", Obj_Doctores_DAL.SApellido1Doctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Apellido2_Doctor", "6", Obj_Doctores_DAL.SApellido2Doctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Telefono_Doctor", "1", Obj_Doctores_DAL.iTelefonoDoctor);
            Obj_Doctores_DAL.DtParametros.Rows.Add("@Correo_Doctor", "6", Obj_Doctores_DAL.SCorreoDoctor);
           



            Obj_Doctores_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_DOCTORES"], "NORMAL", Obj_Doctores_DAL.DtParametros);


        }

        //ELIMINAR

        public void Eliminar_Doctores(ref cls_Doctores_DAL Obj_Doctores_DAL)
        {
            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();

            Obj_Doctores_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Doctores_DAL.DtParametros);

            Obj_Doctores_DAL.DtParametros.Rows.Add("@id_doctor", "1", Obj_Doctores_DAL.IIdDoctor);

            Obj_Doctores_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_DOCTORES"], "NORMAL", Obj_Doctores_DAL.DtParametros);
        }   
    }
}
