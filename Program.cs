using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classhinhchunhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("moi ban nhap chieu rong ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine(" moi ban nhap chieu cao ");
            int height = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("thong so hinh chu nhat " + rectangle.Display());
            Console.WriteLine("dien tich la: " + rectangle.getArea());
            Console.WriteLine("Chu vi la: " + rectangle.getPer());
            Console.ReadKey();
        }
    }
}
