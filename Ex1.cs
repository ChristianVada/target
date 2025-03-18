using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    public class Ex1
    {
        public void Resultado()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine("O valor de SOMA é: " + SOMA);
        }
    }
}
