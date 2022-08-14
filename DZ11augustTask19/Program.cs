// принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");

{
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine((num == 0) || (reverse(num, 0) == num));
    Console.ReadKey(true);
}
 
 static int reverse(int num, int acc)
{
    while (num > 0) { acc = acc * 10 + num % 10; num /= 10; }
    return acc;
}