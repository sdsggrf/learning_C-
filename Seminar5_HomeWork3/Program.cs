// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
int siz = 4;
double[] ar = new double[siz];
int ind = 0;
int min = 0;
int max = 0;
Array(siz, ar, ind);
Search_Max_Min(siz, ar, ind, min, max);
Write(siz, ar, ind);
Console.WriteLine(Search_Max_Min(siz, ar, ind, min, max));

void Array(double size, double[] arr, int index)
{
    
    while (index < size)
    {
        arr[index] = Math.Round(new Random().NextDouble() * 100, 1, MidpointRounding.ToZero);
        index++;

    }
    
}
void Write(int size, double[] arr, int index){
index = 0;
Console.Write("[");
while (index < size) // for (int i = 0; i < count; i++) можно через это, в данном коде не работает
{

    Console.Write(arr[index]);
    index++;
    if(index<size) Console.Write(". ");

}
Console.Write("]");
Console.Write(" -> ");
}
double Search_Max_Min(int size, double[] arr, int index, int minPos, int maxPos)
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
    
    double result= Math.Round(arr[maxPos]-arr[minPos], 1, MidpointRounding.ToZero);
    return result;
}
