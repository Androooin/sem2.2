/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Number()
{
    Console.WriteLine("Write number");
    int a = Convert.ToInt16(Console.ReadLine());
    return a;
}

void Coub(int num1)
{
    for (int i = 1; i <= num1 - 1; i++)
    {
        int res = i * i;
        Console.Write($"{res}, ");
    }
    int res2 = num1 * num1;
    Console.WriteLine($"{res2}");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}




int number = Number();

Coub(number);

Lutsenko();

