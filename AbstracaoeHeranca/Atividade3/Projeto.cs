using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade3
{
    class Projeto : Estudante
    {
        public int DataDoProjeto { get; set; }

        public void EscolherProfissao()
        {
            Console.WriteLine("qual a profissão que gostaria de escolher?");
            string escolha = Convert.ToString(Console.ReadLine());
            Console.WriteLine("qual facudade gostaria de cursar?");
            string faculdade = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cite 3 coisas que gostaria de estar fazendo daqui a 5 anos?");
            string gostariadefazer = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Quais são as suas expectativas quando finalizar o ensino médio?");
            string expectativas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cite 3 características de quais são os seus projetos para o futuro?");
            string caracteristicas = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("a sua escolha de profissão foi: " + escolha + "\n" + "a faculdade que você escolheu foi: " + faculdade + "\n" + "as 3 coisas que gostaria de fazer daqui 5 anos foi: " + gostariadefazer + "\n" + "as suas expectativas quando finalizar o ensino médio é: " + expectativas + "\n" + "e as 3 caracteristicas de quais são os seus projeto para o futuro é: " + caracteristicas);
        }
    }
}
