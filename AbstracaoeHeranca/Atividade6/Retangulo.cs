using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade6
{
    class Retangulo : Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("digite o valor da base do retangulo");
            int base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o valor da artura do retangulo");
            int altura = Convert.ToInt32(Console.ReadLine());   

            double result = base1 * altura;

            Console.WriteLine("o valor da área do retangulo é: " +  result);
        }
    }
}
