using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _474_LinqUsingEnumerable
{
    class Program
    {
        static void QueryStringsWithOperators()
        {
            Console.WriteLine("\n*** Using Query Operators ***\n");

            string[] CurrentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            var subset = from c in CurrentVideoGames where c.Contains(" ") select c;

            foreach(var v in subset)
            {
                Console.WriteLine(v);
            }
        }

        static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("\n***** Using Enumerable / Lambda Expressions *****\n");

            string[] CurrentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            var subset = CurrentVideoGames.Where(c => c.Contains(" ")).OrderByDescending(c => c).Select(c => c);

            foreach(var v in subset)
                Console.WriteLine(v);
        }

        static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("\n***** Using Anonymous Methods *****\n");

            string[] CurrentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" ")};
            Func<string, string> itemToProcess = delegate (string s) { return s; };
            var subset = CurrentVideoGames.Where(searchFilter).Select(itemToProcess);

            foreach(var v in subset)
                Console.WriteLine(v);
        }

        static void Main(string[] args)
        {
            QueryStringsWithOperators();
            QueryStringsWithEnumerableAndLambdas();
            QueryStringsWithAnonymousMethods();

            VeryComplexQueryExpression.QueryStringsWithRawDelegates();

            Console.ReadLine();
        }
    }
}
