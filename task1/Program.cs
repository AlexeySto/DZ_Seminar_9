// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5,4,3,2,1"
// N = 8 -> "8,7,6,5,4,3,2,1"

int n = GetNum("Введите число N = ");
if (n > 0)
{
    Console.Write($"N = {n} -> " + '"');
    FillNumbers(n);
    Console.Write("\b" + '"');
}
else Console.WriteLine("N должно быть больше 0.");

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FillNumbers(int n)
{
    if (n > 0)
    {
        Console.Write($"{n},");
        FillNumbers(n - 1);
    }
}