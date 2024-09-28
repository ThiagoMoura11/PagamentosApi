using Microsoft.EntityFrameworkCore;
using PagamentosApi.Domain.Entites;
using PagamentosApi.Domain.Entites.GrupoPadraoCheckInApi.Domain.Entities;

namespace PagamentosApi.Infrastructure.DbContext 
{
    public class PagamentosDbContext : Microsoft.EntityFrameworkCore.DbContext 
    {
        public PagamentosDbContext(DbContextOptions<PagamentosDbContext> options)
            : base(options)
        {
        }

        public DbSet<ChavePix> ChavesPix { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<TransacaoPix> TransacoesPix { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PagamentosDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
