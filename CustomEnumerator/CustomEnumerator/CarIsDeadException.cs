using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class CarIsDeadException : ApplicationException
    {
        private string mesDet = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }
        /*public CarIsDeadException(string message, string cause, DateTime time)
        {
            mesDet = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        //Переопределение свойства Exception.Message.
        public override string Message
        {
            get
            {
                return string.Format("Car Error Message: {0}", mesDet);
            }
        }*/
        // Или можно так.
        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
