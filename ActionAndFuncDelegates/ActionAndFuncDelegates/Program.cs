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
    }
}
