using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Expediente_DAL
    {
        #region Varibles

        private uint _uID_Expediente, _uID_Cliente, _uID_Doctor;
        private string _sDetalleExpediente, _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region Constructor
        public uint uID_Expediente { get => _uID_Expediente; set => _uID_Expediente = value; }
        public uint uID_Cliente { get => _uID_Cliente; set => _uID_Cliente = value; }
        public uint uID_Doctor { get => _uID_Doctor; set => _uID_Doctor = value; }
        public string sDetalleExpediente { get => _sDetalleExpediente; set => _sDetalleExpediente = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion



    }
}
