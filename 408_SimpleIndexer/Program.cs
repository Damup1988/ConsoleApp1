using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _408_SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Indexers ***\n");

            PersonCollection MyCommune = new PersonCollection();

            MyCommune[0] = new Person("Homer", "Simpson", 40);
            MyCommune[1] = new Person("Marge", "Simpson", 38);
            MyCommune[2] = new Person("Lis", "Simpson", 9);
            MyCommune[3] = new Person("Bart", "Simpson", 7);
            MyCommune[4] = new Person("Maggie", "Simpson", 2);

            for (int i = 0; i < MyCommune.Count; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name {0} {1}", MyCommune[i].FirstName, MyCommune[i].LastName);
                Console.WriteLine("Age: {0}", MyCommune[i].Age);
                Console.WriteLine();
            }
        }
    }
}