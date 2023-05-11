/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в
 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Distance (double x1, double x2, double y1, double y2, double z1, double z2)
{
double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

Console.WriteLine($"Distance = {result}");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}


double Xa = ReadInt("Write the coordinates X1");
double Ya = ReadInt("Write the coordinates Y1");
double Za = ReadInt("Write the coordinates Z1");

double Xb = ReadInt("Write the coordinates X2");
double Yb = ReadInt("Write the coordinates Y2");
double Zb = ReadInt("Write the coordinates Z2");

Distance(Xa, Xb, Ya, Yb, Za, Zb);

Lutsenko();
