using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade8
{
    class USB : Midia
    {
        private int musicas;
        private string capacidadeArmazenamento;

        public int Musicas1
        {
            get 
            { 
                return musicas; 
            } 
            set 
            {
                musicas = value; 
            }
        }

        public string CapaciadeAmazenamento
        {
            get
            {
                return capacidadeArmazenamento;
            }
            set
            {
                capacidadeArmazenamento = value;
            }
        }

        public void LerMusicas()
        {
            Console.WriteLine("digite o nome de 5 musicas que você gosta");
            string nomemusica1= Console.ReadLine();
            Console.WriteLine("digite o nome de quem é o cantor(cantores) dessa(s) música(s)");
            string cantor= Console.ReadLine();
            Console.WriteLine("o nome das musicas são: " + nomemusica1 + "e, quem canta ela(s) é(são): " + cantor);
   

        }
    }
}
