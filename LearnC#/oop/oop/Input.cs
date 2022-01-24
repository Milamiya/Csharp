using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Input
    {
        private Animal nhap()
        {
            double weight;
            double height;
            Console.WriteLine("Nhập chiều cao");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng");
            weight = double.Parse(Console.ReadLine());
        }
        public void nhapCat()
        {
            Animal x = nhap();
            string Nametag;
            Console.WriteLine("Nhập tên cho mèo");
            Nametag = Console.ReadLine();
        }
        public void displayCat()
        {
            Cat x = nhapCat();
            Console.WriteLine("Chiều cao : " + Height + "\nCân nặng : " + Weight + "\nTên : " + Nametag);
        }
    }
}
