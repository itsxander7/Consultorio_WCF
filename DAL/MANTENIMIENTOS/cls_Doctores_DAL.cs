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
        int _iIdDoctor, _iIdEspecialidad, _iIdUsuario , _iCedula,_iTelefonoDoctor;
        string _sNombreDoctor, _sApellido1Doctor, _sApellido2Doctor,  _sCorreoDoctor,_sMsjError;
        private DataTable _dtDatos, _dtParametros;

        public int iIdDoctor { get => _iIdDoctor; set => _iIdDoctor = value; }
        public int iIdEspecialidad { get => _iIdEspecialidad; set => _iIdEspecialidad = value; }
        public int iIdUsuario { get => _iIdUsuario; set => _iIdUsuario = value; }
        public string sNombreDoctor { get => _sNombreDoctor; set => _sNombreDoctor = value; }
        public string sApellido1Doctor { get => _sApellido1Doctor; set => _sApellido1Doctor = value; }
        public string sApellido2Doctor { get => _sApellido2Doctor; set => _sApellido2Doctor = value; }
        public int iTelefonoDoctor { get => _iTelefonoDoctor; set => _iTelefonoDoctor = value; }
        public string sCorreoDoctor { get => _sCorreoDoctor; set => _sCorreoDoctor = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        public int iCedula { get => _iCedula; set => _iCedula = value; }
    }
}
