// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Без применения метода.

// int x1 = 3;
// int x2 = 2;
// int y1 = 6;
// int y2 = 1;
// int z1 = 8;
// int z2 = -7;

// double distance = GetDistance(x1, x2, y1, y2, z1, z2);
// System.Console.WriteLine(distance);

// double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
// {
// //    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)); //как вариант
//     return Math.Sqrt(Math.Pow(x1 - x2, 2) 
//             + Math.Pow(y1 - y2, 2) 
//             + Math.Pow(z1 - z2, 2));
// }


// С применением методов 3D
double GetDistance3D(double x1, double x2,double y1,double y2,double z1,double z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2)
            + Math.Pow(y1 - y2, 2) 
            + Math.Pow(z1 - z2, 2));
}

double GetValue(string text)
{
    System.Console.Write(text); // считываем текст
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetValue("x1 = ");
double x2 = GetValue("x2 = ");
double y1 = GetValue("y1 = ");
double y2 = GetValue("y2 = ");
double z1 = GetValue("z1 = ");
double z2 = GetValue("z2 = ");

double distance = GetDistance3D(x1, x2, y1, y2, z1, z2);
System.Console.WriteLine(distance);


// Задача 21. Работа в группах.
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1), -> 5.09
// A (7,-5); B (1,-1) -> 7.21

// int x1 = 3;
// int x2 = 2;
// int y1 = 6;
// int y2 = 1;

// double distance = GetDistance(x1, x2, y1, y2);
// System.Console.WriteLine(distance);

// double GetDistance(int x1, int x2, int y1, int y2)
// {
//     return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
// }

// С применением методов 2D

// double GetDistance2D(double x1, double x2,double y1,double y2)

// {
//     return Math.Sqrt(Math.Pow(x1 - x2, 2)
//             + Math.Pow(y1 - y2, 2));
// }

// double GetValue(string text)
// {
//     System.Console.Write(text); // считываем текст
//     return Convert.ToDouble(Console.ReadLine());
// }

// double x1 = GetValue("x1 = ");
// double x2 = GetValue("x2 = ");
// double y1 = GetValue("y1 = ");
// double y2 = GetValue("y2 = ");

// double distance = GetDistance2D(x1, x2, y1, y2);
// System.Console.WriteLine(distance);