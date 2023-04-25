using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Servicios_DAL
    {
        #region Varibles

        private uint _uID_Servicio, _uID_Especialidad;
        private string _sDetalleServicio, _sMsjError;
        private float _fCostoServicio;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region Constructor
       
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public uint uID_Servicio { get => _uID_Servicio; set => _uID_Servicio = value; }
        public uint uID_Especialidad { get => _uID_Especialidad; set => _uID_Especialidad = value; }
        public string sDetalleServicio { get => _sDetalleServicio; set => _sDetalleServicio = value; }
        public float fCostoServicio { get => _fCostoServicio; set => _fCostoServicio = value; }
        #endregion
    }
}
