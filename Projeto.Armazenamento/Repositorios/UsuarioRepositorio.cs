using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.Entidades;
using Projeto.Armazenamento.Configuracoes;
using System.Data.Entity;
using Projeto.Entidades.Tipos;

namespace Projeto.Armazenamento.Repositorios
{
    public class UsuarioRepositorio 
    {

        public void Inserir(Usuario u)
        {
            using(Conexao con = new Conexao())
            {
                con.Entry(u).State = EntityState.Added;
                con.SaveChanges();
            }
        }

        public void Atualizar(Usuario u)
        {
            using(Conexao con = new Conexao())
            {
                con.Entry(u).State = EntityState.Modified;
                con.SaveChanges();
            }
        }

        public Usuario ObterPorId(int idUsuario)
        {
            using(Conexao con = new Conexao())
            {
                return con.Usuario.FirstOrDefault(u => u.IdUsuario == idUsuario);
            }
        }

        public List<Usuario> ListarTodos()
        {
            using(Conexao con = new Conexao())
            {
                return con.Usuario.ToList();
            }
        }


        public Usuario ObterPorEmailSenha(string email, string senha)
        {
            using(Conexao con = new Conexao())
            {
                return con.Usuario.FirstOrDefault(u => u.Email.Equals(email) 
                && u.Senha.Equals(senha));
            }
        }

        public Usuario ObterPorEmail(string email)
        {
            using (Conexao con = new Conexao())
            {
                return con.Usuario.FirstOrDefault(u => u.Email.Equals(email));
            }
        }

    }
}
