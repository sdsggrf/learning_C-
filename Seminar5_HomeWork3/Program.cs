// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
int siz = 4;
double[] ar = new double[siz];
int ind = 0;
int min = 0;
int max = 0;
Mass(siz, ar, ind);
Search(siz, ar, ind, min, max);

void Mass(double size, double[] arr, int index)
{
    Console.Write("[");
    while (index < size)
    {
        arr[index] = Math.Round(new Random().NextDouble() * 100, 1, MidpointRounding.ToZero);
        Console.Write(arr[index]);
        index++;
        if (index < size) Console.Write(". ");

    }
    Console.Write("]");
}
void Search(int size, double[] arr, int index, int minPos, int maxPos)
{

    while (index < size)
    {
        if (arr[minPos] < arr[index])
        {
            if (arr[maxPos] < arr[index])
            {
                maxPos = index;
            }

        }
        else
        {
            minPos = index;
        }
        index++;
    }
    Console.Write(" -> ");
    Console.Write(Math.Round(arr[maxPos]-arr[minPos], 1, MidpointRounding.ToZero));
    
}
