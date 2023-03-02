// . Напишите программу, которая будет
//  принимать на вход два числа и выводить, является ли первое число
// кратным второму.
// Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine($"Введите певое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());


int result = number % number2;

if (result == 0) Console.WriteLine($"{number}, {number2} -> кратно "); 
else Console.WriteLine($"{number}, {number2} -> не кратно, остаток {result} ");










