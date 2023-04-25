using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Facturacion_DAL
    {
        #region Variables privadas

        private uint _uID_Factura, _uID_MetodoPago, _uID_Cliente, _uID_DetalleFacura, _uID_Servicio;
        private string _sMsjError;
        private float _fTotalNeto;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region Contructor
       
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public uint uID_Factura { get => _uID_Factura; set => _uID_Factura = value; }
        public uint uID_MetodoPago { get => _uID_MetodoPago; set => _uID_MetodoPago = value; }
        public uint uID_Cliente { get => _uID_Cliente; set => _uID_Cliente = value; }
        public uint uID_DetalleFacura { get => _uID_DetalleFacura; set => _uID_DetalleFacura = value; }
        public uint uID_Servicio { get => _uID_Servicio; set => _uID_Servicio = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public float fTotalNeto { get => _fTotalNeto; set => _fTotalNeto = value; }
        #endregion
    }
}
