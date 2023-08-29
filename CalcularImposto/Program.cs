using System;
using CalcularImposto;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe sua renda: ");
        double renda = double.Parse(Console.ReadLine());
        double imposto = Calcular.Calculo(renda);
        Console.WriteLine($"O valor do imposto de renda é: {imposto.ToString("F2")}");
    }
}
