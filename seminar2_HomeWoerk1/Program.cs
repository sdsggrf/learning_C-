// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число");

int number =Convert.ToInt32(Console.ReadLine());

if(number>1000) Console.WriteLine("введите число в промежутке от 100 до 999");

else if (number>100)
{
 int result=number%100/10;
 Console.WriteLine(result);

}

else Console.WriteLine("введите число в промежутке от 100 до 999");