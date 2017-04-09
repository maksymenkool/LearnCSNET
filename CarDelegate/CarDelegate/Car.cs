using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Car
    {
        //Данные состояния.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        //Исправлен ли автомобиль?
        private bool carIsDead;

        //Конструкторы класса.
        public Car() { MaxSpeed = 100; }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        //1. Определить тип делегата.
        public delegate void CarEngineHandler(string msgForCaller);
        //2. Определить переменную-член этого делегата.
        private CarEngineHandler listOfHandlers;
        //3. Добавить регистрационную функцию для вызывающего кода.
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }
        //4. Реализовать метод Accelerate() для обращения
        //   к списку вызовов делегата при нужных условиях.
        public void Accelerate(int delta)
        {
            //Если этот автомобиль сломан, отправить сообщение об этом.
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry, this car is dead...");
                }
            }
            else
            {
                CurrentSpeed += delta;
                //Автомобиль почти сломан?
                if(10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
