using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicandoArraysex4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];
            Random rnd = new Random();


            for (int a = 0; a < 5; a++)
            {
                array1[a] = rnd.Next(1, 10);
                array2[a] = rnd.Next(1, 10);
            }


            Console.Write("Array 1: ");
            for (int a = 0; a < 5; a++)
            {
                Console.Write(array1[a] + " ");
            }
            Console.Write("\n\nArray 2: ");
            for (int a = 0; a < 5; a++)
            {
                Console.Write(array2[a] + " ");
            }

            Console.Write("\n\nA multiplicação do Array1 pelo Array2 é de : ");

            for (int a = 0; a < 5; a++)
            {
                array3[a] = array1[a] * array2[a];
                Console.Write(array3[a] + " ");
                Console.ReadLine();
            }
        }
    }
}
