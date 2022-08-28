// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размер матрицы:");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int[,] matrix = new int[N, M];
Random rand = new Random();
int[] summ = new int[M];

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        matrix[i, j] = rand.Next(0, 10); 
    }
}
Console.WriteLine("Матрица");

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(matrix[i, j]); //матрица
        summ[i] += matrix[j, i];    //подсчет суммы 
    }
    Console.WriteLine();
}

Console.WriteLine();
foreach (double elem in summ)
{
    // Console.WriteLine(Math.Round(summ, 2));  забыла, где вставляется округление
    Console.WriteLine(elem / M); //вывод среднего
}
