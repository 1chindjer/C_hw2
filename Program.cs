//FIRST TASK
Console.WriteLine("ПЕРВАЯ ЗАДАЧА");
Console.WriteLine("введите трехзначное число");
int num11 = int.Parse(Console.ReadLine()!);
int result = (num11%100)/10;
Console.WriteLine($"вторая цифра {result}");