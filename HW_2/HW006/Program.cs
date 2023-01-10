//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трёхзначное число");
string str;
int number;
str = Console.ReadLine(); //считываем число, которое вводим в консоль в строку str.
number = Convert.ToInt32(str); //конвертируем строку и результат помещаем в переменую number.
Console.WriteLine(str[1]);
//Console.WriteLine(str.Substring(1,1)); //или так можно
