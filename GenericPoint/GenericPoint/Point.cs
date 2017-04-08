using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    //Обобщенная структура Point
    public struct Point<T>
    {
        //Обобщенные данные состояния.
        private T xPos;
        private T yPos;

        //Обобщенный конструктор.
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        //Обобщенные свойства.
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", xPos, yPos);
        }

        //Сбросим поля в стандартные значения
        //для задаваемого параметра типа.
        public void ResetPoint()
        {
            xPos = default(T);//при использовании в обобщениях default
            yPos = default(T);//устанавливает стандартные значения для
                              //параметра типа(0, "", null)
        }
    }
}
