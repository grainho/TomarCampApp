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

        public TomarCampAppDB() : base("TomarCampAppConnectionString") { }

        public virtual DbSet<Funcionarios> Funcionario { get; set; }
        public virtual DbSet<Atividades> Atividades { get; set; }
        public virtual DbSet<PlanoDeAtividades> PlanoDeAtividades { get; set; }
        public virtual DbSet<Concretizacao> Concretizacao { get; set; }
        public virtual DbSet<Criancas> Criancas { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  // impede a EF de 'pluralizar' os nomes das tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'

            base.OnModelCreating(modelBuilder);
        }

    }
}