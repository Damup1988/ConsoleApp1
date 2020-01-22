using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _431_AnonymousTypes
{
    class Program
    {
        static void BuildAnonType(string make, string color, int currSp)
        {
            var car = new { Make = make, Color = color, Speed = currSp };
            Console.WriteLine("You have a {0} {1} goinf {2} MPH", car.Color, car.Make, car.Speed);
            Console.WriteLine("ToString() == {0}", car.ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Anon Types ***\n");

            var myCar = new { Color = "Pink", Make = "Saab", CurrentSpeed = 50 };
            var myCar2 = new { Color = "Pink", Make = "Saab", CurrentSpeed = 60 };
            var MyCar3 = new { Color = "Pink", Make = "Saab" };
            Console.WriteLine("My car is {0} {1}", myCar.Color, myCar.Make);

            BuildAnonType("BMW", "Black", 90);
            if(myCar.Equals(MyCar3))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }
    }
}
