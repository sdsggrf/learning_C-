// Задача 21 (branch task_2)
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Вариант решения с измененным кодом с семинара


Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPointB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPointB = Convert.ToInt32(Console.ReadLine());


double distance = Distance(xPointA, yPointA, xPointB, yPointB, zPointA, zPointB);
Console.WriteLine($"Расстояние между точками равно: {distance}");

double Distance(int xA, int yA, int xB, int yB, int zA, int zB)
{
int A = xA-xB;
int B = yA-yB;
int C = zA-zB;



    return Math.Sqrt(A*A+B*B+C*C);
}