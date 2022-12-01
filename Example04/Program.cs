/*
Задача 22: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
int[] array =

5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/
Console.Clear();

Console.WriteLine("Введите число");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

int[] squaresTable = GetNumberSquareTable(num);

PrintArray(squaresTable);

int[] GetNumberSquareTable(int N) // Заполнение массива
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = (int)(Math.Pow(i+1, 2)); //(int) переделываем double после Pow в int
    }

    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}