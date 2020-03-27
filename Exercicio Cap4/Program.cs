using System;
using System.Globalization;

namespace Exercicio_Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercico 01
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Entre com o nome da primeira pessoa e em seguida sua idade");
            a.Nome = Console.ReadLine();
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome da Segunda pessoa e em seguida sua idade");
            b.Nome = Console.ReadLine();
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", b.Nome);
            }

            //Exercico 02

            FolhaPagamento c, d;
            c = new FolhaPagamento();
            d = new FolhaPagamento();

            Console.WriteLine("Insira o nome e em seguida o Salário do Colaborador:");
            c.Nome = Console.ReadLine();
            c.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o nome e em seguida o Salário do Colaborador:");
            d.Nome = Console.ReadLine();
            d.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (c.Salario + d.Salario) / 2.0;
            Console.WriteLine("Salário médio: {0}", media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
