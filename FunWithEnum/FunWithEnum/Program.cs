using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnum
{
    //Перечисления - это определяемый пользователем тип данных.
    //По умолчанию для зранения значений перечисления используют int
    enum EmpType
    {
        Manager,        //0
        Grunt,          //1
        Contractor,     //2
        VicePresident   //3
    }

    //Ошибка компиляции: 999 слишком велико для byte
    enum EmpType2 : byte
    {
        Manager = 10,        //0
        Grunt = 20,          //1
        Contractor = 100,     //2
        //VicePresident = 999   //3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun With Enum*****");
            //Создать тип подрядчика.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.WriteLine("**************************");
            //Вывести тип хранилища, используемый в перечислении.
            Console.WriteLine("EmpType uses a {0} for storage",
                Enum.GetUnderlyingType(emp.GetType()));
            //Следующая строка выведет ту же информацию посредством typeof.
            Console.WriteLine("EmpType uses a {0} for storage",
                Enum.GetUnderlyingType(typeof(EmpType)));
            //Получить строковое имя текущего значения. ToString().
            //Выводит строку "emp is a Contractor".
            Console.WriteLine("emp is {0}", emp.ToString());
            //Чтобы вывести не имя а значение переменной перечисления, можно
            //привести ее к лежащему в основе типу хранения.
            //Выводит строку "Contractor = 2".
            Console.WriteLine("{0} = {1}", emp.ToString(), (int)emp);
            Console.WriteLine("*********************************");
            //Вывод данных
            EvaluateEnum(emp);

            //Эти типы являются перечислениями из пространства имен System.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
            
        }

        //Этот метод выводит детали любого перечисления.
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about{0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}",
                Enum.GetUnderlyingType(e.GetType()));

            //Получить все пары "имя/значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            //Вывести строковое имя и ассоциированное значение,
            //используя флаг формата D.
            for(int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}.",
                    enumData.GetValue(i));
            }
        }

        //Использование перечислений в качестве параметров.
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead&");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
    }
}
