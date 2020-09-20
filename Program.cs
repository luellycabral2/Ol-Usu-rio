using System;

namespace Ol_Usuario
{
    class Program
    {
        static void Main(string[] args)
        { 
            //<---Começo(digite..)--->//
            Console.WriteLine("digite seu nome :");
            string NomeUsuário = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("Olá,(nome)!");
            //<---Término(digite..)--->//

            //<---Para sair--->//
            Console.WriteLine("Aperte a técla ENTER para sair");
            Console.ReadKey();
            //<---Fim--->//
        }
    }
}
