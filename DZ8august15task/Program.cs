//День недели

Console.WriteLine("Ведите номер дня недели");

int day;
day=int.Parse(Console.ReadLine());

if (day<=5) 
{
Console.WriteLine("Рабочий день");
}

else
{
    Console.WriteLine("Выходной");
} 