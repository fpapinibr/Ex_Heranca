using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Heranca
{
    class Pessoa
    {
        private string Nome { get; set; }


        public void escreverNome()
        {
            Console.Write(this.Nome);
        }

        public Boolean validarDocumento()
        {
            return true;
        }

    }
}
