//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]




int siz = 8;
int[] ar = new int[siz];
int ind = 0;
mass(siz, ar, ind);
Write(siz, ar, ind);

void mass(int size, int[]arr, int index){
while (index < size)
{
    arr[index] = new Random().Next(1, 101);
    Console.Write(arr[index]);
    index++;
    if(index<size) Console.Write(",");

}
}
void Write(int size, int[] arr, int index){
Console.Write(" -> ");
index = 0;
Console.Write("[");
for (index = 0; index < size; index++) // тоже самое что и "index++"
{

    Console.Write(arr[index]);
    index++;
    if(index<size) Console.Write(",");

}
Console.Write("]");
}