using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escolinha.Domain
{
    public class Aula
    {
        private IList<Aluno> _alunos;

        public Aula()
        {

        }

        public Sala Sala { get; private set; }
        public Curso Curso { get; private set; }
        public Instrutor Instrutor { get; private set; }
        public IEnumerable<Aluno> Alunos
        {
            get { return this._alunos; }
            private set { this._alunos = new List<Aluno>(value); }
        }
    }
}
