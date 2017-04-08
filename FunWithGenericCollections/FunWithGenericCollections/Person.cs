using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public Person() { }

        public override string ToString()
        {
            //return base.ToString();
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]",
                FirstName, LastName, Age);
            return myState;
        }

        /*public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            Person temp;
            temp = (Person)obj;
            if (temp.FirstName == this.FirstName
                && temp.LastName == this.LastName
                && temp.Age == this.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public override bool Equals(object obj)
        {
            //Когда есть правильно переопред. метод
            //ToString() можно использовать его.
            return obj.ToString() == this.ToString();
        }

        //Возвратить хеш-код на основе значения ToString() объекта Person.
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }
    }
}
