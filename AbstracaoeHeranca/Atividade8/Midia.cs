using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade8
{
    class Midia
    {
        private int codigo;
        private double preco;
        private string nome;

        public int Codigo
        {
            get 
            {
                return codigo; 
            }
            set 
            {
                codigo = value; 
            }
        }
        public double Preco
        {
            get
            {
                return preco;   
            }
            set 
            {
                preco = value; 
            }  
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set 
            {
                nome = value; 
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("digite o nome do seu cantor favorito");
            string nomecantor = Console.ReadLine();
            Console.WriteLine("digite o nome da musica que você mais gosta");
            string nomemusiaca = Console.ReadLine();
            Console.WriteLine("digite o ano de seu lançamento");
            int ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("o nome do sue cantor favorito é: " + nomecantor + "o nome da musica que você mais gosta é: " + nomemusiaca + "o anoa em que ela foi lançada foi: " + ano);
        }

    }
}
