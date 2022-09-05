// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

    Console.Write("Введите значение переменной а: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите значение переменной b: ");
    int b = int.Parse(Console.ReadLine());

    if (a > b) Console.WriteLine("Ошибка! Так как а > b");
    else
    {
        int i, sum = 0;
        for (i = a; b >= i; i++)
            sum += i;
        Console.WriteLine("Сумма чисел равна: " + sum);
    }