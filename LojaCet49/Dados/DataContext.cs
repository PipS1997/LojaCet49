using LojaCet49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaCet49.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }


        public DbSet<Cliente> Clientes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}