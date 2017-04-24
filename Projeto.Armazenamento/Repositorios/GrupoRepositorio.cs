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
    public class GrupoRepositorio
    {
        public void Inserir(Grupo g)
        {
            using (Conexao con = new Conexao())
            {
                con.Entry(g).State = EntityState.Added;
                con.SaveChanges();
            }
        }

        public void Atualizar(Grupo g)
        {
            using (Conexao con = new Conexao())
            {
                con.Entry(g).State = EntityState.Modified;
                con.SaveChanges();
            }
        }

        public void Excluir(Grupo g)
        {
            using(Conexao con = new Conexao())
            {
                con.Entry(g).State = EntityState.Deleted;
                con.SaveChanges();
            }
        }

        public Grupo ObterPorId(int idGrupo)
        {
            using (Conexao con = new Conexao())
            {
                return con.Grupo.FirstOrDefault(g => g.IdGrupo == idGrupo);
            }
        }

        public List<Grupo> ListarTodos()
        {
            using (Conexao con = new Conexao())
            {
                return con.Grupo.ToList();
            }
        }
    }
}
