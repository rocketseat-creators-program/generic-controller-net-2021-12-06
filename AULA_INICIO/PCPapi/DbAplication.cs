
using GenericController.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController
{
    public partial class DbAplication : DbContext
    {
        #region DBMODEL_INFO
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<MateriaPrima> MateriaPrima { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Garagem> Garagens { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }


        #endregion
        public DbAplication()
        {
        }

        public DbAplication(DbContextOptions<DbAplication> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
