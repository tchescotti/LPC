using AppPeople.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula05___AppPeople___EF.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Person> People { get; set; }
    }
}