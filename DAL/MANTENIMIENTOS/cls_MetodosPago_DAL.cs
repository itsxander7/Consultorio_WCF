using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_MetodosPago_DAL
    {
        #region Variables privadas

        private uint _uID_MetodoPago;
        private string _sMsjError, _sNombreMetodoPago, _sDetalleMetodoPago;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region Contructor

        public DataTable dtDatos { get => DtDatos; set => DtDatos = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => DtParametros; set => DtParametros = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public uint uID_MetodoPago { get => _uID_MetodoPago; set => _uID_MetodoPago = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sNombreMetodoPago { get => _sNombreMetodoPago; set => _sNombreMetodoPago = value; }
        public string sDetalleMetodoPago { get => _sDetalleMetodoPago; set => _sDetalleMetodoPago = value; }

        #endregion
    }
}
