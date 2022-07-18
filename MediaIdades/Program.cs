using System;
using System.Globalization;

namespace MadiaIdades
{
    public class Probgram
    {
        static void Main(string[] args)
        {
            CultureInfo Ida = CultureInfo.InvariantCulture;
            string nome1, nome2;
            double idade1, idade2, media;

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = double.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2;

            Console.WriteLine();

            Console.WriteLine("O nome da primeira pessoa é = " + nome1);
            Console.WriteLine("O nome da segunda pessoa é = " + nome2);
            Console.WriteLine("E a média das idades são = " + media.ToString("F1", Ida));
        }
    }
}   