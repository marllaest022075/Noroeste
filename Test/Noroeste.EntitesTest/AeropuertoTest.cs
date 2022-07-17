using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noroeste.EntitesTest
{
    public class AeropuertoTest
    {
        [Fact]
        public void Checar_Si_Hereda_De_BaseEntity()
        {
            var actual = typeof(Aeropuerto).BaseType == typeof(BaseEntity);
            Assert.True(actual);
        }
        [Fact]
        public void Checar_Si_Existe_Campo_Aviones()
        {
            var aeropuerto = new Aeropuerto();
            var actual = aeropuerto.HasProperty("Aviones");
            Assert.True(actual);
        }
        
        [Fact]
        public void Checar_Si_Existe_Campo_Estacion()
        {
            var aeropuerto = new Aeropuerto();
            var actual = aeropuerto.HasProperty("Estacion");
            Assert.True(actual);
        }
    }
}
