int number = new Random().Next(100 , 1000);
Console.WriteLine($"Наше случайное число = {number}");
int number1 = number % 100;
int number2 = number1 / 10;

Console.WriteLine(number2);