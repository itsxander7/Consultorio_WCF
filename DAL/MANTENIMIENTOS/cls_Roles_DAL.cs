using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Roles_DAL
    {
        #region Variables privadas

        private uint _uID_Rol;
        private string _sMsjError, _sTipoRol;
        private DataTable _dtDatos, _dtParametros;

        #endregion

        #region Contructor
        public uint uID_Rol { get => _uID_Rol; set => _uID_Rol = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string sTipoRol { get => _sTipoRol; set => _sTipoRol = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }

        #endregion
    }
}
