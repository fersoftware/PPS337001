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
            if (n < 0)  /* se já percorreu todo o vetor */
            {
                return 0;  /* retorna zero */
            }                
            else  /* senão */
            {
                if (vetor[n] % 2 != 0)  /* se vetor[n] é impar */
                {
                    Console.WriteLine("v = " + vetor[n]);
                    return vetor[n] + SomaImpar(vetor, n - 1); /* retorna a soma de vetor[n] à soma dos ímpares do restante do vetor */
                }
                else /* senão */
                {                    
                    return SomaImpar(vetor, n - 1); /* retorna a soma par dos ímpares do restante do vetor */
                }   
            }
        }
    }
}
