using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoSegundos
{
    class Calculo
    {
        private int horas;
        private int minutos;
        private int segundos;
        public int seg;

        public void Calcular()
        {
            horas = seg / 3600;
            minutos = (seg % 3600) / 60;
            segundos = (seg % 3600) % 60;


        }
        public void Imprimir()
        {
            Console.WriteLine("H :M :S");
            Console.WriteLine( + horas + ":" + minutos + ":" + segundos);
            
        }
    }
}
