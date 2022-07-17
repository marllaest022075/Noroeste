namespace Noroeste.EntitesTest
{
    public class BaseEntityTest
    {
        [Fact]
        public void HasIdField()
        {
            var entity = new BaseEntity();
            var actual = entity.HasProperty("Id");
            Assert.True(actual);
        }
    }
}