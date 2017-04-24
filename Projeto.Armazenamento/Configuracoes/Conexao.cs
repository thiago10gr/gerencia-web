using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity; //EntityFramework..
using Projeto.Entidades; //classes de entidade..
using Projeto.Armazenamento.Mapeamentos; //classes de mapeamento..
using System.Configuration; //connectionstring..
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projeto.Armazenamento.Configuracoes
{
    public class Conexao : DbContext
    {
        //necessário adicionar a referência do System.configuration
        public Conexao() 
            : base(ConfigurationManager.ConnectionStrings["gerencia"].ConnectionString)
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new GrupoMap());
            modelBuilder.Configurations.Add(new ProjetoMap());
            modelBuilder.Configurations.Add(new TarefaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ParticipacaoMap());

            //Remover os cascade
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Remover nomes pluralizados
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Area> Area { get; set; }
        public DbSet<Grupo> Grupo { get; set; }  
        public DbSet<Projeto.Entidades.Projeto> Projeto { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Participacao> Participacao { get; set; }
    }
}
