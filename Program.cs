using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Porsche911 = new Car("911 Turbo S", "Porsche", "Very power sport engine:)", 500, 2021);
            var FordFocus = new Car("Focus C170", "Ford", "Zetec-E 1,6", 100, 2005);
            Console.WriteLine(Porsche911);
            Console.WriteLine(Car.FindMorePower(Porsche911, FordFocus));
        }
    }
}
