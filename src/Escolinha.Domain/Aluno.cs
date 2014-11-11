using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Escolinha.Domain
{
    public class Aluno
    {
        #region Variaveis Privadas
        private IList<Aula> _aulas;
        #endregion

        #region Construtores
        public Aluno(string nome, string email, string usuario, string senha, DateTime? dataNascimento = null)
        {
            if (nome.Length <= 3)
                throw new Exception("O nome deve conter mais que 3 caracteres");

            if (!Regex.IsMatch(email, @"[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}"))
                throw new Exception("E-mail inválido");

            this.Id = 0;
            this.Nome = nome;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.Usuario = usuario;
            this.Senha = senha;
            this.Ativo = false;
            this.DeveAlterarSenha = false;
            this._aulas = new List<Aula>();
        }
        #endregion

        #region Propriedades
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public bool Ativo { get; private set; }
        public bool DeveAlterarSenha { get; private set; }
        public IEnumerable<Aula> Aulas
        {
            get { return _aulas; }
            private set { this._aulas = new List<Aula>(value); }
        }
        #endregion

        #region Métodos
        public void AlterarInformacoes(string nome, string email, DateTime? dataNascimento = null)
        {
            this.Nome = nome;
            this.Email = email;
            this.DataNascimento = dataNascimento;
        }

        public void AlterarSenha(string senhaAtual, string novaSenha, string confirmacaoSenha)
        {
            this.Senha = novaSenha;
        }

        public string RecuperarSenha(string usuario)
        {
            var novaSenha = Guid.NewGuid().ToString().Substring(0, 8);
            this.Senha = novaSenha;
            return novaSenha;
        }

        public void Autenticar(string usuario, string senha)
        {
            if (this.Usuario != usuario || this.Senha != senha)
                throw new Exception("Usuário ou senha inválidos");
        }

        public void Ativar()
        {
            this.Ativo = true;
        }

        public void Inativar()
        {
            this.Ativo = false;
        }

        public void MarcarParaAlterarSenha()
        {
            this.DeveAlterarSenha = true;
        }

        public void DesmarcarParaAlterarSenha()
        {
            this.DeveAlterarSenha = false;
        }
        #endregion
    }
}
