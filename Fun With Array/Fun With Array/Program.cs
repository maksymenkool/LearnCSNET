using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_With_Array
{
    class Program
    {
        static void SimpleArray()
        {
            Console.WriteLine("=> Simple Array Creation.");
            //Создать массив int, содержащий 3 элемента с индексами 0, 1, 2.
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            foreach(int i in myInts)
            {
                Console.WriteLine(i);
            }

            //Создать массив string, содержащий 100 элементов с индексами 0 - 99.
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            //Синтаксис инициализации массива с использованием ключевого слова new.
            string[] strArray = new string[] { "one", "two", "three" };
            Console.WriteLine("strArray has {0} elements", strArray.Length);

            //Синтаксис инициализации массива без использования ключевого слова new.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //Синтаксис инициализации массива используя new и размера.
            int[] intArr = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArr has {0} elements", intArr.Length);
            
            //Неявно типизированный массив.
            //c- на самом деле srting.
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        //Определение массива объектов.
        static void ArrOfObj()
        {
            Console.WriteLine("=> Array of Object");
            //Массив объектов может содержать все что угодно.
            object[] ob = new object[4];
            ob[0] = 10;
            ob[1] = false;
            ob[2] = new DateTime(1969, 3, 24);
            ob[3] = "Form & Void";
            foreach(object o in ob)
            {
                //Вывести тип и значение каждого элемента в массиве.
                Console.WriteLine("Type: {0}, Value: {1}", o.GetType(), o);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Arrays *****");
            SimpleArray();
            Console.WriteLine("*****************************");
            ArrOfObj();
            Console.WriteLine("*****************************");
            ArrayInitialization();
            Console.WriteLine("*****************************");
            RectMultidimensionalArr();
            Console.WriteLine("*****************************");
            JaggedArr();
            Console.WriteLine("*****************************");
            PassAndReceiveArrays();
            Console.ReadLine();
        }

        //Многомерные массивы.
        static void RectMultidimensionalArr()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            //Прямоугольный многомерный массив.
            int[,] myMatrix;
            myMatrix = new int[6, 6];
            //Заполним массив 6*6.
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }
            //Вывести массив 6*6.
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                    Console.Write(myMatrix[i,j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //Зубчатый массив. массив массивов.
        static void JaggedArr()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            //Зубчатый многомерный массив.

            //Здесь мы имеем массив из 5 массивов.
            int[][] myjarr = new int[5][];

            //Создать зубчатый массив.
            for (int i = 0; i < myjarr.Length; i++)
                myjarr[i] = new int[i + 7];

            //Вывести кажую строку (каждый элемент имеет стандартное значение 0).
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < myjarr[i].Length; j++)
                {
                    Console.Write(myjarr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] myInt)
        {
            for(int i = 0; i < myInt.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInt[i]);
            }
        }

        static string[] GetStringArray()
        {
            string[] theStrings = {"Hello", "from", "GetStringArray"};
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Array as params and return values.");
            //Передать массив в качестве параметра.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            //Получить массив в качестве возвращаемого значения.
            string[] strs = GetStringArray();
            foreach(string s in strs)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
