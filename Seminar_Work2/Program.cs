Console.Write("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 == MathF.Sqrt(number)) Console.Write("да");
else if (number2 != MathF.Sqrt(number)) Console.Write("нет");
