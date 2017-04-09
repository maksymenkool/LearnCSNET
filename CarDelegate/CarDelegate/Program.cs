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

            //Ускорить (это инициирует события).
            Console.WriteLine("*****Speeding up*****");
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
    }
}
