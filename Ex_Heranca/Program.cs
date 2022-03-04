using System;

namespace Ex_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisica fisica = new Fisica("Joao", "123.456.789-00");
            fisica.escreverNome();
            Console.WriteLine("\n"+fisica.validarDocumento());

            
        }
    }
}
