using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportivo.Entities;
using Deportivo.DataAccessLayer;

namespace Deportivo.BusinessLayer
{
    public class TipoTarjetaService
    {
        private TipoTarjetaDao oTipoTarjetaDao;
        public TipoTarjetaService()
        {
            oTipoTarjetaDao = new TipoTarjetaDao();
        }
        public IList<TipoTarjeta> ObtenerTodos()
        {
            return oTipoTarjetaDao.GetAll();
        }

        public IList<TipoTarjeta> ConsultarTipoTarjetaConFiltrosCondiciones(String condiciones)
        {
            return oTipoTarjetaDao.GetTipoTarjetaByFiltersCondiciones(condiciones);
        }

        public TipoTarjeta ConsultarTipoTarjetaPorId(int id)
        {
            return oTipoTarjetaDao.GetTipoTById(id);
        }

        internal bool CrearTipoTarjeta(TipoTarjeta oTipoTarjeta)
        {
            return oTipoTarjetaDao.Create(oTipoTarjeta);
        }

        internal bool ActualizarTipoTarjeta(TipoTarjeta oTipoTarjetaSel)
        {
            return oTipoTarjetaDao.Update(oTipoTarjetaSel);
        }

        internal bool ModificarBorradoTipoTarjeta(TipoTarjeta oTipoTarjetaSel)
        {
            return oTipoTarjetaDao.Delete(oTipoTarjetaSel);
        }




    }


}

