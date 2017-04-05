using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
        //Автоматические свойства. Должны быть доступны и для чтения и для записи.
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }

    class Garage
    {
        //Скрытое поддерживающее поле int установлено в 0.
        public int NumberOfCars { get; set; }
        //Скрытое поддерживающее поле Car установлено в null.
        public Car MyAuto { get; set; }

        //Для переопределения стандартных значений присвоенных скрытым
        //поддерживающим полям, должны использовать конструкторы.
        public Garage()
        {
            MyAuto = new AutoProps.Car();
            NumberOfCars = 1;
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Automatic Properties*****\n");

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";

            Console.WriteLine("Your car is named {0}? That`s odd...",
                c.PetName);
            c.DisplayStats();
            Console.WriteLine("******************");
            //Garage g = new Garage();
            //Нормально выводит стандартное значение, равное 0.
            //Но ошибка времени выполнения для значения null!!
            //Console.WriteLine("Number Of Cars: {0}", g.NumberOfCars);

            //Объект Car можно поместить в Garage.
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number Of Cars: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named {0}", g.MyAuto.PetName);
            Console.ReadLine();
        }
    }
}
