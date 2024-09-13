using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atividade_12._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de pessoas?");
            int quantidade = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine("===============");

            string[] nomes = new string[quantidade];
            int[] idades = new int[quantidade];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Escreva um nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Escreva uma idade : ");
                idades[i] = int.Parse(Console.ReadLine());
                dsfnj
                Thread.Sleep(1000);
                Console.WriteLine("===============");
            }
            
            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine(nomes[i] + " " + idades[i]);
            }

        }


    }
}



