using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade9
{
    class ContaBancaria
    {
        public string nomeDoTitular;
        public int nConta;
        public string nAgencia;
        public string nBanco;
        private double saldo { get; set; }
        
        public void Depositar(double deposito)
        {
            this.saldo = deposito;
        }
        public void Sacar(double saque) 
        {
   
            if (saque > saldo) 
            {
                Console.WriteLine("Você não possui saldo suficiente na sua conta bancária");
            }
            else if (saque < saldo || saque == saldo)
            {
                double result = saldo - saque;
                Console.WriteLine("o valor do novo saldo é: " + result);
                Console.WriteLine("o valor do saque efetuado é: " +  saque);
            }

        }
    }
}
