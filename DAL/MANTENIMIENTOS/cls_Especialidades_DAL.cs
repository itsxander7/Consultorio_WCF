using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Especialidades_DAL
    {
        int _ID_ESPECIALIDAD;
        string _NOMBRE_ESPECIALIDAD, _sMsjError;
        private DataTable _dtDatos, _dtParametros;

        public int ID_ESPECIALIDAD { get => _ID_ESPECIALIDAD; set => _ID_ESPECIALIDAD = value; }
        public string NOMBRE_ESPECIALIDAD { get => _NOMBRE_ESPECIALIDAD; set => _NOMBRE_ESPECIALIDAD = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
