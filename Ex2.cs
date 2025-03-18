using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    public class Ex2
    {

        public void Resultado()
        {
            Console.Write("Digite um número: ");
            
            int num = int.Parse(Console.ReadLine());

            if (IsFibonacci(num))
            {
                Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{num} NÃO pertence à sequência de Fibonacci.");
            }
        }

        private bool IsFibonacci(int num)
        {
            int a = 0, b = 1, temp;

            while (a <= num)
            {
                if (a == num)
                    return true;

                temp = a + b;
                a = b;
                b = temp;
            }

            return false;
        }
    }
}

