using System;
using System.Collections.Generic;
using System.Linq;
using ProvaG1.Domain;
using ProvaG1.Repositories.Data;
using ProvaG1.Repositories.Interfaces;

namespace ProvaG1.Repositories.Repository
{
    public class ConsultaRepository : IConsultaRepository
    {
        private DataContext context;
        public ConsultaRepository()
        {
            
        }

        public ConsultaRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Consulta consulta)
        {
            consulta.cliente = context.Clientes.Find(consulta.cliente.id);
            context.Consultas.Add(consulta);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Consultas.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Consulta> GetAll()
        {
            return context.Consultas.Include(c => c.cliente).ToList();
        }

        public Consulta GetById(int id)
        {
            return context.Consultas.Include(c => c.cliente).SingleOrDefault(x => x.id == id);
        }

        public void Update(Consulta consulta)
        {
            consulta.cliente = context.Clientes.Find(consulta.cliente.id);
            context.Entry(consulta).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}