// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125







int number = Convert.ToInt32(Console.ReadLine());
table (number);

void table(int num)
{
        int index = 1;
    int result = 0;
    while(index <= num)
    {
        result = index*index*index; 
        Console.WriteLine($"{index,5}    {result,5}" );
        index++;
    }
}

