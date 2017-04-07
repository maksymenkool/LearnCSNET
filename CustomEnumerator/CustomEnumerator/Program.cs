using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with IEnumerable/IEnumerator*****\n");
            Garage carLot = new Garage();
            //Проход по всем объектам Car в коллекции?
            //В классе Garage не реализован метол GetEnumerator()
            //определенный в интерфейсе IEnumerable. Реализуем его
            //и все будет работать ))
            foreach(Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",
                    c.PetName, c.CurrentSpeed);
            }
            Console.ReadLine();
        }
    }
}
