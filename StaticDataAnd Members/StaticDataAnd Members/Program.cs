using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAnd_Members
{
    //Простой класс депозитного счета
    class SavingAccount
    {
        //Данные уровня экземпляра.
        public double currBalance;
        //Статический элемент данных.
        private static double currInterestRate = 0.04;
        
        public SavingAccount(double balance)
        {
            currBalance = balance;
        }

        //Статическое свойство для установки/получения процентной ставки.
        public static double InterestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести текущую процентную ставку через свойство.
            Console.WriteLine("Interest Rate is: {0}", SavingAccount.InterestRate);

        }
    }
}
