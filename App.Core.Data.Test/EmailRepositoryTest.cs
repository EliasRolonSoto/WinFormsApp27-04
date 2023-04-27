using App.Core.Entities;
using App.Core.Data;

namespace App.Core.Data.Test
{
    public class EmailRepositoryTest
    {
        [Fact]
        public void BuscarRepository()
        {
            var repo = new EmailRepository();
            var emails = repo.Buscar("Hola");


            Assert.NotNull(emails);
            Assert.Equal(1, emails.Count());
        }
    }
}