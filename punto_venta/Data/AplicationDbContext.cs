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

            modelBuilder.Entity<ObtenerUsuario>().ToSqlQuery("EXEC sp_listuser 1,50");
            modelBuilder.Entity<ObtenerEnter>().ToSqlQuery("EXEC sp_listenter 1,50");
            modelBuilder.Entity<ObtenerEnterPriseBranch>().ToSqlQuery("EXEC sp_listenEnterpriceBranch 1,50");
            modelBuilder.Entity<ObtenerEnterPriseBranchCash>().ToSqlQuery("EXEC sp_listEnterpriseBranchCach 1,50");
            modelBuilder.Entity<ObtenerEnterpriseBranchOutputProduct>().ToSqlQuery("EXEC sp_ListenEnterprisebranchoutputproduct 1,50");
            modelBuilder.Entity<ObtenerEnterprisebranchpurchase>().ToSqlQuery("EXEC sp_listenterprisebranchpurchase 1,50");
            modelBuilder.Entity<ObtenerEnterprisebranchpurchasedetail>().ToSqlQuery("EXEC sp_listEnterprisebranchpurchasedetail 1,50");
            modelBuilder.Entity<ObtenerEnterprisebranchsaledelivery>().ToSqlQuery("EXEC sp_Listenterprisebranchsaledelivery 1,50");

        }
        
        public DbSet<sp_InsertUser> Users { get; set; }
        public DbSet<LoginModel> Loginuser { get; set; }
        public DbSet<EnterModel> enterModels { get; set; }
        public DbSet<EnterpriseBrainchModel> enterprisebrachModels { get; set; }



    }
}
