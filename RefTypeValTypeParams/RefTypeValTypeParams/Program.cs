using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person() {}

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }
    class Program
    {
        //Передача ссылочных типов по значению.
        static void SendPersonByValue(Person p)
        {
            //Изменит ли значение возраста?
            p.personAge = 99;
            //Возможно изменение данных состояния объекта на который передана ссылка

            //Увидит ли вызывающий код это изменение?
            p = new Person("Nikki", 99);
            //Невозможно лишь изменить то, на что ссылка указывает!!!
        }

        //Передача ссылочных типов по ссылке.
        //Теперь можно изменить не только состояние, но и
        //переопределять ссылку так, чтобы она указывала на новый объект.
        static void SendPersonByReference(ref Person p)
        {
            //Изменить некоторые данные р.
            p.personAge = 555;

            //Теперь указывает на новый объект в куче!!!
            p = new Person("Nikki", 999);
        }

        static void Main(string[] args)
        {
            //Передача ссылочных типов по значению.
            //Может менять данные состояния объекта, но не объект на который указывает ссылка.
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call? Person is:");
            fred.Display();// Name: Fred, Age: 12

            SendPersonByValue(fred);
            Console.WriteLine("\nAfter by value call? Person is:");
            fred.Display();// Name: Fred, Age: 99

            Console.WriteLine("************************************");
            //Передача типов по ссылке.
            //Может менять и данные состояния объекта и объект на который указывает ссылка.
            Person mel = new Person("Mel", 23);
            Console.WriteLine("\nBefore by value call? Person is:");
            mel.Display();// Name: Mel, Age: 23

            SendPersonByReference(ref mel);
            Console.WriteLine("\nAfter by value call? Person is:");
            mel.Display();// Name: Nikki, Age: 999
            Console.ReadLine();
        }
    }
}
