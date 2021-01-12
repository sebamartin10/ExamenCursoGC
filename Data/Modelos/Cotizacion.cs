using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Cotizacion
    {
        public int idCotizacion { get; set; }
        public int idVendedor { get; set; }
  
        public DateTime fechaHoraCotizacion { get; set; }
        public int cantidadCotizada { get; set; }
        public decimal precioCotizacion { get; set; }
    }
}
