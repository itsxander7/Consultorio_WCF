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
        private int __iIdCliente;
        private string _sNombreCliente, _sApellido1Cliente, _sApellido2Cliente, _sDireccionCliente, _sCorreoCliente, _sMsjError, __sTelefonoCliente;
        private DataTable _dtDatos, _dtParametros;

        public int IIdCliente { get => __iIdCliente; set => __iIdCliente = value; }
        public string SNombreCliente { get => _sNombreCliente; set => _sNombreCliente = value; }
        public string SApellido1Cliente { get => _sApellido1Cliente; set => _sApellido1Cliente = value; }
        public string SApellido2Cliente { get => _sApellido2Cliente; set => _sApellido2Cliente = value; }
        public string SDireccionCliente { get => _sDireccionCliente; set => _sDireccionCliente = value; }
        public string SCorreoCliente { get => _sCorreoCliente; set => _sCorreoCliente = value; }
        public string SMsjError { get => _sMsjError; set => _sMsjError = value; }
        public string STelefonoCliente { get => __sTelefonoCliente; set => __sTelefonoCliente = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
