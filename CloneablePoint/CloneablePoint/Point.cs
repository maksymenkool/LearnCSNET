using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }

        public Point(int xPos, int yPos)
        {
            X = xPos; Y = yPos;
        }
        public Point() {}

        //Переопределить Object.ToString().
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}.\n",
                X, Y, desc.PetName, desc.PointID);
        }

        //Возвратить копию текущего объекта.
        public object Clone()
        {
            //Если класс или структура содержит только типы значений.
            //Копировать каждое поле почленно.
            //return this.MemberwiseClone();

            //Если содержит специальный тип, поддерживающий ссылочные
            //типы, для построения глубокой копии потребуется создание нового
            //объекта, который учитывает каждую перем. ссылочного типа.
            Point newPoint = (Point)this.MemberwiseClone();

            //Теперь заполним пробелы.
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
