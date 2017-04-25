using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.Armazenamento.Mapeamentos
{
    public class ProjetoMap : EntityTypeConfiguration<Projeto.Entidades.Projeto>
    {
        public ProjetoMap()
        {

            //nome da tabela
            ToTable("tbl_projeto");

            //chave primaria
            HasKey(p => p.IdProjeto);


            Property(p => p.IdProjeto)
                .HasColumnName("id_projeto")
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.DataInicio)
                .HasColumnName("data_inicio")
                .IsOptional();

            Property(p => p.DataFim)
                .HasColumnName("data_fim")
                .IsOptional();

            Property(p => p.Status)
                .HasColumnName("status")
                .IsRequired();





            Property(p => p.IdArea)
                .HasColumnName("id_area")
                .IsOptional();
               
            HasOptional(p => p.Area) //Projeto tem uma Area 
            .WithMany(a => a.Projetos) //Area tem muitos projetos
            .HasForeignKey(p => p.IdArea); //foreing key





            Property(p => p.IdGrupo)
                .HasColumnName("id_grupo")
                .IsRequired();

            HasRequired(p => p.Grupo) //Projeto tem um Grupo
            .WithMany(g => g.Projetos) //Grupo tem muitos projetos
            .HasForeignKey(p => p.IdGrupo); //foreing key


        }

    }
}
