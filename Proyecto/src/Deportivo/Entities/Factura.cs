﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportivo.Entities
{
    class Factura
    {
        public int IdFactura { get; set; }
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public TipoFactura TipoFactura { get; set; }
        public TipoTarjeta TipoTarjeta { get; set; }
        public Tarjeta Tarjeta { get; set; }
        public IList<FacturaDetalle> FacturaDetalle { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }
        public int NroTarjeta { get; set; }
        public int Codigo { get; set; }
        public double ImporteTotal
        {
            get
            {
                return SubTotal - SubTotal * Descuento / 100;
            }
        }

        public override string ToString()
        {
            return TipoFactura + NroFactura.ToString("0001-00000000");
        }
    }
}
