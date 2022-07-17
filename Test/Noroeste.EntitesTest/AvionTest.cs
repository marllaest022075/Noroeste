using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noroeste.EntitesTest
{
    public class AvionTest
    {
        [Fact]
        public void Checar_Si_Hereda_De_BaseEntity()
        {
            var actual = typeof(Avion).BaseType == typeof(BaseEntity);
            Assert.True(actual);
        }
        [Fact]
        public void Checar_Si_Existe_Campo_Pasajeros()
        {
            var avion = new Avion();
            var actual = avion.HasProperty("Pasajeros");
            Assert.True(actual);
        }
    }
}
