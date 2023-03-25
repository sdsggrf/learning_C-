// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.





Main();
void Main()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    int sum = SumNumbers(m, n); // вызов рекурсивного метода
    Console.WriteLine($"Сумма чисел в промежутке от {m} до {n} равна {sum}");
}

int SumNumbers(int m, int n)
{
    if (m > n) // базовый случай: если m больше n, возвращаем 0
    {
        return 0;
    }
    else // рекурсивный случай: суммируем m и вызываем метод с аргументами m+1 и n
    {
        return m + SumNumbers(m + 1, n);
    }
}
