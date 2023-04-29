using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MANTENIMIENTOS;
using System.Configuration;

namespace BLL.MANTENIMIENTOS
{
    class cls_MetodosPago_BLL
    {
        // LISTAR Y FILTRAR
        public void List_MetodosPago(ref cls_MetodosPago_DAL Obj_MetodosPago_DAL)
        {

            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();


            if (Obj_MetodosPago_DAL.uID_MetodoPago == 0)
            {
                Obj_MetodosPago_DAL.dtParametros = null;
                Obj_MetodosPago_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.METODO_PAGO", ConfigurationManager.AppSettings["LISTAR_METODO_PAGO"], null);
            }
            else
            {
                Obj_MetodosPago_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_MetodosPago_DAL.dtParametros);

                Obj_MetodosPago_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_MetodosPago_DAL.uID_MetodoPago);

                Obj_MetodosPago_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.METODO_PAGO", ConfigurationManager.AppSettings["FILTRAR_METODO_PAGO"], Obj_MetodosPago_DAL.dtParametros);
            }
        }

        //GUARDAR
        public void Guardar_MetodosPago(ref cls_MetodosPago_DAL Obj_MetodosPago_DAL)
        {
            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();

            Obj_MetodosPago_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_MetodosPago_DAL.dtParametros);

            Obj_MetodosPago_DAL.dtParametros.Rows.Add("@ID_METODO_PAGO", "1", Obj_MetodosPago_DAL.uID_MetodoPago);
            Obj_MetodosPago_DAL.dtParametros.Rows.Add("@NOMBRE_METODO_PAGO", "6", Obj_MetodosPago_DAL.sNombreMetodoPago);
            Obj_MetodosPago_DAL.dtParametros.Rows.Add("@DETALLE_METODO_PAGO", "6", Obj_MetodosPago_DAL.sDetalleMetodoPago);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_MetodosPago_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_METODO_PAGO"], "NORMAL", Obj_MetodosPago_DAL.dtParametros);
        }

        //ACTUALIZAR
        public void Modificar_MetodosPago(ref cls_MetodosPago_DAL Obj_MetodosPago_DAL)
        {

            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();

            Obj_MetodosPago_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_MetodosPago_DAL.dtParametros);

            Obj_MetodosPago_DAL.dtParametros.Rows.Add("@ID_METODO_PAGO", "1", Obj_MetodosPago_DAL.uID_MetodoPago);
            Obj_MetodosPago_DAL.dtParametros.Rows.Add("@NOMBRE_METODO_PAGO", "6", Obj_MetodosPago_DAL.sNombreMetodoPago);
            Obj_MetodosPago_DAL.dtParametros.Rows.Add("@DETALLE_METODO_PAGO", "6", Obj_MetodosPago_DAL.sDetalleMetodoPago);

            Obj_MetodosPago_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_METODO_PAGO"], "NORMAL", Obj_MetodosPago_DAL.dtParametros);

        }

        //ELIMINAR
        public void Eliminar_MetodosPago(ref cls_MetodosPago_DAL Obj_MetodosPago_DAL)
        {
            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();

            Obj_MetodosPago_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_MetodosPago_DAL.dtParametros);

            Obj_MetodosPago_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_MetodosPago_DAL.uID_MetodoPago);

            Obj_MetodosPago_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_METODO_PAGO"], "NORMAL", Obj_MetodosPago_DAL.dtParametros);
        }
    }
}
