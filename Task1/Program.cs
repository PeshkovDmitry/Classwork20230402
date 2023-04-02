// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void Print(int n)
{
    if (n == 1) Console.Write($"{1}, ");
    else 
    {
        Print(n-1);
        Console.Write($"{n}, ");
    }
}

Console.Clear();
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
Print(n);
