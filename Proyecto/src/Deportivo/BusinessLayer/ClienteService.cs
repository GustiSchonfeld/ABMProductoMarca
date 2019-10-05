using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportivo.Entities;
using Deportivo.DataAccessLayer;

namespace Deportivo.BusinessLayer
{
    public class ClienteService
    {
        private ClienteDao oClienteDao;
        public ClienteService()
        {
            oClienteDao = new ClienteDao();
        }
        public IList<Cliente> ObtenerTodos()
        {
            return oClienteDao.GetAll();
        }

        public IList<Cliente> ConsultarClientesConFiltrosCondiciones(String condiciones)
        {
            return oClienteDao.GetClienteByFiltersCondiciones(condiciones);
        }

        public Cliente ConsultarClientesPorId(int id)
        {
            return oClienteDao.GetClienteById(id);
        }

        internal bool CrearCliente(Cliente oCliente)
        {
            return oClienteDao.Create(oCliente);
        }

        internal bool ActualizarCliente(Cliente oClienteSelected)
        {
            return oClienteDao.Update(oClienteSelected);
        }

        internal bool ModificarBorradoCliente(Cliente oClienteSelected)
        {
            return oClienteDao.Delete(oClienteSelected);
        }




    }


}
