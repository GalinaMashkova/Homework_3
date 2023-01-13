// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
bool Palindrome(int a)
{
    int b = 0;
    int interval = a;
    while (a > 0)
    {
        int quantity = a % 10;
        a = a / 10;
        b = b * 10 + quantity;
    }
    return interval == b;
if(Palindrome(number))
    Console.WriteLine("Число не является палиндромом");
else 
    Console.WriteLine("Число не является палиндромом");
}