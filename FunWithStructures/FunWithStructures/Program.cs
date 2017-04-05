using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct Point
    {
        //Поля структур
        public int X;
        public int Y;

        //Специальный конструктор.
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        //Добавить 1 к позиции (X, Y).
        public void Increment()
        {
            X++; Y++;
        }

        //Вычесть 1 к позиции (X, Y).
        public void Decrement()
        {
            X--; Y--;
        }

        //Отобразить текущую позицию.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****A First Look at Struct*****\n");

            //Создать начальный экземпляр Point.
            Point myPoint;
            //Перед использованием необходимо обязательно инициализировать все публичные поля.
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            //Скорректировать значения X, Y.
            myPoint.Increment();
            myPoint.Display();

            Console.WriteLine("********************************");
            //Установить все поля в стандартные значения, используя стандартный конструктор.
            Point p = new Point();

            //Выводит X = 0, Y = 0.
            p.Display();
            Console.WriteLine("********************************");

            //Вызвать специальный конструктор.
            Point p2 = new Point(50, 60);
            //Выводит X = 50, Y = 60.
            p2.Display();
            Console.ReadLine();
        }
    }
}
