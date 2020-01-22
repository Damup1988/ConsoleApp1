using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _382_ActionAndFuncDelegates
{
    class Program
    {
        static void DisaplyMessage(string Msg, ConsoleColor txtColor, int PrintCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for(int i = 0; i < PrintCount; i++)
            {
                Console.WriteLine(Msg);
            }

            Console.ForegroundColor = previous;
        }

        static int Add(int x, int y) => x + y;

        static string SumToString(int x, int y) => (x + y).ToString();

        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Action and Func ***");

            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisaplyMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            //Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string result2 = funcTarget2.Invoke(90, 300);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}