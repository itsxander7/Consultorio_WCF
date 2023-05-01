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
        #region Metodos
        // LISTAR Y FILTRAR
        public void List_Facturas(ref cls_Facturacion_DAL Obj_Facturacion_DAL)
        {

            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();

            if (Obj_Facturacion_DAL.uID_Factura == 0)
            {
            Obj_Facturacion_DAL.dtParametros = null;
            Obj_Facturacion_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DETALLE_FACTURA", ConfigurationManager.AppSettings["LISTAR_FACTURAS"], null);
            }
            else
            {
               Obj_Facturacion_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Facturacion_DAL.dtParametros);

                Obj_Facturacion_DAL.dtParametros.Rows.Add("@id_Detalle_Factura", "1", Obj_Facturacion_DAL.uID_Factura);

                Obj_Facturacion_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DETALLE_FACTURA", ConfigurationManager.AppSettings["FILTRAR_FACTURAS"], Obj_Facturacion_DAL.dtParametros);
            }
           


        }

        public void Cargar_Combo(ref cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            BD_Connection.BDClient OBJ_WCF = new BD_Connection.BDClient();

            if (Obj_Facturacion_DAL.uID_Cliente == 0)
            {
                Obj_Facturacion_DAL.dtParametros = null;
                Obj_Facturacion_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DETALLE_FACTURA", ConfigurationManager.AppSettings["DESPLEGAR_DF_CLIENTES"], null);
            }
            else
            {
                Obj_Facturacion_DAL.dtParametros = OBJ_WCF.Get_DT_Param(Obj_Facturacion_DAL.dtParametros);
                Obj_Facturacion_DAL.dtParametros.Rows.Add("@ID", "1", Obj_Facturacion_DAL.uID_Cliente);
                Obj_Facturacion_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DETALLE_FACTURA", ConfigurationManager.AppSettings["DESPLEGAR_DF_CLIENTES"], Obj_Facturacion_DAL.dtParametros);
            }

        }
        #endregion
    }
}
