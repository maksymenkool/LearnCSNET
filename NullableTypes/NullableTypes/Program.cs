using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ошибка на этапе компиляции
            //Типы значений не могут быть установлены в null!
            //boll myBool = null;
            //int myInt = null;

            //Строки являются ссылочными типами.
            string myStr = null;
        }

        //Типы данных допускающих null.
        //Чтобы определить переменную типа, допускающего null,
        //нужно предварить Имя необходимого типа знаком вопроса ?
        static void LocalNullableVariables()
        {
            //Определим несколько локальных переменных, допускающих null.
            int? nullableInt = 10;
            double? nullableDouble = 2.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrOfNullableInts = new int?[10];

            //Ошибка - строки уже nullable!
            //string? s = "oops";
        }
    }
    
    //Используется часто при работе с базами данных.
    class DataBaseReader
    {
        //Поле данных допускающих null.
        public int? numericValue = null;
        public bool? boolValue = true;

        //Обратим внимание на возвращающий тип, допускающий null.
        public int? GetIntFromDataBase()
        { return numericValue; }

        //Обратим внимание на возвращающий тип, допускающий null.
        public bool? GetBoolFromDataBase()
        { return boolValue; }
    }
}
