// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэффициент b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2: ");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2: ");
double k2=Convert.ToDouble(Console.ReadLine());



void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double xIntersection = 0;
    double yIntersection = 0;
    if(k1 == k2)
    {
        Console.Write("Прямые параллельны друг другу");
    }
    else if(k1 == k2 && b1 == b2)
    {
        Console.Write("Прямые совпадают");
    }
    else
    {
        xIntersection =(b2-b1)/(k1-k2);
        yIntersection =k1*xIntersection+b1;
        Console.WriteLine("Точка пересечения "+" ("+ xIntersection+" ;"+yIntersection+ ")");
    }
}

IntersectionPoint(b1, k1, b2, k2);