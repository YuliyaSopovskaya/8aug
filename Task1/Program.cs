Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
            int a, b;
            Console.WriteLine("Введи первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
 
            bool Ch0 = a > b;
            bool Ch1 = a == b;
            bool Ch2 = a < b;
 
            if (Ch0)
            {
                Console.WriteLine($"Число {a} больше чем {b}");
            }
            else if (Ch1)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
            else
            {
                Console.WriteLine($"Число {b} больше чем {a}");
            }