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
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("tbl_usuario");

            HasKey(u => u.IdUsuario);

            Property(u => u.IdUsuario)
                .HasColumnName("id_usuario")
                .IsRequired();

            Property(u => u.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            
            Property(u => u.Email)
                .HasColumnName("email")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, //definindo a coluna email como unica
                    new IndexAnnotation(
                        new IndexAttribute("index_email_usuario") { IsUnique = true }));


            Property(u => u.Senha)
                .HasColumnName("senha")
                .HasMaxLength(64)
                .IsRequired();


            Property(u => u.DataCadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();


            Property(u => u.Telefone)
                .HasColumnName("telefone")
                .HasMaxLength(14)
                .IsOptional();

            Property(u => u.Celular)
                .HasColumnName("celular")
                .HasMaxLength(14)
                .IsOptional();

            Property(u => u.Ativo)
                .HasColumnName("ativo")
                .IsRequired();

            Property(u => u.Perfil)
                .HasColumnName("perfil")
                .IsRequired();

            Property(u => u.Foto)
                .HasColumnName("foto")
                .IsOptional();





            Property(u => u.IdGrupo)
                .HasColumnName("id_grupo")
                .IsRequired();

            HasRequired(u => u.Grupo) //usuario tem um grupo
                .WithMany(g => g.Usuarios) //grupo tem muitos usuários
                .HasForeignKey(u => u.IdGrupo); //foreing key

        }

    }
}
