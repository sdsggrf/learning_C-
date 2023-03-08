//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]




int size = 8;
int[] arr = new int[size];
int index = 0;




while (index < size)
{
    arr[index] = new Random().Next(1, 101);

    index = index + 1;

}
index = 0;
Console.Write("[");
while (index < size)
{

    Console.Write(arr[index]);
    index = index + 1;
    if(index<size) Console.Write(", ");

}
Console.Write("]");