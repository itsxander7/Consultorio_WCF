using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_Clientes_DAL
    {
        private int _ID_CLIENTE;
        private string _NOMBRE_CLIENTE, _APELLIDO1_CLIENTE, _APELLIDO2_CLIENTE, _DIRECCION_CLIENTE, _CORREO_CLIENTE, _sMsjError, _TELEFONO;
        private DataTable _dtDatos, _dtParametros;

        public int ID_CLIENTE { get => _ID_CLIENTE; set => _ID_CLIENTE = value; }
        public string TELEFONO { get => _TELEFONO; set => _TELEFONO = value; }
        public string NOMBRE_CLIENTE { get => _NOMBRE_CLIENTE; set => _NOMBRE_CLIENTE = value; }
        public string APELLIDO1_CLIENTE { get => _APELLIDO1_CLIENTE; set => _APELLIDO1_CLIENTE = value; }
        public string APELLIDO2_CLIENTE { get => _APELLIDO2_CLIENTE; set => _APELLIDO2_CLIENTE = value; }
        public string DIRECCION_CLIENTE { get => _DIRECCION_CLIENTE; set => _DIRECCION_CLIENTE = value; }
        public string CORREO_CLIENTE { get => _CORREO_CLIENTE; set => _CORREO_CLIENTE = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
    }
}
