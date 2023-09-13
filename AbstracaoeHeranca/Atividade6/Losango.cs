using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade6
{
    class Losango : Formula
    {
        public override void CalcularArea()
        {
            Console.WriteLine("digite o valor da diagonal maior ");
            int diagonalMaior = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insira o valor da diagonal menor ");
            int diagonalMenor = Convert.ToInt32(Console.ReadLine());

            double result = (diagonalMaior * diagonalMenor) / 2;

            Console.WriteLine("o valor da área do losango é: " +  result);
        }
    }
}
