using System;
using System.Collections.Generic;

namespace NrAleatorioex2
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            int[] vetor = new int[100];
            
            int aux = 0;
           
            Random rnd = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
               
                aux = rnd.Next(0, 10);

                Console.WriteLine("Digite um numero: ");
                int NumeroDigitado = int.Parse(Console.ReadLine());

                if (aux == NumeroDigitado)
                {
                    Console.WriteLine("voce Acertou");
                    Console.WriteLine("O numero aleatorio gerado é: " + aux);
                    Console.ReadLine();
                }



            }
        }
    }
}