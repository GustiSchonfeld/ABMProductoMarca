using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportivo.DataAccessLayer;
using Deportivo.Entities;

namespace Deportivo.BusinessLayer
{
    public class TarjetaService
    {
        private TarjetaDao oTarjetaDao;
        public TarjetaService()
        {
            oTarjetaDao = new TarjetaDao();
        }
        public IList<Tarjeta> ObtenerTodos()
        {
            return oTarjetaDao.GetAll();
        }

        public IList<Tarjeta> ConsultarTarjetaConFiltrosCondiciones(String condiciones)
        {
            return oTarjetaDao.GetTarjetaByFiltersCondiciones(condiciones);
        }

        public Tarjeta ConsultarTarjetaPorId(int id)
        {
            return oTarjetaDao.GetTarjetaById(id);
        }

        internal bool CrearTarjeta(Tarjeta oTarjeta)
        {
            return oTarjetaDao.Create(oTarjeta);
        }

        internal bool ActualizarTarjeta(Tarjeta oTarjetaSel)
        {
            return oTarjetaDao.Update(oTarjetaSel);
        }

        internal bool ModificarBorradoTarjeta(Tarjeta oTarjetaSel)
        {
            return oTarjetaDao.Delete(oTarjetaSel);
        }




    }


}
