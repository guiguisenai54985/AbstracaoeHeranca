using AbstracaoeHeranca.Atividade4;
using AbstracaoeHeranca.Atividade5;
using AbstracaoeHeranca.Atividade6;
using AbstracaoeHeranca.Atividade7;
using AbstracaoeHeranca.Atividade8;
using AbstracaoeHeranca.Atividade9;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AbstracaoeHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //Sesi sesi = new Sesi();
            //sesi.CalcularMedia();

            //Senai senai = new Senai();
            //senai.CalcularMedia();

            //2

            //Desenvolvedor desenvolvedor = new Desenvolvedor();
            //desenvolvedor.CalcularHorasExatas();

            //Bancario bancario = new Bancario();
            //bancario.CalcularHorasExatas();

            //GerenteTI gerente = new GerenteTI();
            //gerente.CalcularHorasExatas();

            //3
            //Projeto projeto = new Projeto();
            //projeto.EscolherProfissao();

            //4
            //DigitarInformacoes();

            //5
            Definir();

            //6
            //Formula formula = new Formula();
            //formula.CalcularArea();

            //Losango losango = new Losango();
            //losango.CalcularArea();

            //Retangulo retangulo = new Retangulo();
            //retangulo.CalcularArea();

            //7
            Animal animal = new Animal();
            animal.nome = "onça";
            animal.idade = 10;
            Animal2();

            Cachorro cachorro = new Cachorro();
            cachorro.nome = "Rocky";
            cachorro.idade = 5;
            cachorro.Raca1 = "viralata";

            Gato gato = new Gato();
            gato.nome = "Luna";
            gato.idade = 6;
            gato.CorDoPelo1 = "branco";
            
            //8
            Midia midia = new Midia();
            midia.Codigo =5465848;
            midia.Preco = 57.98;
            midia.Nome = "multmidia";
            midia.ImprimirDados();

            DVD dVD = new DVD();
            dVD.Filmes = 2;
            dVD.VerFilmes();

            USB uSB = new USB();
            uSB.Musicas1 = 9;
            uSB.CapaciadeAmazenamento = "64 GB";
            uSB.LerMusicas();

            //9
            Console.WriteLine("digite o valor que gostaria de depositar em sua conta");
            double deposito1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o valor do saque gostaria de efetuar");
            double saque1 = Convert.ToDouble(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria();
            conta.Depositar(deposito1);
            conta.Sacar(saque1);

            Console.ReadKey();

        }
        //4
        static void DigitarInformacoes()
        {
            Console.WriteLine("digite as seu nome ");
            string nome = Console.ReadLine();
            Console.WriteLine("digite a sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o nome da sua cidade");
            string cidade = Console.ReadLine();
            Console.WriteLine("digite o seu rg");
            string rg = Console.ReadLine();
            Console.WriteLine("digite a sua área no trabalho");
            string area = Console.ReadLine();

            Programador programador = new Programador();


            Console.WriteLine("suas informações: " + nome + " " + idade + " " + cidade + " " + rg + " " + area);

            string jsonstring1 = JsonConvert.SerializeObject(programador, Formatting.Indented);

            File.WriteAllText("text.json", jsonstring1);
           
        }

        //5
        static void Definir()
        {
            Empresario empresario = new Empresario();
            empresario.nome = "guilherme";
            empresario.cnpj = "84884784";
            empresario.endereco = "rftyguhjio";
            empresario.cidade = "garça";
            empresario.nomeEmpresa = "Garem";

            string jsonstring1 = JsonConvert.SerializeObject(empresario, Formatting.Indented);

            File.WriteAllText("text.json", jsonstring1);
        }
        //7
        static void Animal2()
        {
            Animal animal = new Animal();
            animal.nome = "";
            string jsonstring1 = JsonConvert.SerializeObject(animal, Formatting.Indented);

            File.WriteAllText("text.json", jsonstring1);
        }



    }
}
