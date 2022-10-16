// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear ();

Console.Write ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine ());

int count = 2;

while (num < 0)
{
    Console.Write ("Нужно ввести положительное число: ");
    int num2 = Convert.ToInt32 (Console.ReadLine ());
    num = num2;
}

while (count <= num)
{
    int rest = count % 2;
    if (rest == 0)
    {
        Console.Write (count + ", ");
    }
    count++;
}

Console.WriteLine ("больше нет четных чисел");
