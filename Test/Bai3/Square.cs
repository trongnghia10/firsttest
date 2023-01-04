using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Square
    {
        float canh;
        public void nhap()
        {
            Console.Write("Nhap vao canh hinh vuong");
            canh = float.Parse(Console.ReadLine());
        }
        public void hienthicanh()
        {
            Console.WriteLine("Do dai canh la: " + canh);
        }
        public void tinhchuvi()
        {
            Console.WriteLine("Chu vi hinh vuong la: " + canh * 4);
        }
        public void tinhdientich()
        {
            Console.WriteLine("Dien tich hinh vuong là: " + canh * canh);
        }
        public void hienthiall()
        {
            hienthicanh();
            tinhchuvi();
            tinhdientich();
        }
    }
}
