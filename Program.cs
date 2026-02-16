using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;
            double By = 22 / 7;
            int r = 6;
            A = By * r * r;
            Console.WriteLine("Area of Circle is : " + A);
            Console.ReadKey();
        }
    }
}
