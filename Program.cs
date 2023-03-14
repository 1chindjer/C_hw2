//FIRST TASK
// Console.WriteLine("ПЕРВАЯ ЗАДАЧА");
// Console.WriteLine("введите трехзначное число");
// int num11 = int.Parse(Console.ReadLine()!);
// int result = (num11%100)/10;
// Console.WriteLine($"вторая цифра {result}");
// *********************************************************** SECOND TASK
// Console.WriteLine("ВТОРАЯ ЗАДАЧА");
// Console.WriteLine("введите число");
// int num21 = int.Parse(Console.ReadLine()!);
// int result = (int)Math.Log10(num21) + 1;
// Console.WriteLine($"в веденном числе {result} цифр");
// if (result <3) {
//     Console.WriteLine("третьей цифры нет");
// }
// else {
//     while (num21>=999) {
//         num21=num21/10;
//         result = num21%10;
//     }
// }
// Console.WriteLine($"третья цифра {result}");
// *********************************************************** THIRD TASK
Console.WriteLine("ТРЕТЬЯ ЗАДАЧА");
Console.WriteLine("введите число, означающее день недели");
int num31 = int.Parse(Console.ReadLine()!);
if (num31 >7) {
    Console.WriteLine("Число больше 7. В неделе максимум 7 дней. Введите число не более 7");
}
else if (num31<6) {
        Console.WriteLine("Будний день :( ");}
    else Console.WriteLine( "Выходной :)");
        