
//10-99 числа
//78-8
//12-2

int number = new Random().Next(10,100); //10.99+1

//Console.WriteLine($"Случ число из диапазона 10-99 {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit == secondDigit) Console.WriteLine("Цифры равны");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");