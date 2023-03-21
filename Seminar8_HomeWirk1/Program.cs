// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Main();

void Main()
{
    int m = 3;
    int n = 4;
    int[,] arr = GenerateRandomArray(m, n);
    PrintArray(arr);
    ArraySorting(arr);
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
void ArraySorting(int[,] arr2)
{

    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int k = 0; k < arr2.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < arr2.GetLength(1) - 1; j++)
            {
                int temp = 0;
                if (arr2[i, j] < arr2[i, j + 1])
                {
                    temp = arr2[i, j];
                    arr2[i, j] = arr2[i, j + 1];
                    arr2[i, j + 1] = temp;
                }
            }
        }
    }
    PrintArray2(arr2);
}
void PrintArray2(int[,] arr)
{
    Console.WriteLine();
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
