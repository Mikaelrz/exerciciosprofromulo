using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProfRomulo.ExercicioOito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*Exercício 8
             * 
            Crie um programa que entre com um número inteiro
            e mostre o fatorial desse número.
            Exemplo:
            5! = 120
            5*4*3*2*1=  120
            */

            int fatorial = 5;
            for (int n = 5; n <= 10; n++)
            {
                fatorial *= n;
                Console.WriteLine(n + " fatorial= " + fatorial);
            }

            Console.WriteLine();
        }
    }
}
