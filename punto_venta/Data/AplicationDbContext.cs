using System;
using Microsoft.EntityFrameworkCore;
using punto_venta.Entidades;
using punto_venta.Models;

namespace punto_venta.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ObtenerUsuario>().ToSqlQuery("EXEC sp_listuser");
            modelBuilder.Entity<ObtenerEnter>().ToSqlQuery("EXEC sp_listenter");
            modelBuilder.Entity<ObternerEnterPriseBranch>().ToSqlQuery("EXEC sp_listenEnterpriceBranch");

        }

        public DbSet<sp_InsertUser> Users { get; set; }
        public DbSet<LoginModel> Loginuser { get; set; }
        public DbSet<EnterModel> enterModels { get; set; }
        public DbSet<EnterpriseBrainchModel> enterprisebrachModels { get; set; }



    }
}
