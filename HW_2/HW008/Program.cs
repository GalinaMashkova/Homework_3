//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели
// и проверяет, является ли этот день выходным.

// 0 1 2  3  4  5  6
// 7 8 9 10 11 12 13

Console.WriteLine("Введите цифру");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (day % 7); //для определения цифр после 6-проверка
if(day % 7 >= 5)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Будни");

// Замечания преподавателя
// Перемудрили с решением. Остаток от деления 7 на 7 будет 0, и соответственно программа будет выдавать ответ "будни". Следовало тогда проверять остаток от деления на число между 7 и 8 (7.1, 7.2, 7.68 и т. д.).
// Но даже при таком подходе Вам следовало все же учесть ввод чисел, не входящих в диапазон от 1 до 7.
// Последний вариант решения у Вас верный) Поэтому засчитываю!

//С использованием массива
//Console.WriteLine("Введите цифру");
//int day = Convert.ToInt32(Console.ReadLine());
//string[] dayOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
//Console.WriteLine (day % 7);
//Console.WriteLine (dayOfWeek [day % 7]);
//if(day % 7 >= 5)
//    Console.WriteLine("да");
//else
//    Console.WriteLine("нет");


//string Week(int day)
//{
//    if (day == 6 || day ==7 )
//    return ("Выходной");
//else if (day >= 1 || day <= 5)
//    return ("Будни");   
//else
//    return ("Не существует");
//}

//Console.WriteLine(Week(6));