using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Vendedor
    {
        public int idVendedor { get; set; }
        public int idTiendaRopa { get; set; }
        public string nombreVendedor { get; set; }
        public string apellidoVendedor { get; set; }
        public virtual ICollection<Cotizacion> cotizaciones { get; set; }
    }
}
