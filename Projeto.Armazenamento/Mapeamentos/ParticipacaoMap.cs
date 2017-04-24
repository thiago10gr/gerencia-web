using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.Armazenamento.Mapeamentos
{
    public class ParticipacaoMap : EntityTypeConfiguration<Participacao>
    {
        public ParticipacaoMap()
        {

            ToTable("tbl_participacao");

            //chave composta
            HasKey(pa => new { pa.IdProjeto, pa.IdUsuario });



            Property(pa => pa.IdProjeto)
              .HasColumnName("id_projeto")
              .IsRequired();

            HasRequired(pa => pa.Projeto) 
                .WithMany(po => po.Participacoes) 
                .HasForeignKey(pa => pa.IdProjeto); //foreing key
            



            Property(pa => pa.IdUsuario)
              .HasColumnName("id_usuario")
              .IsRequired();

            HasRequired(pa => pa.Usuario) 
                .WithMany(u => u.Participacoes) 
                .HasForeignKey(pa => pa.IdUsuario); //foreing key

        }
    }
}
