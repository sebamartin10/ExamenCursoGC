using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class TipoPrenda
    {
        public int idTipoPrenda { get; set; }
        public string nombreTipoPrenda { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaBaja { get; set; }
        public DateTime fechaUltimaModificacion { get; set; }
        public virtual ICollection <CaracteristicaTipoPrenda> caracteristicaTipoPrenda { get; set; }
    }
}
