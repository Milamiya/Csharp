using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    
    
    
    class nhap
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
            Dog husky = new Dog();
            husky.nhapDog();
            husky.display();
            */
            Input DS = new Input();
            DS.nhapCat();
            Meo.display();
     
            Console.ReadKey();
        }
    }
}
