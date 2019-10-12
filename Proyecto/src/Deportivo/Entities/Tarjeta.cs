using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportivo.Entities
{
    public class Tarjeta
    {
        
        public int IdTarjeta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoTarjeta TipoTarjeta { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    
    }
}
