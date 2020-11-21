using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03___Empregado
{
    class Empregao
    {
        private string NomeEmp;
        private int IdadeEmp;
        public int Idade
        {
            get { return IdadeEmp; }
            set { IdadeEmp = value; }
        }
        public string Nome
        {
            get { return NomeEmp; }
            set { NomeEmp = value; }

        }
    }
}
