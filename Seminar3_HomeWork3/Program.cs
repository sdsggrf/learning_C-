// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number2=number;
Reverse(number);
number = Reverse(number);
int Reverse(int i)
{
    int res = 0;
    while (i != 0)
    {
        int remaind;
        i = Math.DivRem(i, 10, out remaind);
        res = res * 10 + remaind;
    }
    return res;
}
if(number==number2)Console.WriteLine($"{number2} являеться палиндромом");
else
Console.WriteLine($"{number2} не являеться палиндромом");