// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int Sum(int n)
{
    if (n == 0) return 0;
    return Sum(n/10) + n%10;
}

Console.Clear();
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Sum(n)}");