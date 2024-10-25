using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public interface iOutput2
    {

//         Задание 2
// Создайте интерфейс IOutput2. В нём должно быть два метода:
// ■ void ShowEven() — отображает четные значения из контейнера с данными;
//  void ShowOdd() — отображает нечетные значения из контейнера с данными.
// Класс, созданный ранее в практическом задании Array, должен имплементировать интерфейс IOutput2.
// Метод ShowEven — отображает четные значения из массива.
// Метод ShowOdd — отображает нечетные значения из массива.
// Напишите код для тестирования полученной функ- циональности.
        void ShowEven();
        void ShowOdd();
    }
}