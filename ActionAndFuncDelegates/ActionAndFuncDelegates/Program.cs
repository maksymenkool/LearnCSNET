using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Использовать делегат Action<> для указания на DisplayMessage.
            Action<string, ConsoleColor, int> actionTarget =
                new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            //Использование делегата Func<>
            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string sum = funcTarget2.Invoke(90, 300);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        //Это цель делегата Action<>
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            //Установить цвет консоли.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            //Восстановить цвет.
            Console.ForegroundColor = previous;
        }

        //Цель для Func<>
        static int Add(int x, int y)
        {
            return x + y;
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
