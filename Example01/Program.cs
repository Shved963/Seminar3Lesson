//Напишите программу, которая принимает на вход координаты точки (X и Y)
//причем х != 0 и y != 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.Clear();

bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if (!isParsedX || !isParsedY)
{
    Console.WriteLine("Координаты введены не корректно");
    return;
}

int quarterNumber = GetQuarterNumberByCoord(x,y);

if (quarterNumber == -1)
{
    Console.WriteLine("Координаты введены не корректно");
    return;
}

Console.WriteLine(quarterNumber);

// возвращаемый_тип_данных НазваниеМетода()
//{
//     return 1; оператор return возвращает из метода значение и останавливает его.
//}

int GetQuarterNumberByCoord(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }

    if (x < 0 && y < 0)
    {
        return 3;
    }

    if (x > 0 && y < 0)
    {
        return 4;
    }

    return -1;
}