// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Main();
void Main()
{
    int m = 4;
    int n = 4;
    int[,] arr = GenerateRandomArray(m, n);
    int[] arr2 = AdditionLineArray(arr);
    PrintArray(arr);
    PrintMaxLine(arr2, m);
}
int[,] GenerateRandomArray(int m, int n)
{
    int[,] arr = new int[m, n]; // создаем двумерный массив размером m x n
    Random rand = new Random(); // создаем генератор случайных чисел
    for (int i = 0; i < m; i++) // заполняем массив случайными вещественными числами
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(-10, 11); // генерируем случайное вещественное число от -10 до 10
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
    Console.WriteLine();
}
int[] AdditionLineArray(int[,] arr2)
{
    int siz = arr2.GetLength(0);

    int[] arr = new int[siz];



    for (int k = 0; k < arr2.GetLength(0); k++)
    {
        int sum = 0;
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            sum = sum + arr2[k, j];
        }
        arr[k] = sum;
    }


    return arr;
}
void PrintMaxLine(int[] arr, int m)
{

    int minPos = 0;

    for (int j = 0; j < m; j++)
    {

        if (arr[minPos] > arr[j])
        {
            minPos = j;
        }

    }
    Console.WriteLine(minPos + 1 + " Наименьшая сумма");
}
