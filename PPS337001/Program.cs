using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPS337001
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] n = { 3, 37, 70, 1, 0, 73, 7, 10 }; // numeros do vetor
            Console.WriteLine("valor final dos impars =" + SomaImpar(n, n.Length-1));
            Console.WriteLine();
            Console.ReadKey();
        }

        static int SomaImpar(int[] vetor, int n)
        {
            //Mostra os valores guardados no vetor
            if(vetor[n] %2 != 0)
            {
                Console.WriteLine("valor =" + vetor[n]);
            }            

            if (n > 0 && vetor[n] % 2 != 0)
            {
                return vetor[n] + SomaImpar(vetor, n- 1);
            }
            else if (n == 0 )
            {
                return vetor[n];
            }
            else if (n > 0 && vetor[n] % 2 == 0)
            {
                return SomaImpar(vetor,n - 1);
            }

            return 0;

        }
    }
}
