using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Heranca
{
    class Fisica: Pessoa
    {
        public string Cpf { get; set; }

        public Fisica(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public new Boolean validarDocumento()  //new oculta o metodo da classe base acessivel. Diferente do overide
        {
            //Console.WriteLine("CPF: "+Cpf);
            return string.IsNullOrEmpty(Cpf) || Cpf.Length != 14 ? false : true; 
        }
    }
}
