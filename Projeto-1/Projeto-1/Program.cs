using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
                string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
                int casa = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
                double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu útimo nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string UltimoNome = vet[0];
            int    idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(casa);
            Console.WriteLine(preço.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(UltimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}