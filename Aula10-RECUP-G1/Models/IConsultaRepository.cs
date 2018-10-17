using System.Collections.Generic;

namespace Aula10_Avaliacao_G1.Models
{
    public interface IConsultaRepository
    {
        Consulta GetById(int id);
        List<Consulta> GetAll();
        void Create(Consulta consulta);
        void Delete(int id);
        void Update(Consulta consulta);
    }
}