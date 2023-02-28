// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (number==1)Console.Write("между 0 и 1 нет честных чисел");
else if (number % 2 == 0)
{
    while(number > sum)
    {
        
            sum = sum + 2;
            Console.Write($"{sum}, ");
    }
}
else
{
    number=number -1;
while(number > sum)
    {
        
            sum = sum + 2;
            Console.Write($"{sum}, ");
    }
}