using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сделать коллекцию наблюдаемой и добавить в нее несколько объектов Person.
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person {FirstName = "Peter", LastName = "Murphy", Age=52 },
                new Person {FirstName = "Kevin", LastName = "Key", Age=48 }
            };

            people.Add(new Person { FirstName = "Mike", LastName = "Murphy", Age = 32 });
            //Привязать к событию CollectionChanged.
            people.CollectionChanged += people_CollectionChanged;

            people.Add(new Person { FirstName = "Mike", LastName = "Point", Age = 32 });
            people.Remove(people[0]);
        }

        static void people_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Выяснить действие, которое привело к генерации события.
            Console.WriteLine("Action for this event: {0}", e.Action);

            //Было что-то удалено.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }

            //Было что-то добавлено.
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the ТУЦ items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
