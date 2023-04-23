using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Citas_DAL
    {
        int _ID_CITA, _ID_CLIENTE, _ID_ESPECIALIDAD, _ID_DOCTOR;
        string _sMsjError;
        DateTime _FECHA;
        private DataTable _dtDatos, _dtParametros;

        public int ID_CITA { get => _ID_CITA; set => _ID_CITA = value; }
        public int ID_CLIENTE { get => _ID_CLIENTE; set => _ID_CLIENTE = value; }
        public int ID_ESPECIALIDAD { get => _ID_ESPECIALIDAD; set => _ID_ESPECIALIDAD = value; }
        public int ID_DOCTOR { get => _ID_DOCTOR; set => _ID_DOCTOR = value; }
         public DateTime FECHA { get => _FECHA; set => _FECHA = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
    }
}
