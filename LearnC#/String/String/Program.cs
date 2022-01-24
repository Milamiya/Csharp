using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ho ten");
            string FullName = Console.ReadLine();
            string res = "";
            FullName = FullName.Trim();
            while (FullName.IndexOf("  ") != -1)
            {
                FullName = FullName.Replace("  ", " ");
                
            }
            
            string[] sub = FullName.Split(' ');
            for(int i = 0; i < sub.Length; i++)
            {
                sub[i] = sub[i].Substring(0, 1).ToUpper() + sub[i].Substring(1).ToLower();
                if (i < sub.Length - 1) res += (sub[i] + " ");
                else res += sub[i];
            }
            res = res.Replace(" ", "-");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
