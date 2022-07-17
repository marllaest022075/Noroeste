using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noroeste.EntitesTest
{
    public class PasajeroTest
    {
        [Fact]
        public void Checar_Si_Hereda_De_BaseEntity()
        {
            var actual = typeof(Pasajero).BaseType == typeof(BaseEntity);
            Assert.True(actual);
        }
        [Fact]
        public void Checar_Si_Existe_Campo_Nombre()
        {
            var pasajero = new Pasajero();
            var actual = pasajero.HasProperty("Nombre");
            Assert.True(actual);
        }
    }
}
