Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них больше");
            int a, b, c;
            int max;
            Console.WriteLine("Введи первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введи третье число - ");
            c = Convert.ToInt32(Console.ReadLine());

max = a;
Console.WriteLine($"Число {a} максимальное");
if (b > a) 
    max = b;
    Console.WriteLine($"Число {b} максимальное");
if (c > max)
    max = c;
    Console.WriteLine($"Число {c} максимальное");

