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
        int _iIdCita, _iIdCliente, _iIdEspecialidad, _iIdDoctor;
        string _sMsjError;
        DateTime _dtFecha;
        private DataTable _dtDatos, _dtParametros;

        public int IIdCita { get => _iIdCita; set => _iIdCita = value; }
        public int IIdCliente { get => _iIdCliente; set => _iIdCliente = value; }
        public int IIdEspecialidad { get => _iIdEspecialidad; set => _iIdEspecialidad = value; }
        public int IIdDoctor { get => _iIdDoctor; set => _iIdDoctor = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DateTime DtFecha { get => _dtFecha; set => _dtFecha = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
