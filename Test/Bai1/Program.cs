using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            float delta = 0;
            Console.Write("Nhap he so a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so c: ");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Delta < 0");
            }
            else
            {
                Console.WriteLine("Sqrt delta = " + (float)Math.Sqrt(delta));

            }

            Console.ReadLine();
        }
    }
    
}
