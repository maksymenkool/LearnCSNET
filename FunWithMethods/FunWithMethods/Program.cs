using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        //По умолчанию аргументы передаются по значению
        static int Add(int x, int y)
        {
            int ans = x + y;
            //Вызывающий код не увидит эти изменения,
            //т.к. изменяется копия исходных данных
            x = 10000;
            y = 88888;
            return ans;
        }

        //out
        //значение выходных параметров должны быть установлены вызываемвм методом
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        //out
        //Возврат множества выходных параметров.
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        //ref
        //Ссылочные параметры.
        public static void SwapStrings( ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        //params
        // Возвращение среднего из некоторого количества значений double.
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0) return sum;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return (sum / values.Length);
        }

            static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Methods *****\n");

            //Передать две переменные по значению.
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("**********************************");
            //Присваивать начальные значения локальным переменным,
            //используемым как выходные параметры, не обязательно,
            //при условии, что в таком качестве они используются первый раз.
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            Console.WriteLine("**********************************");
            //Модификатор out должен указываться как при вызове,
            //так и при реализации данного метода.
            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            Console.WriteLine("**********************************");
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Befor: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
            Console.WriteLine("**********************************");
            //Передать разделяемый запятыми список значений double...
            double av;
            av = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", av);

            //... или передать массив значений double.
            double[] data = { 4.0, 3.2, 5.7 };
            av = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", av);
            //Среднее из 0 равно 0.
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.WriteLine("**********************************");
            Console.ReadLine();
        }
    }
}
