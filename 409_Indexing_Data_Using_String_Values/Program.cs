using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _409_Indexing_Data_Using_String_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Indexers ***");

            PersonCollection MyCommune = new PersonCollection();

            MyCommune["Homer"] = new Person("Homer", "Simpson", 40);
            MyCommune["Marge"] = new Person("Marge", "Simpson", 38);

            Person homer = MyCommune["Homer"];
            Console.WriteLine(homer.ToString());

            Console.ReadLine();
        }
    }
}