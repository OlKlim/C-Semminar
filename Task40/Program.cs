// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool Treyg(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}

Console.Write("Введите первую сторону : ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону : ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону : ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool res = Treyg(side1, side2, side3);
Console.WriteLine(res?"Треугольник существует":"Треугольник не существует");