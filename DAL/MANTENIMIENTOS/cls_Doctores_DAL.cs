using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Doctores_DAL
    {
        int _iIdDoctor, _iIdEspecialidad, _iIdUsuario;
        string _sNombreDoctor, _sApellido1Doctor, _sApellido2Doctor, _sTelefonoDoctor, _sCorreoDoctor,_sMsjError;
        private DataTable _dtDatos, _dtParametros;

        public int IIdDoctor { get => _iIdDoctor; set => _iIdDoctor = value; }
        public int IIdEspecialidad { get => _iIdEspecialidad; set => _iIdEspecialidad = value; }
        public int IIdUsuario { get => _iIdUsuario; set => _iIdUsuario = value; }
        public string SNombreDoctor { get => _sNombreDoctor; set => _sNombreDoctor = value; }
        public string SApellido1Doctor { get => _sApellido1Doctor; set => _sApellido1Doctor = value; }
        public string SApellido2Doctor { get => _sApellido2Doctor; set => _sApellido2Doctor = value; }
        public string STelefonoDoctor { get => _sTelefonoDoctor; set => _sTelefonoDoctor = value; }
        public string SCorreoDoctor { get => _sCorreoDoctor; set => _sCorreoDoctor = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
