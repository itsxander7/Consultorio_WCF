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

        public int iIdCita { get => _iIdCita; set => _iIdCita = value; }
        public int iIdCliente { get => _iIdCliente; set => _iIdCliente = value; }
        public int iIdEspecialidad { get => _iIdEspecialidad; set => _iIdEspecialidad = value; }
        public int iIdDoctor { get => _iIdDoctor; set => _iIdDoctor = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DateTime dtFecha { get => _dtFecha; set => _dtFecha = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
