// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

{
Console.WriteLine("Введите количество чисел:");
int n = Convert.ToInt32(Console.ReadLine());
double [] mas = new double[n];
int pol = 0;
    for (int i = 0; i < n; i++)
    {
    Console.WriteLine("Введите число:");
    mas[i] = Convert.ToDouble(Console.ReadLine());
    }
        for (int i = 0; i < mas.GetLength(0); i++)
        {
        if (mas[i] >= 0)
        {
        pol++;
        }
        }
    Console.WriteLine("Количество положительных чисел", pol);
    Console.WriteLine(pol);
}    