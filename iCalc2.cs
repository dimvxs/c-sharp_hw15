using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public interface iCalc2
    {
//         Задание 3
// Создайте интерфейс ICalc2. В нём должно быть два метода:
// ■ intCountDistinct()—возвращает количество уникальных значений в контейнере данных;
// ■ int EqualToValue(int valueToCompare) — возвращает количество значений равных valueToCompare.
// Класс, созданный ранее в практическом задании Array, должен имплементировать интерфейс ICalc2.
// Метод CountDistinct — возвращает количество уни- кальных значений в массиве.
// Метод EqualToValue — возвращает количество эле- ментов массива равных valueToCompare.
// Напишите код для тестирования полученной функ- циональности.
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}