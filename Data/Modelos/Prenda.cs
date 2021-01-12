using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class Prenda
    {
        public int idPrenda { get; set; }
        public int idCalidadPrenda { get; set; }
        public string nombrePrenda { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaBaja { get; set; }
        public DateTime fechaUltimaModificacion { get; set; }
        public decimal precioPrenda { get; set; }
        public int cantidadStockDisponible { get; set; }
        public virtual CaracteristicaTipoPrenda caracteristica { get; set; }
        public virtual TipoPrenda tipoPrenda { get; set; }
        public virtual CalidadPrenda calidad { get; set; }
    }
}
