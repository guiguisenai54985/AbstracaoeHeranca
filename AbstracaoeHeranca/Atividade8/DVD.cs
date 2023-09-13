using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade8
{
    class DVD : Midia
    {
        private int filmes;

        public int Filmes
        {
            get 
            {
                return filmes; 
            }
            set 
            {
                filmes = value; 
            }
        }
        
        public void VerFilmes()
        {
            Console.WriteLine(" digite dois filmes que você gosta de assistir ");
            string filme = Console.ReadLine();
            Console.WriteLine("qual é os generos dos filmes ");
            string genero = Console.ReadLine();
            Console.WriteLine("em que ano em que ele foi lançado");
            int anolancamento = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("os seus filmes favoritos são: " + filme + "os generos dele são: " + genero + "o ano em que ele foi lançado é: " + anolancamento);
        }
    }
}
