using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade2
{
    class GerenteTI : Colaborador
    {
        public override void CalcularHorasExatas()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mês corrente");
            double hrsextras = Convert.ToDouble(Console.ReadLine());

            double hrs = hrsextras / 2;
            if (hrsextras > 100)
            {
                double result = (hrsextras / 2) * 200 + 500;
                double dias = result / 8;
                Console.WriteLine("o total de horas a receber ira ser: " + result + "e " + "a quntidade de dias de descanso será: " + dias);
                
            }
            else
            {
                double result = hrsextras * 400;
                Console.WriteLine("o  total de hosras que o funcionario ira receber é: " + result);    
            }
        }
    }
}
