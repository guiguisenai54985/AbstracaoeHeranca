using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade1
{
    class Sesi : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("digite a 1º nota do aluno de 0 a 10");
            int nt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a 2º nota do aluno de 0 a 10");
            int nt2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("digite a 3º nota do aluno de 0 a 10");
            int nt3 = Convert.ToInt32(Console.ReadLine());

            int media = (nt + nt2 + nt3);
            if (media >= 7) 
            {
                Console.WriteLine("aluno aprovado");
            }
            else if (media <= 5)
            {
                Console.WriteLine("aluno em recuperação");
            }
            else
            {
                Console.WriteLine("aluno reprovado");
            }

        }
    }
}
