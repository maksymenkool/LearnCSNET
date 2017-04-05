using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать экземпляр класса Car и установить макс.скорость в 80.
            Car myCar = new Car(80);

            //Установить текущую скорость.
            myCar.Speed = 50;
            Console.WriteLine("My Car is going {0} MPH", myCar.Speed);
            Console.WriteLine("*********************************");
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My Car is going {0} MPH", myVan.Speed);

            Console.ReadLine();
        }
    }
}
