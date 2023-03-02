// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4








int number = Convert.ToInt32(Console.ReadLine());
table (number);

void table(int num)
{
        int index = 1;
    int result = 0;
    while(index <= num)
    {
        result = index*index; 
        Console.WriteLine($"{index,5}    {result,5}" );
        index++;
    }
}


