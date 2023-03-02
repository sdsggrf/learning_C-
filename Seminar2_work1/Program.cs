// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int result = RemoveSecondТumber(number);
Console.WriteLine(result);

int RemoveSecondТumber(int num)
{
    int secondNumber = num / 100;
    int firstNumber = num % 100 % 10;
    int answer = (secondNumber * 10) + firstNumber;
    return answer;
}
