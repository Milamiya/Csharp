using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace New2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] ar = new int[n, m];

            //Array.Clear(ar, 0, ar.Length);
            for (int i = 0; i < n; i++)
            {
                string[] doc = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    ar[i,j] = int.Parse(doc[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(ar[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
