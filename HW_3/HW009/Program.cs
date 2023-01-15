// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

    Console.WriteLine("Введите пятизначное число ");
    int number = Convert.ToInt32(Console.ReadLine());
{
    int n, digit, rev = 0;
    
    n = number;
    do
    {
        digit = number % 10;
        rev = (rev * 10) + digit;
        number = number / 10;
    } while (number != 0);
 
    if (n == rev)
        Console.WriteLine ("Число является палиндромом ");
    else
        Console.WriteLine ("Число не является палиндромом ");

    return 0;
}

