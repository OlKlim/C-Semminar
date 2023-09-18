// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите день недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday == 1)
    Console.WriteLine($"{weekday} -> Понедельник");
else if (weekday == 2)
    Console.WriteLine($"{weekday} -> Вторник");
else if (weekday == 3)
    Console.WriteLine($"{weekday} -> Среда");
else if (weekday == 4)
    Console.WriteLine($"{weekday} -> Четверг");
else if (weekday == 5)
    Console.WriteLine($"{weekday} -> Пятница");
else if (weekday == 6)
    Console.WriteLine($"{weekday} -> Суббота");
else if (weekday == 7)
    Console.WriteLine($"{weekday} -> Воскресенье");
else
    Console.WriteLine("Некорректно набран день недели");