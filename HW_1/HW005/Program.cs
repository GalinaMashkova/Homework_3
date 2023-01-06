//Напишите программу, которая на вход
//принимает число (N),
// а на выходе показывает
// все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int [] array = {12, 31, 42, 54, 78};
int N = array.Length;
int index = 1;

while (index <= N)
{   
    if (array[index] % 2 == 0) 
   {
    Console.WriteLine (array[index]);
    }
   
    index = index + 1;
}