//Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
    while (number > 0)
    {
        Sum = Sum + number % 10;
        number = number /10;
    }
Console.WriteLine(Sum);

// Console.WriteLine ("Введите трёхзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = number / 100;
// int b = number / 10 % 10;
// int c = number % 10;
// int Sum = a + b + c;
// {
//     Console.WriteLine(Sum);
// }