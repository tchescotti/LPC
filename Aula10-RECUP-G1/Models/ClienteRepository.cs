using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Aula10_Avaliacao_G1.Models
{
    public class ClienteRepository : IClienteRepository
    {
        private DataContext context;
        public ClienteRepository()
        {
            
        }

        public ClienteRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Cliente cliente)
        {
            cliente.plano = context.Planos.Find(cliente.plano.id);
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Clientes.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            return context.Clientes.Include(p => p.plano).ToList();
        }

        public Cliente GetById(int id)
        {
            return context.Clientes.Include(p => p.plano).SingleOrDefault(x => x.id == id);
        }

        public void Update(Cliente cliente)
        {
            cliente.plano = context.Planos.Find(cliente.plano.id);
            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}