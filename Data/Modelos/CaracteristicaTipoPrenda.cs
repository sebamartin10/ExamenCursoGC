using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class CaracteristicaTipoPrenda
    {
        public int idCaracteristicaTipoPrenda { get; set; }
        public int idTipoPrenda { get; set; }
        public string nombreCaracteristicaTipoPrenda { get; set; }
        public int porcentajeAumentoRebaja { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaUltimaModificacion { get; set; }
        public DateTime fechaBaja { get; set; }
    }
}
