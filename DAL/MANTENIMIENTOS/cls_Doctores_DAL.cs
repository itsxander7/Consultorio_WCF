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
        int _ID_DOCTOR, _ID_ESPECIALIDAD, _ID_USUARIO;
        string _NOMBRE_DOCTOR, _APELLIDO1_DOCTOR, _APELLIDO2_DOCTOR, _TELEFONO_DOCTOR, _CORREO_DOCTOR,_sMsjError;
        private DataTable _dtDatos, _dtParametros;

        public int ID_DOCTOR { get => _ID_DOCTOR; set => _ID_DOCTOR = value; }
        public int ID_ESPECIALIDAD { get => _ID_ESPECIALIDAD; set => _ID_ESPECIALIDAD = value; }
        public int ID_USUARIO { get => _ID_USUARIO; set => _ID_USUARIO = value; }
        public string NOMBRE_DOCTOR { get => _NOMBRE_DOCTOR; set => _NOMBRE_DOCTOR = value; }
        public string APELLIDO1_DOCTOR { get => _APELLIDO1_DOCTOR; set => _APELLIDO1_DOCTOR = value; }
        public string APELLIDO2_DOCTOR { get => _APELLIDO2_DOCTOR; set => _APELLIDO2_DOCTOR = value; }
        public string TELEFONO_DOCTOR { get => _TELEFONO_DOCTOR; set => _TELEFONO_DOCTOR = value; }
        public string CORREO_DOCTOR { get => _CORREO_DOCTOR; set => _CORREO_DOCTOR = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
