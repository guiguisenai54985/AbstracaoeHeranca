using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoeHeranca.Atividade7
{
    class Gato : Animal
    {
        private string CorDoPelo;

        public string CorDoPelo1
        {
            get 
            {
                return CorDoPelo;
            }
            set
            {
                CorDoPelo = value;
            }
        }

    }
}
