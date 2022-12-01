/*
Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
Console.Clear();

Console.WriteLine("Введите номер четверти");

bool isParsed = int.TryParse(Console.ReadLine(), out int quarterNumber);

if (!isParsed)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

string quarterRange = GetQuarterCoordRange(quarterNumber);

if (quarterRange == "-1")
{
    Console.WriteLine("Введен неправильный номер четверти");
    return;
}

Console.WriteLine (quarterRange);

string GetQuarterCoordRange(int num)
{
    if (num == 1)
    {
        return ("x > 0 && y > 0");
    }

    if (num == 2)
    {
        return ("x < 0 && y > 0");
    }

    if (num == 3)
    {
        return ("x < 0 && y < 0");
    }

    if (num == 4)
    {
        return ("x > 0 && y < 0");
    }

    return "-1";
}