// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
// }

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i, j] + "\t  ");
//     Console.WriteLine();
// }

// Console.WriteLine("Введите координаты");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > m && b > n)
//     Console.WriteLine("Такого элемента в массиве нет");

// else
// {
//     Console.WriteLine("Такой элемента в массиве есть");
// }




// метод

double[,] CreateMatrixRndDouble(int row, int col, int min, int max) 
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            double rand = rnd.NextDouble() * (max - min) + min; //округляем
            matrix[j, i] = Math.Round(rand , 2);

        }
    }
    return matrix;
} 

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ? 
            $"{matrix[i,j], 6}," : $"{matrix[i,j], 6} ");
        }
        Console.WriteLine("]");
    }
}

double[,] array2D = CreateMatrixRndDouble(3, 4, 10 , 40);
PrintMatrix(array2D);