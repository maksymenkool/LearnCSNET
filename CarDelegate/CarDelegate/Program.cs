using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сначала создать объект Car.
            Car c1 = new Car("SlugBug", 100, 10);

            //Теперь сообщить ему, какой метод вызывать,
            //когда он захочет отправить сообщение.
            c1.RegisterWithCarEngine (new Car.CarEngineHandler(OnCarEngineEvent));

            //Сохраним объект делегата для последующей отмены регистрации.
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine (new Car.CarEngineHandler(handler2));

            //Ускорить (это инициирует события).
            Console.WriteLine("*****Speeding up*****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            //Отменить регистрацию второго обработчика.
            c1.UnRegisterWithCarEngine(handler2);

            //Сообщения в верхнем регистре больше не выводятся.
            Console.WriteLine("*****Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

        //Это цель для входящих сообщений.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n*****Message From Car Object*****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
