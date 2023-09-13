using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade1
{
    abstract class Escola
    {
        public abstract void CalcularMedia();

        public void DescobrirNome()
        {
            Console.WriteLine("digite o nome de sua escola");
            string school=Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite a sua cidade");
            string cidade=Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite seu estado");
            string estado=Convert.ToString(Console.ReadLine());
            Console.WriteLine("digite a serie em que estuda");
            int serie = Convert.ToInt32(Console.ReadLine());

            if ( school == "sesi/senai" &&  cidade == "garça")
            {
                Console.WriteLine("aluno sesi/senai");
                
            }
            else
            {
                Console.WriteLine(school + "\n" + cidade);
            }
            


        }
    }
}
