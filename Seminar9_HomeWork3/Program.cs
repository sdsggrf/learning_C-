








// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.



Main();


void Main()
{
    Console.Write("Первое число : ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Второе число : ");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = Ackermann(m, n);
    Console.WriteLine($"A({m},{n})={result}");
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

