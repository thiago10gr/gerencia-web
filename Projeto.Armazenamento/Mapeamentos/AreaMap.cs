using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Armazenamento.Mapeamentos
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {

            //nome da tabela
            ToTable("tbl_area");

            //chave primaria
            HasKey(a => a.IdArea);

            Property(a => a.IdArea)
                .HasColumnName("id_area")
                .IsRequired();

            Property(a => a.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100) 
                .IsRequired();

            Property(a => a.Documento)
                .HasColumnName("documento")
                .HasMaxLength(17)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, //definindo a coluna documento como unica
                    new IndexAnnotation(
                        new IndexAttribute("index_documento_area") { IsUnique = true }));
                

            Property(a => a.Email)
                .HasColumnName("Email")
                .HasMaxLength(150)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, //definindo a coluna email como unica
                    new IndexAnnotation(
                        new IndexAttribute("index_email_area") { IsUnique = true }));


            Property(a => a.Telefone)
                .HasColumnName("telefone")
                .HasMaxLength(14)
                .IsRequired();

            Property(a => a.Observacoes)
                .HasColumnName("observacoes")
                .HasMaxLength(500)
                .IsOptional();

            Property(a => a.TipoArea)
                .HasColumnName("tipo_area")
                .IsRequired();

        }

    }
}
