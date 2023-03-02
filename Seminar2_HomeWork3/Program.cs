// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет





int number = Convert.ToInt32(Console.ReadLine());


if (number>7)Console.WriteLine("Не являеться днем недели");
else if (number < 1)Console.WriteLine("Не являеться днем недели");
else if (number>5)Console.WriteLine("наконец-то выходной");
else Console.WriteLine("Ещё работать и работать");