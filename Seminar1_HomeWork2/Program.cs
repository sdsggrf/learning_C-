// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("введите 3 числa");
int size = 3;
int[] arr = new int[size];
int index;

index = 0;
int maxPos;
maxPos = 0;
index = 0;
while (index < size)
{
    arr[index] = Convert.ToInt32(Console.ReadLine());


    if (arr[maxPos] < arr[index])
    {
             
   
        maxPos = index;
    }

    index = index + 1;
    
}
Console.WriteLine("Максимальное число: " + arr[maxPos]);

