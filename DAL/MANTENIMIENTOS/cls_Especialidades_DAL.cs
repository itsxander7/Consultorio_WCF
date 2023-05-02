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
        int _iIdEspecialidad;
        string _sNombreEspecialidad, _sMsjError;
        private DataTable _dtDatos, _dtParametros;


        public int iIdEspecialidad { get => _iIdEspecialidad; set => _iIdEspecialidad = value; }
        public string sNombreEspecialidad { get => _sNombreEspecialidad; set => _sNombreEspecialidad = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }

    }
}
