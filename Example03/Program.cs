/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();

Console.WriteLine("Введите координаты первой точки");

bool isParsedXa = int.TryParse(Console.ReadLine(), out int xa);
bool isParsedYa = int.TryParse(Console.ReadLine(), out int ya);

Console.WriteLine("Введите координаты второй точки");

bool isParsedXb = int.TryParse(Console.ReadLine(), out int xb);
bool isParsedYb = int.TryParse(Console.ReadLine(), out int yb);

if (!isParsedXa || !isParsedXb || !isParsedYa || !isParsedYb)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

double sigmentLength = DistanceBetweenPoints(xa, ya, xb, yb);

/*if (sigmentLength == -1)
{
    Console.WriteLine("Введены не корректные данные опа опа");
    return;
}
*/
Console.WriteLine($"Длина отрезка = {sigmentLength}");

double DistanceBetweenPoints(int xa, int ya, int xb, int yb)
{
    double segmentXab = xa - xb;
    double segmentYab = ya -yb;

    /*if (segmentXab < 0)
    {
        segmentXab = -segmentXab;
        return segmentXab;
    }

    if (segmentYab < 0)
    {
        segmentYab = -segmentYab;
        return segmentYab;
    }*/

    double AB = Math.Sqrt(segmentXab*segmentXab + segmentYab*segmentYab);

    return AB;
}