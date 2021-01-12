using Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class ParametrosAplicativo
    {
        public TiendaRopa tienda { get; set; }
        public Vendedor vendedor { get; set; }
        public List<TipoPrenda> tiposPrendas { get; set; }
        public List<CaracteristicaTipoPrenda> caracteristicas { get; set; }
        public List<CalidadPrenda> calidades { get; set; }
        public List<Prenda> prendas { get; set; }
        public List<Prenda> camisas { get; set; }
        public List<Prenda> pantalones { get; set; }
        public List<Cotizacion> cotizaciones { get; set; }

    }
}
