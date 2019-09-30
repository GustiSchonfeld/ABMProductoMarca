using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportivo.Entities;
using Deportivo.DataAccessLayer;

namespace Deportivo.BusinessLayer
{
    public class MarcaService
    {
        private MarcaDao oMarcaDao;
        public MarcaService()
        {
            oMarcaDao = new MarcaDao();
        }
        public IList<Marca> ObtenerTodos()
        {
            return oMarcaDao.GetAll();
        }

        public IList<Marca> ConsultarMarcasConFiltrosCondiciones(String condiciones)
        {
            return oMarcaDao.GetMarcaByFiltersCondiciones(condiciones);
        }

        public Marca ConsultarMarcasPorId(int id)
        {
            return oMarcaDao.GetMarcaById(id);
        }

        internal bool CrearMarca(Marca oMarca)
        {
            return oMarcaDao.Create(oMarca);
        }

        internal bool ActualizarMarca(Marca oMarcaSelected)
        {
            return oMarcaDao.Update(oMarcaSelected);
        }

        internal bool ModificarBorradoMarca(Marca oMarcaSelected)
        {
            return oMarcaDao.Delete(oMarcaSelected);
        }




    }

  
}
