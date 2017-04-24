using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.Armazenamento.Mapeamentos
{
    public class TarefaMap : EntityTypeConfiguration<Tarefa>
    {
        public TarefaMap()
        {
            ToTable("tbl_tarefa");

            HasKey(t => t.IdTarefa)
                .HasEntitySetName("id_tarefa");


            Property(t => t.IdTarefa)
                .HasColumnName("id_tarefa")
                .IsRequired();

            Property(t => t.Titulo)
                .HasColumnName("titulo")
                .HasMaxLength(45)
                .IsRequired();

            Property(t => t.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(500)
                .IsRequired();

            Property(t => t.DataInicio)
                .HasColumnName("data_inicio")
                .IsOptional();


            Property(t => t.DataFim)
                .HasColumnName("data_fim")
                .IsOptional();


            Property(t => t.HorasEstimadas)
                .HasColumnName("horas_estimadas")
                .IsOptional();

            Property(t => t.HorasTrabalhadas)
                .HasColumnName("horas_trabalhadas")
                .IsOptional();

            Property(t => t.Status)
                .HasColumnName("status")
                .IsRequired();



            Property(t => t.IdProjeto)
              .HasColumnName("id_projeto")
              .IsRequired();

            HasRequired(t => t.Projeto) //tarefa tem um projeto
            .WithMany(p => p.Tarefas) //projeto tem muitas tarefas
            .HasForeignKey(t => t.IdProjeto); //foreing key

        }
    }
}
