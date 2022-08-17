// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


        {
            int size = 8;
            int[] array = new int[8];
            Random myRandom = new Random();
 
            Console.WriteLine("Вывод ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
 
        }
