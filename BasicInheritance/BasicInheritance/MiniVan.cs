using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    //MiniVan "is" Car
    //class MiniVan : Car
    //Класс MiniVan не может быть расширен! sealed - запечатанный.
    //Все структуры неявно запечатанные.
    sealed class MiniVan : Car
    {

    }
}
