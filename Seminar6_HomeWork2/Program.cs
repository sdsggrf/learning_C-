// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int size = 4;
double[] arr = new double[size];
int num=1;
Array(size, arr);
CheckingArrayElements(arr,num);
if(CheckingArrayElements(arr,num)>1)Console.WriteLine("Прямые парралельны");
else
Main (arr);

void Array(int siz, double[] ar)
{
    for (int i = 0; i < siz; i++)
    {
        if(i==0) Console.Write($"Введите число : b1 ");
        else if(i==1)Console.Write($"Введите число : k1 ");
        else if(i==2)Console.Write($"Введите число : b2 ");
        else if(i==3)Console.Write($"Введите число : k2 ");
        ar[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int CheckingArrayElements(double[]ar,int n)
{
if(ar[1]==ar[3])n++;
return n;
}

void Main(double[]ar)
{
  
    double x = (ar[2] - ar[0]) / (ar[1] - ar[3]);
    double y = ar[1] * x + ar[0];

    Console.WriteLine("Точка пересечения двух прямых: ({0}; {1})", x, y);
}
