using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Usuario_DAL
    {
        #region Variables privadas

        private uint _uID_Usuario;
        private string _sNombreUsuario, _sPasswordUsuario, _sMsjError;
        private float _fCostoServicio;
        private DataTable _dtDatos, _dtParametros;
        #endregion
        #region Contructor
        public uint UID_Usuario { get => _uID_Usuario; set => _uID_Usuario = value; }
        public string SNombreUsuario { get => _sNombreUsuario; set => _sNombreUsuario = value; }
        public string SPasswordUsuario { get => _sPasswordUsuario; set => _sPasswordUsuario = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
        public float FCostoServicio { get => _fCostoServicio; set => _fCostoServicio = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion
    }
}
