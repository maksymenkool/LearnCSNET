using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    //Этот делегат может указывать на любой метод,
    //принимающий два целых и возвращающий целое.
    public delegate int BinaryOp(int x, int y);

    //Этот класс содержит методе на каторые будет указывать BinaryOp.
    public class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Создать объект делегата BinaryOp, указывающий на SimpleMath.Add().
            //Когла нужно указать целевой метод делегату в конструктор передают имя метода.
            BinaryOp d = new BinaryOp(SimpleMath.Add);
            DisplayDelegateInfo(d);
            //Вызвать метод Add() непрямо с использованием объекта делегата.
            Console.WriteLine("10 + 10 is {0}", d(10, 10));//Invoke() вызывается здесь/ d.Invoke(10, 10).
            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            //Вывести на консоль имена каждого члена в списке вызовов делегата.
            foreach(Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method); //Имя метода.
                Console.WriteLine("Type Name: {0}", d.Target); //Имя типа.
            }
        }
    }
}
