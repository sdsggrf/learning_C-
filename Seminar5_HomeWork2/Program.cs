// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0











int siz = 4;
int[] ar = new int[siz];
int ind = 0;
Mass(siz, ar, ind);
Сheiny(siz, ar, ind);
Write(siz, ar, ind);
Console.Write(Сheiny(siz, ar, ind));
void Mass(int size, int[] arr, int index)
{
    while (index < size)
    {
        arr[index] = new Random().Next(-20, 20);
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
int Сheiny(int size, int[] arr, int index)
{
    index = 0;
    int composition = 0;
    while (index < size)
    {
        if (index % 2 == 1)composition=composition + arr[index];//(index % 2 == 1) проверка на нечетность 
        
        index++;
        

    }
    return composition;
}