// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
if (size > 0)
{
    Array(size, arr);
    Write(size, arr);
    Main(size, arr);
}
else Console.Write("Количество чисел должно быть > ");

Console.WriteLine(Main(size, arr));
void Array(int siz, int[] ar)
{
    for (int i = 0; i < siz; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        ar[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void Write(int siz, int[] ar)
{
    for (int i = 0; i < siz; i++)
    {
        Console.Write(arr[i]);
        if (i < siz - 1) Console.Write(". ");
    }
    Console.Write(" -> ");
}
int Main(int siz, int[] ar)
{
    int count = 0;
    for (int i = 0; i < siz; i++)
    {
        if (ar[i] > 0)
        {
            count++;
        }
    }
    return count;
}