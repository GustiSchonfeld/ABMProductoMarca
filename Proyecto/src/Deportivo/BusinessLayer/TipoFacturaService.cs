using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportivo.DataAccessLayer;
using Deportivo.Entities;

namespace Deportivo.BusinessLayer
{
    class TipoFacturaService
    {
        private TipoFacturaDao oTipoFacturaDao;
        public TipoFacturaService()
        {
            oTipoFacturaDao = new TipoFacturaDao();
        }
        public IList<TipoFactura> ObtenerTodos()
        {
            return oTipoFacturaDao.GetAll();
        }
    }
}
