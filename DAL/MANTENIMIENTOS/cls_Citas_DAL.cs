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
<<<<<<< HEAD
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
=======
        private int _ID_CITA, _ID_CLIENTE, _ID_ESPECIALIDAD, _ID_DOCTOR;
        private string _sMsjError;
        private DateTime _FECHA;
        private DataTable _dtDatos, _dtParametros;

        public int ID_CITA { get => _ID_CITA; set => _ID_CITA = value; }
        public int ID_CLIENTE { get => _ID_CLIENTE; set => _ID_CLIENTE = value; }
        public int ID_ESPECIALIDAD { get => _ID_ESPECIALIDAD; set => _ID_ESPECIALIDAD = value; }
        public int ID_DOCTOR { get => _ID_DOCTOR; set => _ID_DOCTOR = value; }
        public DateTime FECHA { get => _FECHA; set => _FECHA = value; }
>>>>>>> d8087b8d76692d74c53be6d0581ffec3a5507baa
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
