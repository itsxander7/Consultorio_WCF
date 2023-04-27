using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.MANTENIMIENTOS;


namespace BLL.MANTENIMIENTOS
{
    public class cls_Facturacion_BLL
    {
        // LISTAR Y FILTRAR
        public void List_Facturas(ref cls_Facturacion_DAL Obj_Facturacion_DAL)
        {

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();


            if (Obj_Facturacion_DAL.uID_Factura == 0)
            {
                Obj_Facturacion_DAL.dtParametros = null;
                Obj_Facturacion_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.FACTURAS", ConfigurationManager.AppSettings["LISTAR_FACTURAS"], null);
            }
            else
            {
                Obj_Facturacion_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Facturacion_DAL.dtParametros);

                Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_Facturacion_DAL.uID_Factura);

                Obj_Facturacion_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.FACTURAS", ConfigurationManager.AppSettings["FILTRAR_FACTURAS"], Obj_Facturacion_DAL.dtParametros);
            }
        }

        //GUARDAR Y ACTUALIZAR
        public void Guardar_Facturas(ref cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();





            Obj_Facturacion_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Facturacion_DAL.dtParametros);

            Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_Facturacion_DAL.uID_Factura);
            Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_METODO_PAGO", "1", Obj_Facturacion_DAL.uID_MetodoPago);
            Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_CLIENTE", "1", Obj_Facturacion_DAL.uID_Cliente);
            Obj_Facturacion_DAL.dtParametros.Rows.Add("@TOTAL_NETO", "3", Obj_Facturacion_DAL.fTotalNeto);

            //SI LA TABLA NO ES IDENTITY SE ENVIA "NORMAL" DE LO CONTRARIO CUALQUIER OTRO VALOR

            Obj_Facturacion_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["GUARDAR_FACTURAS"], "NORMAL", Obj_Facturacion_DAL.dtParametros);
        }

        public void Modificar_Facturas(ref cls_Facturacion_DAL Obj_Facturacion_DAL)
        {

            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();

            Obj_Facturacion_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Facturacion_DAL.dtParametros);

            Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_Facturacion_DAL.uID_Factura);
            Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_METODO_PAGO", "1", Obj_Facturacion_DAL.uID_MetodoPago);
            Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_CLIENTE", "1", Obj_Facturacion_DAL.uID_Cliente);
            Obj_Facturacion_DAL.dtParametros.Rows.Add("@TOTAL_NETO", "3", Obj_Facturacion_DAL.fTotalNeto);

            Obj_Facturacion_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["EDITAR_FACTURAS"], "NORMAL", Obj_Facturacion_DAL.dtParametros);

        }

        //ELIMINAR

        public void Eliminar_Facturas(ref cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            DBConnection.BDClient OBJ_WCF = new DBConnection.BDClient();

            Obj_Facturacion_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Facturacion_DAL.dtParametros);

            Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID_FACTURA", "1", Obj_Facturacion_DAL.uID_Factura);

            Obj_Facturacion_DAL.sMsjError = OBJ_WCF.Ins_Upd_Delete(ConfigurationManager.AppSettings["ELIMINAR_FACTURAS"], "NORMAL", Obj_Facturacion_DAL.dtParametros);
        }
    }
}
