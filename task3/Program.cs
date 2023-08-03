// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = GetNum("Введите число m = ");
int n = GetNum("Введите число n = ");
if (n > 0 && m > 0)
{
    Console.Write($"m = {m}, n = {n} -> A(m,n) = {GetAkkerman(m, n)}");
    
}
else Console.WriteLine("Введены некорректные значения.");

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int GetAkkerman(int m, int n)
{
    if (m > 0 && n == 0) return GetAkkerman(m - 1, 1); 
    else if (m == 0) return n + 1;
    else  return GetAkkerman(m - 1, GetAkkerman(m,n - 1));;
}