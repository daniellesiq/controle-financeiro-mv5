using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class FinancasContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }

        //OnModelCreating podemos alterar o modelagem feito por Entity Framework
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Mapeando chave estrangeira - Onde toda movimentação tem um usuário.
            modelBuilder.Entity<Movimentacao>().HasRequired(m => m.Usuario);
        }
    }
}