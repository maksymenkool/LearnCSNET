using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.WriteLine("***************************************");
            UseGenericStack();
            Console.WriteLine("***************************************");
            UseGenericQueue();
            Console.WriteLine("***************************************");
            UseSortedSet();
        }

        static void UseGenericList()
        {
            //Создать список объектов Person и заполнить его с помощью
            //синтаксиса инициализации объектов/коллекции.
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age=47 },
                new Person {FirstName = "Marge", LastName = "Simpson", Age=45 },
                new Person {FirstName = "Lisa", LastName = "Simpson", Age=9 },
                new Person {FirstName = "Bart", LastName = "Simpson", Age=8 }
            };
            //Вывести на консоль количество элементов в списке.
            Console.WriteLine("Items in list: {0}", people.Count);
            //Выполнить перечисление по списку.
            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }
            //Вставить новую персону.
            Console.WriteLine("\n->Insert new Person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);
            //Скопировать данные в новый массив.
            Person[] arrayOfPeople = people.ToArray();
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                Console.WriteLine("First Name: {0}", arrayOfPeople[i].FirstName);
            }

        }

        static void UseGenericStack() //LIFO
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person
                { FirstName = "Homer", LastName = "Sipmson", Age = 47 });
            stackOfPeople.Push(new Person
            { FirstName = "Marge", LastName = "Sipmson", Age = 45 });
            stackOfPeople.Push(new Person
            { FirstName = "Lisa", LastName = "Sipmson", Age = 9 });

            //Посмотреть верхний элемент, вытолкнуть его и просмотреть снова.
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("First person item is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message); //Стек пуст!
            }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseGenericQueue()
        {
            //Создать очередь из трех человек.
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person
                { FirstName = "Homer", LastName = "Sipmson", Age = 47 });
            peopleQ.Enqueue(new Person
                { FirstName = "Marge", LastName = "Sipmson", Age = 45 });
            peopleQ.Enqueue(new Person
                { FirstName = "Lisa", LastName = "Sipmson", Age = 9 });

            //Кто первый в очереди?
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);

            //Удалить всех из очереди.
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            //Попробовать извлечь кого-то из очереди снова.
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("\nError! {0}", e.Message); //Очередь пуста.
            }
        }

        static void UseSortedSet()
        {
            //Создать несколько людей разного возраста.
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age=47 },
                new Person {FirstName = "Marge", LastName = "Simpson", Age=45 },
                new Person {FirstName = "Lisa", LastName = "Simpson", Age=9 },
                new Person {FirstName = "Bart", LastName = "Simpson", Age=8 }
            };

            //Обратите внимание, что элементы отсортированы по возрасту.
            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            //Добавить еще несколько людей разного возраста.
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
            
            //Элементы по-прежнему отсортированы по возрасту.
            foreach(Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }
    }
}
