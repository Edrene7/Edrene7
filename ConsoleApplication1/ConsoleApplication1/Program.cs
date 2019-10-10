using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
          
        {
            Program p = new Program();

            Console.WriteLine("primer trabajo");
            int a, b, w, x, y, z;
            Console.WriteLine("agregar primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("agregar segundo numero");
            b = int.Parse(Console.ReadLine());
            w = a + b;
            x = a - b;
            y = b / a;
            z = a * b;
            Console.WriteLine("suma");
            if (a > b) Console.WriteLine(w);
            Console.WriteLine("diferencia");
            if (a > b) Console.WriteLine(x);
            Console.WriteLine("producto");
            if (a < b) Console.WriteLine(z);
            Console.WriteLine("division");
            if (a < b) Console.WriteLine(y);
            Console.ReadKey();
        }
       
    }
}
