// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Main();
void Main()
{
    int[,] arr = new int[4, 4]; // Создание массива размером 4 на 4
    FillArray(arr);
    PrintArray(arr);
}

void FillArray(int[,] arr)
{
    int num = 1; // начальное число, которое будет заполнять массив
    int n = 4; // количество элементов в каждой строке/столбце
    int row = 0, col = 0; // начальные координаты

    while (num <= n * n)
    {
        // Заполнение строки слева направо
        for (int i = col; i < n - col; i++)
        {
            arr[row, i] = num++;
        }

        // Заполнение столбца сверху вниз
        for (int i = row + 1; i < n - row; i++)
        {
            arr[i, n - col - 1] = num++;
        }

        // Заполнение строки справа налево
        for (int i = n - col - 2; i >= col; i--)
        {
            arr[n - row - 1, i] = num++;
        }

        // Заполнение столбца снизу вверх
        for (int i = n - row - 2; i > row; i--)
        {
            arr[i, col] = num++;
        }

        // Переход на следующую "оболочку"
        row++;
        col++;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],-4}");
        }
        Console.WriteLine();
    }
}
// Метод `FillArrayFillArray() заполняет массив arr числами по спирали, начиная с числа 1 и заканn*n, где `n - размер

// Метод PrintArray() выводит массив `arrarr построчно.

// В методе `Main() создаFillArray(), затем выводится с помощью метода PrintArray().