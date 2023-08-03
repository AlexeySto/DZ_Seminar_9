// Задайте значения N и M. Напишите программу, которая найдет 
// сумму всех натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int m = GetNum("Введите число M = ");
int n = GetNum("Введите число N = ");
if (n > 0 && m > 0 && m <= n)
{
    Console.Write($"M = {m}; N = {n} -> {GetSum(m, n)}");
    
}
else Console.WriteLine("Введены некорректные значения.");

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int GetSum(int m, int n)
{
    if (m < n) return m + GetSum(m + 1, n);
    return n;

}