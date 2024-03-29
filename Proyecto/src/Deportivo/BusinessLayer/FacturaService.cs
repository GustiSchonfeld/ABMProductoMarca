﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportivo.DataAccessLayer;
using Deportivo.Entities;

namespace Deportivo.BusinessLayer
{
    public class FacturaService
    {
        private FacturaDao oFacturaDao;
        public FacturaService()
        {
            oFacturaDao = new FacturaDao();
        }

        internal bool Crear(Factura factura)
        {
            return oFacturaDao.Create(factura);
        }

        internal bool ValidarDatos(Factura factura)
        {
            if(factura.FacturaDetalle.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un item de factura.");
            }

            return true;
        }
    }
}
