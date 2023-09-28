//Напишите программу, которая по заданному номеру четверти, показывает диапозон 
//возможных координат точек в этой четверти (x и y).

string GetCoordinatesRange(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

string getCoordinatesRange = GetCoordinatesRange(number);
string result = getCoordinatesRange != null ? $"Возможные координаты: {getCoordinatesRange}" : "Неверные данные";
Console.WriteLine(result);