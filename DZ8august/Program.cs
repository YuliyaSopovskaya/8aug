//трехзначное число ввести
//показать вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }