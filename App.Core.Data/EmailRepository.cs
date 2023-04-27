using App.Core.Entities;
using System.ComponentModel;

namespace App.Core.Data
{
    public class EmailRepository
    {
        public List<Email> Buscar(string textoParaBuscar)
        {
            var lista = new List<Email>();
            for (int i = 0; i < 100; i++)
            {
                lista.Add(new Email()
                {
                    Id = i,
                    Asunto = $"Demo{i}"
                });
            }
            return lista;
        }

    }
}