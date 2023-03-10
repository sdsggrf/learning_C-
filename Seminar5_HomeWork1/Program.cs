// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int siz = 8;
int[] ar = new int[siz];
int ind = 0;
Mass(siz, ar, ind);
Сheiny(siz, ar, ind);
Write(siz, ar, ind);
Console.Write(Сheiny(siz, ar, ind));
void Mass(int size, int[]arr, int index){
while (index < size)
{
    arr[index] = new Random().Next(100, 1000);
    index++;

}
}
void Write(int size, int[] arr, int index){
index = 0;
Console.Write("[");
while (index < size) // for (int i = 0; i < count; i++) можно через это, в данном коде не работает
{

    Console.Write(arr[index]);
    index++;
    if(index<size) Console.Write(", ");

}
Console.Write("]");
Console.Write(" -> ");
}
int Сheiny(int size, int[] arr, int index){
index = 0;
int composition=0;
while (index < size) 
{
 if(arr[index]%2==0)composition++;
    index++;

}
return composition;
}