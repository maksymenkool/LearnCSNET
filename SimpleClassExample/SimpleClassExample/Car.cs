using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //Состояние объекта Car.
        public string petName;
        public int currSpeed;

        public Car() { }

        //Функциональность Car.
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MHP.", petName, currSpeed);
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
