//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
{
    Console.WriteLine(number / 10 % 10);
}

//int number = 456;
//int a = number / 100; // выводит первое число
//int b = number / 10 % 10; // выводит второе число
//int c = number % 10; // выводит третье число
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);


//Со строками не подходит
//Console.WriteLine ("Введите трёхзначное число");
//string str;
//int number;
//str = Console.ReadLine(); //считываем число, которое вводим в консоль в строку str.
//number = Convert.ToInt32(str); //конвертируем строку и результат помещаем в переменую number.
//Console.WriteLine(str[1]);
//Console.WriteLine(str.Substring(1,1)); //или так можно