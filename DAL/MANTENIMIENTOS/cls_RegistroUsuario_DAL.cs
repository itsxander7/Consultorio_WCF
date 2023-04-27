using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_RegistroUsuario_DAL
    {
        #region Variables privadas

        private uint _uID_Usuario;
        private string _sNombreUsuario, _sPasswordUsuario, _sRol, _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        #endregion
        #region Contructor

        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string sNombreUsuario { get => _sNombreUsuario; set => _sNombreUsuario = value; }
        public string sPasswordUsuario { get => _sPasswordUsuario; set => _sPasswordUsuario = value; }
        public string sRol { get => _sRol; set => _sRol = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public uint uID_Usuario { get => _uID_Usuario; set => _uID_Usuario = value; }
        #endregion
    }
}
