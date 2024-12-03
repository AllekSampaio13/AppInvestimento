using AppInvest.Domain.Interfaces;
using AppInvest.Domain.Models;
using AppInvest.Infra.Data.EF.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;


namespace AppInvest.Infra.Data.EF
{
    public class CadastroContext : DbContext, IUnitOfWork
    {
        public CadastroContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
            CriarBancoCasoNaoExista();
        }

        private void CriarBancoCasoNaoExista()
        {
            if (!(Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AcoesMapping());

        }
        public DbSet<Acoes> Acoes { get; set; }
    }
}

