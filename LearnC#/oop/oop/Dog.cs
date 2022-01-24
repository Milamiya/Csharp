using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Dog : Animal
    {
        private string hastag;
        public string Hastag { get => hastag; set => hastag = value; }
        public void nhapDog()
        {
            Console.WriteLine("Nhập chiều cao cho chó");
            Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng cho chó");
            Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên cho chó");
            Hastag = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("Chiều cao : " + Height + "\nCân nặng : " + Weight + "\nTên : " + Hastag);
        }
    }
}
