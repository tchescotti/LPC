using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aula10_Avaliacao_G1.Models;

namespace Aula10_Avaliacao_G1.Models
{
    public class PlanoRepository : IPlanoRepository
    {
        private DataContext context;
        public PlanoRepository()
        {
            
        }

        public PlanoRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Plano plano)
        {
            context.Planos.Add(plano);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Planos.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Plano> GetAll()
        {
            return context.Planos.ToList();
        }

        public Plano GetById(int id)
        {
            return context.Planos.SingleOrDefault(x => x.id == id);
        }

        public void Update(Plano plano)
        {
            context.Entry(plano).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}