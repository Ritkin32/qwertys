//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 22;
int b = 9;
int c = 3;

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write ("max =");
Console.WriteLine (max);