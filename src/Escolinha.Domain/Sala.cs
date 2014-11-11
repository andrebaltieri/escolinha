using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escolinha.Domain
{
    public class Sala
    {
        private IList<Aula> _aulas;

        public Sala()
        {

        }

        public IEnumerable<Aula> Aulas
        {
            get { return this._aulas; }
            private set { this._aulas = new List<Aula>(value); }
        }
    }
}
