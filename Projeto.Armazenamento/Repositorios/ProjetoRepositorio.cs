using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Entidades;
using Projeto.Armazenamento.Configuracoes;
using System.Data.Entity;

namespace Projeto.Armazenamento.Repositorios
{
    public class ProjetoRepositorio
    {
            public void Inserir(Projeto.Entidades.Projeto p)
            {
                using (Conexao con = new Conexao())
                {
                    con.Entry(p).State = EntityState.Added;
                    con.SaveChanges();
                }
            }

            public void Atualizar(Projeto.Entidades.Projeto p)
            {
                using (Conexao con = new Conexao())
                {
                    con.Entry(p).State = EntityState.Modified;
                    con.SaveChanges();
                }
            }

            public void Excluir(Projeto.Entidades.Projeto p)
            {
                using (Conexao con = new Conexao())
                {
                    con.Entry(p).State = EntityState.Deleted;
                    con.SaveChanges();
                }
            }

            public Projeto.Entidades.Projeto ObterPorId(int idProjeto)
            {
                using (Conexao con = new Conexao())
                {
                    return con.Projeto.FirstOrDefault(p => p.IdProjeto == idProjeto);
                }
            }

            public List<Projeto.Entidades.Projeto> ListarTodos()
            {
                using (Conexao con = new Conexao())
                {
                    return con.Projeto.ToList();
                }
            }
        
    }
}
