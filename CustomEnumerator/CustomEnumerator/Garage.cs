using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    public class Garage : IEnumerable
    {
        //System.Array уже реализует IEnumerator
        private Car[] carArray = new Car[4];

        //Заполнить первоначально несколькими объектами Car.
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            //Возвратить IEnumerator объекта массива.
            return carArray.GetEnumerator();
        }

        //Чтобы скрыть функциональность IEnumerator на уровне объекта,
        //достаточно воспользоваться явной реализацией интерфейса:
        /*IEnumerator IEnumerable.GetEnumerator()
        {
            //Возвратить IEnumerator объекта массива.
            return carArray.GetEnumerator();
        }*/
        //или так:
        /*public IEnumerator GetEnumerator()
        {
            foreach (Car c in carArray)
            {
                yield return c;
            }
        }*/
    }
}
