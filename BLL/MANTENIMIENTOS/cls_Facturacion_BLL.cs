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

            WCF_BD.BDClient OBJ_WCF = new WCF_BD.BDClient();


            Obj_Facturacion_DAL.dtParametros = null;
            Obj_Facturacion_DAL.dtDatos = OBJ_WCF.ListarFiltrar("SCH_ADMIN.DETALLE_FACTURA", ConfigurationManager.AppSettings["FILTRAR_FACTURAS"], null);

        }
        #endregion
    }
}
