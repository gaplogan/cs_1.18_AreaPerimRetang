using System;

namespace cs_1._18_AreaPerimRetang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis do programa
            double lado1, lado2, perim, area;

            // {Entrada de dados}
            Console.Write("Digite o valor do primeiro lado: ");
            lado1 = Math.Abs(double.Parse(Console.ReadLine())); //garante Lado1 com valor positivo

            Console.Write("Digite o valor do segundo lado: ");
            lado2 = Math.Abs(double.Parse(Console.ReadLine())); //garante Lado2 com valor positivo

            Console.WriteLine(); // Salta uma linha

            // {Processamento de dados}
            perim = 2 * lado1 + 2 * lado2; //fórmula do perímetro do retângulo
            area = lado1 * lado2;

            // {Saída de dados}
            Console.WriteLine($"Perímetro: {perim}");
            Console.WriteLine($"Área.....: {area}");
        }
    }
}
