using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade2
{
    class Bancario : Colaborador
    {
        public override void CalcularHorasExatas()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mês corrente");
            double qtdehoras = Convert.ToDouble(Console.ReadLine());

            double result = qtdehoras * 250;

            if (qtdehoras > 500)
            {
                double result2 = result * 0.1 ;
                Console.WriteLine("o novo valor a receber é: " + result2);
            }
            else if (qtdehoras > 1000)
            {
                double result3 = result * 0.15;
                Console.WriteLine("o novo valor a receber é: " + result3);
            }
            else
            {
                Console.WriteLine("o valor que ira receber será: " + result);
            }
        }
    }
}
