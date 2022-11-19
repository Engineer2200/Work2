 int number = new Random().Next(1 , 155);     
 Console.WriteLine($"Наше случайное число = {number}");

 if (number>100)
     {
        Console.WriteLine(number.ToString()[2]);
     }
 else
 {
     Console.WriteLine("Нет третьей цифры ");
 }

