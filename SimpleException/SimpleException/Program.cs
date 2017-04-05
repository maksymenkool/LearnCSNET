using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    {
                        myCar.Accelerate(10);
                    }
                //Arg вызовет исключение выхода за пределы диапазона.
                //myCar.Accelerate(-1);
            }
            catch(CarIsDeadException e)
            {
                Console.WriteLine("\n***ERROR!***");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
                //Console.WriteLine("Stack: {0}", e.StackTrace);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Этот код будет выполняться всегда, вызникало исключение или нет.
                myCar.CrankTunes(false); // выключить радио.
            }
            
            Console.ReadLine();
        }
    }
}
