using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _474_LinqUsingEnumerable
{
    class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine("\n*** Using Raw Delegates ***\n");

            string[] CurrentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            Func<string, bool> searchFilter = new Func<string, bool>(Filter);
            Func<string, string> searchItem = new Func<string, string>(item);

            var subset = CurrentVideoGames.Where(searchFilter).Select(item);

            foreach(var v in subset)
                Console.WriteLine(v);
        }

        public static bool Filter(string Game) => Game.Contains(" ");
        //public static bool Filter(string Game) { return Game.Contains(" "); }
        public static string item(string Game) => Game;
        //public static string item(string Game) { return Game; }
    }
}