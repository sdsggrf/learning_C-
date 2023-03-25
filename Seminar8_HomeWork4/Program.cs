// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


Main();
void Main()
{
    int[,,] arr = CreateArray();
    PrintArray(arr);
}

int[,,] CreateArray()
{
    int[,,] arr = new int[2, 2, 2];

    int num = 10;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                arr[i, j, k] = num++;
            }
        }
    }

    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine($"[{i},{j},{k}] = {arr[i, j, k]}");
            }
        }
    }
}

