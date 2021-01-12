using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Modelos
{
    public class TiendaRopa
    {
        public int idTiendaRopa { get; set; }
        public string nombreTiendaRopa { get; set; }
        public string direccion { get; set; }
        public virtual ICollection<Prenda> prendas { get; set; }
        public virtual ICollection<Vendedor> vendedores { get; set; }
    }
}
