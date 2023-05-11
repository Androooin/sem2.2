/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/


int Number()
{
    Console.WriteLine("Write five-digit number");
    int a = Convert.ToInt16(Console.ReadLine());
    return a;
}

void Palindrome(int num1)
{
if (num1 > 9999 && num1 < 100000)
{
    int nu1 = num1 / 10000;
    int nu2 = num1 / 1000 % 10;
    int nu4 = num1 / 10 % 10;
    int nu5 = num1 % 10;
    if (nu1 == nu5 && nu2 == nu4) Console.WriteLine("This number is palindrome");
    else Console.WriteLine("This number isn`t palindrome");
}
else Console.WriteLine("This number isn`t five-digit. Try again");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}




int number = Number();

Palindrome(number);

Lutsenko();
