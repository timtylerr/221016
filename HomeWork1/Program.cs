﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Clear ();

Console.Write ("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine ());

if (num1 < num2)
{
    Console.WriteLine ("max = " + num2 + ", min = " + num1);
}
else if    (num1 == num2)
{
    Console.WriteLine ("Эти числа равны!");
}
else
{
    Console.WriteLine ("max = " + num1 + ", min = " + num2);
}
