﻿//Задача 37. 
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

// 1. Создание массива.
int N = 10;
int[] array = new int[N];

//2. Заполняем массив случайными числами.
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine(); // печать списка случайных цифр

//3. Поиск 1 и последнего числа.
int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)

//4. Поиск произведения чисел и их печать.
 {
     Console.Write(array[i] * array[j] + " ");
     j--;
 }
 