using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        //Константные поля неявно статические.
        //Значение должно быть указано в момент определения!
        //Оно должно быть известно уже во время компиляции.
        public const double PI = 3.14;

        //Поля только для чтения могут присваиваться в конструкторах,
        //но нигде более.
        //Не являются статическими, при необходимости использования на 
        //уровне класса применить static. Но поле данных присваивается
        //во время выполнения.
        public readonly double PI2;
        public MyMathClass()
        {
            PI2 = 3.14;
        }

        /*Если использовать статич конструктор то значение будет задано
         * при первом обращении к классу.
         * static MyMathClass()
        {
            PI2 = 3.14;
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            //Ошибка! Нельзя менять константу!
            //MyMathClass.PI = 3.1444;
        }
    }
}
