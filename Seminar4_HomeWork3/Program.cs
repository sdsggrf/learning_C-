//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]




int siz = 8;
int[] ar = new int[siz];
int ind = 0;
mass(siz, ar, ind);
Write(siz, ar, ind);

void mass(int size, int[] arr, int index)
{
    while (index < size)
    {
        arr[index] = new Random().Next(1, 101);
        
        index++;

    }
}
void Write(int size, int[] arr, int index)
{
    int index1  = 0;
    int size2=2;
    while (index1 < size2)
    {
        if (index1 < 1)
        {
           int index2=0;
            while (index2 < size) // for (int i = 0; i < count; i++) можно через это, в данном коде не работает
            {

                Console.Write(arr[index]);
                index2++;
                index++;
                if (index < size) Console.Write(", ");

            }
            index=0;
        }
        else{
            Console.Write(" -> ");
            Console.Write("[");
            index=0;
            int index3=0;
            while (index3 < size) // while (index3 < size) // for (int i = 0; i < count; i++) можно через это, в данном коде не работает
            {

                Console.Write(arr[index]);
                index3++;
                index++;
                if (index < size) Console.Write(", ");

            }
            Console.Write("]");
        }
        index1++;
    }
}