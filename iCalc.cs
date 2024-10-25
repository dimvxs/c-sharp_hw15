using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public interface iCalc
    {

//         Задание 1
// Создайте интерфейс ICalc. В нём должно
//  быть два метода:
// ■ intLess(intvalueToCompare) — возвращает 
// количество значений меньших, чем valueToCompare;
// ■ int Greater(int valueToCompare) — возвращает 
// количество значений больших, чем valueToCompare.
        int Less(int valueToCompare);  
        int Greater(int valueToCompare);
    }
}