// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear ();


Console.Write ("Введите первое число: ");
int num1 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите второе число: ");
int num2 = Convert.ToInt32 (Console.ReadLine ());

Console.Write ("Введите третье число: ");
int num3 = Convert.ToInt32 (Console.ReadLine ());

int numMax = num1;

if (num2 > numMax)
{
    numMax = num2;
}

if (num3 > numMax)
{
    numMax = num3;  
}

Console.WriteLine ("max = " + numMax);
