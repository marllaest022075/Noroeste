using Noroeste.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noroeste.Entities
{
    public class Aeropuerto : BaseEntity
    {
        public Estaciones Estacion { get; set; }
        public List<Avion> Aviones { get; set; }
    }
}
