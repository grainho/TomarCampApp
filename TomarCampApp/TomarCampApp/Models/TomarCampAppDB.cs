using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TomarCampApp.Models
{
    public class TomarCampAppDB : DbContext
    {

        public TomarCampAppDB(): base("TomarCampAppConnectionString") { }


        public DbSet<Atividades> Atividades { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Criancas> Criancas { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<ActCri> ActCri { get; set; } // tabela que irá exprimir o relacionamento entre as classes Atividades e Criancas
        public DbSet<ActFun> ActFun { get; set; } // tabela que irá exprimir o relacionamento entre as classes Atividades e Funcionarios

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);


        }

    }
}