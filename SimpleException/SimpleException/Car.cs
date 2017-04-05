using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        //Константа для представления макс. скорости.
        public const int MaxSpeed = 100;

        //Свойства авто.
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        //Не вышел ли авто из строя.
        private bool carIsDead;

        //Авто имеет радиоприемник.
        private Radio theMusicBox = new Radio();

        //Конструкторы.
        public Car() {}
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        //Делегировать запрос внутреннему объекту.
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        //Проверить не перегрелся ли авто.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if(CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    //carIsDead = true;
                    //Сгенерим исключение.
                    //throw new Exception(string.Format("{0} has overheated!", PetName));

                    CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName),
                        "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.Car.com";
                    throw ex;
                }
                else
                {
                    Console.WriteLine("=> Current Speed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
