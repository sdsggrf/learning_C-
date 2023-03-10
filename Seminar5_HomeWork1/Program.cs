// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int siz = 8;
int[] ar = new int[siz];
int ind = 0;
mass(siz, ar, ind);
Сheiny(siz, ar, ind);

void mass(int size, int[]arr, int index){
    Console.Write("[");
while (index < size)
{
    arr[index] = new Random().Next(1, 101);
    Console.Write(arr[index]);
    index++;
    if(index<size) Console.Write(",");

}
Console.Write("]");
}
void Сheiny(int size, int[] arr, int index){
Console.Write(" -> ");
index = 0;
int composition=0;
while (index < size) 
{
 if(arr[index]%2==0)composition++;
    index++;

}
Console.Write(composition);
}