using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    public class Ex5
    {
        public void Resultado()
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();

            string invertedString = InverterString(input);

            Console.WriteLine("String invertida: " + invertedString);
        }

        private string InverterString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);             
            return new string(charArray);
        }
    }
}
