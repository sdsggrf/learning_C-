// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




Console.WriteLine($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Summa(number);
Console.WriteLine(Summa(number));
int Summa(int i)
{
    int res = 0;
    while (i != 0)
    {
        int remaind;
        i = Math.DivRem(i, 10, out remaind);
        res = res + remaind;
       
    }
    return res;
    
}
