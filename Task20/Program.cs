//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние можду ними в 2D пространстве.
//A(3,6);B(2,1); -> 5,09
//A(7,-5);B(1,-1); -> 7,21

double FindDistance(int aX, int aY, int bX, int bY)
{
    double leg1 = aX - bX;
    double leg2 = aY - bY;
    return Math.Sqrt((leg1 * leg1) + (leg2 * leg2));
}

Console.WriteLine("Введите координаты для точки A");
Console.Write("x: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.Write("x: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yB = Convert.ToInt32(Console.ReadLine());

double c = FindDistance(xA, yA, xB, yB);
double cRound = Math.Round(c, 2, MidpointRounding.ToZero);
Console.WriteLine(cRound);