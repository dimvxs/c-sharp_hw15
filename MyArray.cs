using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class MyArray: iCalc, iOutput2, iCalc2
    {
//         Класс, созданный ранее в практическом задании Array,
//          должен имплементировать интерфейс ICalc.
// Метод Less — возвращает количество элементов массива 
// меньших, чем valueToCompare.
// Метод Greater — возвращает количество элементов
//  массива больших, чем valueToCompare.
// Напишите код для тестирования полученной функциональности.

public int[] elements;


     public MyArray(int[] elements)
        {
            this.elements = elements;
        }


   public int Less(int valueToCompare){
    int count = 0;
        for(int i = 0; i < elements.Length; i++){
            if(valueToCompare < elements[i]){
              count++;
            }

        }
        return count;
    }

    public int Greater(int valueToCompare){
        int count = 0;
        for(int i = 0; i < elements.Length; i++){
            if(valueToCompare > elements[i]){
              count++;
            }

        }
        return count;
    }

    public void ShowOdd(){
        Console.Write("нечетные числа: ");
        for(int i = 0; i < elements.Length; i++){
            if(elements[i] % 2 != 0){
                Console.Write(elements[i]);
            }
        }
    }

    public void ShowEven(){
               Console.Write("четные числа: ");
           for(int i = 0; i < elements.Length; i++){
            if(elements[i] % 2 == 0){
                Console.Write(elements[i]);
            }
        }
    }


    public int CountDistinct()
{
    int uniqueCount = 0;
    for (int i = 0; i < elements.Length; i++)
    {
        bool isUnique = true;
        for (int j = 0; j < i; j++)
        {
            if (elements[i] == elements[j])
            {
                isUnique = false;
                break;
            }
        }
        if (isUnique)
        {
            uniqueCount++;
        }
    }
    return uniqueCount;
}


        public int EqualToValue(int valueToCompare){
int count = 0;
for(int i = 0; i < elements.Length; i++){
    if(elements[i] == valueToCompare){
        count++;
    }

}
 return count;
 
        }


    }


}