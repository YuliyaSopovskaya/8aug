// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRnd (int size, int min, int max)
{

    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}


double[] arr = CreateArrayRnd(10, 1, 10);
PrintArray(arr);

double SummMinMax(double[] array)
{
    double numMax = array[0];
    double numMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (numMax < array[i])  numMax = array[i];
        if (numMin < array[i])  numMin = array[i];
    }
            double diff = numMax - numMin;
            return diff;
 }

Console.WriteLine($"Разница между мин и макс значением массива {Math.Round(SummMinMax(arr),2)}");