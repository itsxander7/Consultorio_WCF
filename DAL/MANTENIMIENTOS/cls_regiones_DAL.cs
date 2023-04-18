using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.MANTENIMIENTOS
{
    public class cls_regiones_DAL
    {
        private int _iRegionId;
        private string _sTerritoryDescription, _sMsjError, _sTerritoryID;
        private DataTable _dtDatos, _dtParametros;


        public int iRegionId { get => _iRegionId; set => _iRegionId = value; }
        public string sTerritoryID { get => _sTerritoryID; set => _sTerritoryID = value; }
        public string sTerritoryDescription { get => _sTerritoryDescription; set => _sTerritoryDescription = value; }
        public string sMsjError { get => _sMsjError; set => _sMsjError = value; }
        public DataTable DtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
    }
}
