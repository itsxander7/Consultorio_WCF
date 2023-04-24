using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;

namespace BLL.MANTENIMIENTOS
{
    public class cls_Clientes_BLL
    {

        // LISTAR Y FILTRAR
        public void List_Clientes(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();


            if (Obj_Clientes_DAL.ID_CLIENTE == 0)
            {
               Obj_Clientes_DAL.DtParametros = null;
                Obj_Clientes_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.CLIENTES", ConfigurationManager.AppSettings["LISTAR_CLIENTES"], null);
           }
            else
            {
                Obj_Clientes_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Clientes_DAL.DtParametros);

                Obj_Clientes_DAL.DtParametros.Rows.Add("@id_cliente","1", Obj_Clientes_DAL.ID_CLIENTE);

                Obj_Clientes_DAL.DtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.CLIENTES", ConfigurationManager.AppSettings["FILTRAR_CLIENTES"], Obj_Clientes_DAL.DtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_CLIENTES(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();





            Obj_Clientes_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Clientes_DAL.DtParametros);

            Obj_Clientes_DAL.DtParametros.Rows.Add("@id_cliente", "6", Obj_Clientes_DAL.ID_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@nombre_cliente", "6", Obj_Clientes_DAL.NOMBRE_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@apellido1_cliente", "6",Obj_Clientes_DAL.APELLIDO1_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@apellido2_cliente", "6", Obj_Clientes_DAL.APELLIDO2_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@direccion_cliente", "6", Obj_Clientes_DAL.DIRECCION_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@telefono_cliente", "6", Obj_Clientes_DAL.TELEFONO);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@correo_cliente", "6", Obj_Clientes_DAL.CORREO_CLIENTE);

            
          

          
            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Clientes_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete( ConfigurationManager.AppSettings["GUARDAR_CLIENTES"], "NORMAL", Obj_Clientes_DAL.DtParametros);
        }

        public void Modificar_CLIENTE(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();



            Obj_Clientes_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Clientes_DAL.DtParametros);

            Obj_Clientes_DAL.DtParametros.Rows.Add("@id_cliente", "6", Obj_Clientes_DAL.ID_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@nombre_cliente", "6", Obj_Clientes_DAL.NOMBRE_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@apellido1_cliente", "6", Obj_Clientes_DAL.APELLIDO1_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@apellido2_cliente", "6", Obj_Clientes_DAL.APELLIDO2_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@direccion_cliente", "6", Obj_Clientes_DAL.DIRECCION_CLIENTE);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@telefono_cliente", "6", Obj_Clientes_DAL.TELEFONO);
            Obj_Clientes_DAL.DtParametros.Rows.Add("@correo_cliente", "6", Obj_Clientes_DAL.CORREO_CLIENTE);



            Obj_Clientes_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_CLIENTES"], "NORMAL", Obj_Clientes_DAL.DtParametros);


        }

        //ELIMINAR

        public void Eliminar_CLIENTES(ref cls_Clientes_DAL Obj_Clientes_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();

            Obj_Clientes_DAL.DtParametros = OBJ_WCF.Get_DT_Param(Obj_Clientes_DAL.DtParametros);

            Obj_Clientes_DAL.DtParametros.Rows.Add("@id_cliente", "1", Obj_Clientes_DAL.ID_CLIENTE);

            Obj_Clientes_DAL.SMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_CLIENTES"], "NORMAL", Obj_Clientes_DAL.DtParametros);
        }




    }
}
