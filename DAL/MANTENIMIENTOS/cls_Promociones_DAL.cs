using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Promociones_DAL
    {
        #region Variables

        private uint _uID_Promocion, _uID_Servicio;
        private float _fMontoPromocion;
        private string _sDetallePromocion, _sMsjError;
        private DataTable _dtDatos, _dtParametros;
        #endregion

        #region Constructor
        public uint uID_Promocion { get => _uID_Promocion; set => _uID_Promocion = value; }
        public uint uID_Servicio { get => _uID_Servicio; set => _uID_Servicio = value; }
        public float fMontoPromocion { get => _fMontoPromocion; set => _fMontoPromocion = value; }
        public string sDetallePromocion { get => _sDetallePromocion; set => _sDetallePromocion = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        #endregion
    }
}
