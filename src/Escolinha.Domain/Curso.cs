using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escolinha.Domain
{
    public class Curso
    {
        private IList<Aula> _aulas;

        public Curso()
        {

        }

        public IEnumerable<Aula> Aulas
        {
            get { return this._aulas; }
            private set
            {
                // Metodo 1
                _aulas.Clear();
                value.ToList().ForEach(x => _aulas.Add(x));

                // Metodo 2
                // _aulas.Clear();
                //foreach (var aula in value)
                //{
                //    _aulas.Add(aula);
                //}

                // Metodo 3
                // this._aulas = new List<Aula>(value);
            }
        }
    }
}
