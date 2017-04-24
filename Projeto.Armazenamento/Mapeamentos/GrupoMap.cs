using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.Armazenamento.Mapeamentos
{
    public class GrupoMap : EntityTypeConfiguration<Grupo>
    {
        public GrupoMap()
        {
            ToTable("tbl_grupo");

            HasKey(g => g.IdGrupo);

            Property(g => g.IdGrupo)
                .HasColumnName("id_grupo")
                .IsRequired();

            Property(g => g.Nome)
                .HasColumnName("nome")
                .IsRequired();

            Property(g => g.DataCriacao)
                .HasColumnName("data_criacao")
                .IsRequired();

            Property(g => g.Ativo)
                .HasColumnName("ativo")
                .IsRequired();
              
        }
    }
}
