using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade2
{
    class Desenvolvedor : Colaborador
    {
        public override void CalcularHorasExatas()
        {
            Console.WriteLine("digite a sua modalidade de trabalho, sendo: A – PRESENCIAL, B- HÍBRIDO E C – REMOTO;");
            string modalidade = Convert.ToString(Console.ReadLine());

            if (modalidade == "a")
            {
                Console.WriteLine("digite a quantidade de horas extras em minutos que você possui");
                double qtdhoras = Convert.ToDouble(Console.ReadLine());

                double result = qtdhoras * 100;

                Console.WriteLine("o total de horas a receber é: " + result);

            }
            else if (modalidade == "b")
            {
                Console.WriteLine("digite a quantidade de horas extras em minutos que você possui");
                double qtdhoras = Convert.ToDouble(Console.ReadLine());


                double result = qtdhoras * 50;
                Console.WriteLine("o total de horas a receber é: " + result);

            }
            else if(modalidade == "c")
            {
                Console.WriteLine("“O seu horário é flexível, ou seja, você escolhe seu horário de trabalho, então\r\nnão contempla horas extras”;");
            }
            else 
            {
                Console.WriteLine("Você digitou uma opção inválida");
            }

        }
    }
}
