using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chisodau, chisocuoi, sodien, tiendien = 0;
            Console.Write("Nhap vao chi so dau: ");
            chisodau = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao chi so cuoi: ");
            chisocuoi = int.Parse(Console.ReadLine());

            sodien = chisocuoi - chisodau;
            if (sodien > 0 && sodien <= 25)
            {
                tiendien = sodien * 1000;
            }
            else if (sodien <= 75)
            {
                tiendien = 25 * 1000 + (sodien - 25) * 1250;
            }
            else if (sodien <= 150)
            {
                tiendien = 25 * 1000 + 50 * 1250 + (sodien - 75) * 1800;
            }
            else
            {
                tiendien = 25 * 1000 + 50 * 1250 + 75 * 1800 + (sodien - 150) * 2500;
            }

            Console.WriteLine("Tien dien la: " + tiendien);

            Console.ReadLine();
        }
    }
}
