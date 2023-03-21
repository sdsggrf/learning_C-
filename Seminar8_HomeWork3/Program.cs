// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Main();

void Main()
{
    Console.WriteLine("Задайте параметры Matrix 1");
    Console.WriteLine("Индекс строки");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Индекс стобца");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте параметры Matrix 2");
    Console.WriteLine("Индекс строки");
    int m2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Индекс стобца");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int sum = Examination2(m, n, m2, n2);
    Examination(sum,m, n, m2, n2);
}

void Examination(int sum,int m, int n, int m2, int n2)
{
    if (sum == 0)
    {
        int[,] matrix1 = GenerateRandomArray(m, n);
        int[,] matrix2 = GenerateRandomArray2(m2, n2);
        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);
        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);
        Console.WriteLine("Result Matrix:");
        PrintMatrix(resultMatrix);
    }
    else Console.WriteLine("Количество столбцов в первой матрице должно совпадать с количеством строк во второй матрице.");
}
int Examination2(int m, int n, int m2, int n2)
{
    int sum = 0;

    if (m != n2) sum++;
    return sum;
}
int[,] GenerateRandomArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(1, 11);
        }
    }
    return arr;

}
int[,] GenerateRandomArray2(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(1, 11);
        }
    }
    return arr;

}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, cols2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
