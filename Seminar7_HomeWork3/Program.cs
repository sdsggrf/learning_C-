// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Main();

void Main()
{
    int m = 3;
    int n = 4;
    double[,] arr = GenerateRandomArray(m, n);
    double[] arr2 = GetColumnAverages(arr);
    PrintArray(arr);
    PrintArray2(arr2, n);

}

double[,] GenerateRandomArray(int m, int n)
{
    double[,] arr = new double[m, n]; // создаем двумерный массив размером m x n
    Random rand = new Random(); // создаем генератор случайных чисел
    for (int i = 0; i < m; i++) // заполняем массив случайными вещественными числами
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(1, 11); // генерируем случайное вещественное число от -10 до 10
        }
    }
    return arr;
}
void PrintArray(double[,] arr)
{
    int m = arr.GetLength(0); // получаем количество строк массива || `arr.GetLength(0 или 1)` - это метод, который возвращает размерность массива `arr` по указанному индексу. 

    int n = arr.GetLength(1); // получаем количество столбцов массива
    for (int i = 0; i < m; i++)//Повторяет по индексу количества строк
    {
        for (int j = 0; j < n; j++) //Повторяет по индексу количества столбцов
        {
            Console.Write($"{arr[i, j],5}   ");// выводим элемент массива с одним знаком после запятой 
        }
        Console.WriteLine();
    }


}
double[] GetColumnAverages(double[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    double[] averageValues = new double[cols];

    for (int j = 0; j < cols; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        averageValues[j] = (double)sum / rows;
    }

    return averageValues;
}
void PrintArray2(double[] arr2, int n)
{
    Console.WriteLine();
    for (int i = 0; i < n; i++)
    {

        Console.Write($"{Math.Round(arr2[i], 1),5}   ");
    }
}