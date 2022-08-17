// Задача 25: Напишите цикл, который 
// 1.принимает на вход два числа (A и B) и 
// 2.возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

{
    Console.Write("Введите число 1: ");
    int x = Int32.Parse(Console.ReadLine());

    Console.Write("Введите число 2: ");
    int b = Int32.Parse(Console.ReadLine());

    Math.Pow(x, b);

    Console.WriteLine(Math.Pow(x, b));
    Console.ReadKey();
}

