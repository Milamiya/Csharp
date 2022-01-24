using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập vào tên của bạn");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
            string[] doc = Console.ReadLine().Split(' ');
            for(int i = 0; i < doc.Length; i++)
            {
                Console.Write(doc[i]);
            }
            */
            string[] doc = Console.ReadLine().Split(' ');
            int day = int.Parse(doc[0]);
            int month = int.Parse(doc[1]);
            int year = int.Parse(doc[2]);
            DateTime dt = new DateTime(year, month, day);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.DayOfYear);
            Console.ReadKey();
        }
    }
}
