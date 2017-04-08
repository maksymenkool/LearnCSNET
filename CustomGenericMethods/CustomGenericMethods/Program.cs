using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0}, {1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0}, {1}", s1, s2);
            Console.WriteLine();

            //Если обобщенный метод требует аргументов, то явно 
            //тип можно не указывать, компилятор сам его определит.
            //Ну лучше/правильней все же тип указывать явно.
            bool b1 = true, b2 = false;
            Console.WriteLine("Before swap: {0}, {1}", b1, b2);
            Swap(ref b1, ref b2);
            Console.WriteLine("After swap: {0}, {1}", b1, b2);
            Console.WriteLine();
        }

        //Этот метод обменивает между собой значения двух
        //элементов типа, переданного в параметре <T>.
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You send the Swap() method a {0}",
                typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
