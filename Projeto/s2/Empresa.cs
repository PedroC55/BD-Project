using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
    class Empresa
    {
        private string nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
