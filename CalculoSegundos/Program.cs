using System;

namespace CalculoSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calc = new Calculo();

            Console.WriteLine("Entre com os segundos: ");
            calc.seg = int.Parse(Console.ReadLine());

            calc.Calcular();
            calc.Imprimir();
        }
    }
}
