using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nomeDoUsuario;
            string sobreNome;
            string texto;
            Console.Write("Por favor, digite seu nome: ");
            nomeDoUsuario = Console.ReadLine();
            Console.Clear();

            Console.Write("Por favor, digite seu sobrenome: ");
            sobreNome = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Por favor, escreva uma frase! ");
            texto = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine($"{texto}".Replace("r", "l"));
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine($"Obrigado, Digite uma tecla para terminar {nomeDoUsuario} {sobreNome}... ");
            Console.ReadKey(); 
            Console.ResetColor();
            
             

            
        }
    }
}
