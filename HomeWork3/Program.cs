// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Clear ();

Console.Write ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine ());

int rest = num % 2;

if (rest == 0)
{
    Console.WriteLine ("Это четное число!");
}
else
{
    Console.WriteLine ("Это нечетное число!");
}
