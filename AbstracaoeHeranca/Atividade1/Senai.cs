using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade1
{
    class Senai : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("digite a 1º nota do aluno de 0 a 100");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a 2º nota do aluno de 0 a 100");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a 3º nota do aluno de 0 a 100");
            int nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a 4º nota do aluno de 0 a 100");
            int nota4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a frequencia do aluno de 0 a 100");
            double frequencia = Convert.ToDouble(Console.ReadLine());


            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (frequencia >= 90 && media >= 7 )
            {
                Console.WriteLine("parabem voc~e foi aprovado no curso tecnico do senai");
            }
            else if (frequencia >=70 &&  media < 7)
            {
                Console.WriteLine("você precisa fazer trabalhos de  recuperação");
            }
            else if (frequencia <= 90  && media < 7)
            {
                Console.WriteLine("você foi reprovado por faltas");
            }
            else 
            {
                Console.WriteLine("aluno reprovado");
            }

        }
    }
}
