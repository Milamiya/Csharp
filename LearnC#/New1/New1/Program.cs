using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace New1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string str1=Console.ReadLine(), str2=Console.ReadLine();
        //    BigInteger a = BigInteger.Parse(str1);
        //    BigInteger b = BigInteger.Parse(str2);
        //    //BigInteger a = BigInteger.Parse("9999999999999999999999999999999999999999999999999999999999999999999999999999999");
        //    int x = 8; int y = 10;
        //    Console.WriteLine(a+b);
        //    Console.WriteLine(x+y);
        //    Console.ReadKey();
        //}
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] ar = new int[n];

            Array.Clear(ar, 0, ar.Length);
            string[] doc = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(doc[i]);
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(ar[i]+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void nhap(ref int x)
        {
            x++;
        }
    }
}
