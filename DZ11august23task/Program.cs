// число (N) 
// выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n > 0)
{
for (int i = 1; i <= n; i++)
{
Console.WriteLine($"{i}\t{i * i * i}");
}
}
else Console.WriteLine("Введено некорректное значение");