using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noroeste.Entities
{
    public class Avion : BaseEntity
    {
        public List<Pasajero> Pasajeros { get; set; }
    }
}
