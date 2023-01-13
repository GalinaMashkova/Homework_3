//Задача 23/ Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

// Считати от пользователя N
int GetNumberByUser(string text)
{
    Console.Write(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// Создание массива
int[] CreateArray(int size) 
{
    return new int [size];
}
 
//Метод получения кубов чисел
void GetCubes(int[] ColNumber)
{
    int count = ColNumber.Length; //получение длины массива

    for (int i = 1; i < count; i++)
    {
        ColNumber[i] = i * i * i;
    }
}

// Распечатать результат
string Print(int[] numbers)
  {
    string output = String.Empty;
    int size = numbers.Length;

    for (int i = 1; i < size; i++)
    {
output = output + $"{i}^3 = {numbers[i]}\n";
    }
 
    return output;
 }

string Print2(int[] numbers)
  {
    string output = String.Empty;
    int size = numbers.Length;

    for (int i = 1; i < size; i++)
    {
output = output + $"- {i}^3 = **{numbers[i]}**\n";
    }
 
    return output;
 }

int countByUser = GetNumberByUser("Введите число N");
int[] list  = CreateArray(countByUser); // задаем массив
GetCubes(list);
string result = Print(list);
Console.WriteLine(result);

Console.WriteLine(); // создание пустой строки

File.WriteAllText("list.md", Print2(list));