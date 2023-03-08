// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число");
double x = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите степень");
double y = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Ответ " + Pow (x, y));

double Pow (double x1, double y2)
 {
    double pow_ab = Math.Pow(x1, y2);
    return pow_ab;
 }
 