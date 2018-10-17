using System.Collections.Generic;

namespace Aula10_Avaliacao_G1.Models
{
    public interface IPlanoRepository
    {
        Plano GetById(int id);
        List<Plano> GetAll();
        void Create(Plano plano);
        void Delete(int id);
        void Update(Plano plano);
    }
}