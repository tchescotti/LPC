using System.Collections.Generic;

namespace Aula10_Avaliacao_G1.Models
{
    public interface IClienteRepository
    {
        Cliente GetById(int id);
        List<Cliente> GetAll();
        void Create(Cliente cliente);
        void Delete(int id);
        void Update(Cliente cliente);
    }
}