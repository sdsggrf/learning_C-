// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


Main();

void Main()
{
    int m = 3;
    int n = 4;
    int[,] arr = GenerateRandomArray(m, n);
    PrintArray(arr);
    GetArrayElement(arr);
}

int[,] GenerateRandomArray(int m, int n)
{
    int[,] arr = new int[m, n]; // создаем двумерный массив размером m x n
    Random rand = new Random(); // создаем генератор случайных чисел
    for (int i = 0; i < m; i++) // заполняем массив случайными вещественными числами
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(1, 10) ; // генерируем случайное вещественное число от -10 до 10
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    int m = arr.GetLength(0); // получаем количество строк массива || `arr.GetLength(0 или 1)` - это метод, который возвращает размерность массива `arr` по указанному индексу. 

    int n = arr.GetLength(1); // получаем количество столбцов массива
    for (int i = 0; i < m; i++)//Повторяет по индексу количества строк
    {
        for (int j = 0; j < n; j++) //Повторяет по индексу количества столбцов
        {
            Console.Write(arr[i, j] + " ");// выводим элемент массива с одним знаком после запятой 
        }
        Console.WriteLine();
    }
}
void GetArrayElement(int[,] array)
{
    Console.Write("Индекс Строки : ");
    int row_idx = Convert.ToInt32(Console.ReadLine())-1;
    Console.Write("Индекс столбцa : ");
    int col_idx = Convert.ToInt32(Console.ReadLine())-1;
    if(row_idx < 0 || row_idx >= array.GetLength(0) || col_idx < 0 || col_idx >= array.GetLength(1))
    {
        Console.Write("-> такого элемента в массиве нет") ;
    }
    else
    {
        Console.WriteLine("-> "+array[row_idx, col_idx]);
    }
}