using hw;

Console.WriteLine("Hello, World!");


       int[] numbers = { 3, 5, 7, 3, 8, 1, 4, 10, 6, 7, 8 };
            MyArray array = new MyArray(numbers);

            int valueToCompare = 5;

         
            Console.WriteLine($"Количество элементов меньше {valueToCompare}: {array.Less(valueToCompare)}");
            Console.WriteLine($"Количество элементов больше {valueToCompare}: {array.Greater(valueToCompare)}");

         
            array.ShowEven();
            Console.WriteLine(); 
            array.ShowOdd();
            Console.WriteLine(); 

       
            Console.WriteLine($"Количество уникальных значений в массиве: {array.CountDistinct()}");
            Console.WriteLine($"Количество элементов, равных {valueToCompare}: {array.EqualToValue(valueToCompare)}");