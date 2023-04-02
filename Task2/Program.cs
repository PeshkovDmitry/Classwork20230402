// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.

void Print(int m, int n)
{
    if (n == m) Console.Write($"{m}, ");
    else 
    {
        Print(m, n-1);
        Console.Write($"{n}, ");
    }
}

Console.Clear();
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Print(m,n);

// Console.Clear();

// string OutPutNumber(int Number1, int Number2)
// {
//     if (Number1 == Number2)
//         return Number1.ToString();
//     return OutPutNumber(Number1, Number2 - 1) + ", " + Number2.ToString();
// }

// Console.Write("Введите 2 числа : ");
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.Write(OutPutNumber(numbers[0], numbers[1]));