// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputValue(string message)
{
    Console.WriteLine(message);
    string? n = Console.ReadLine();
    if ((int.TryParse(n, out int value)) == false)
    {
        Console.WriteLine("Вы ввели не число");
    }
    return value;
}
int AckermannRecurs(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannRecurs(m - 1, 1);
    }
    else return AckermannRecurs(m - 1, AckermannRecurs(m, n - 1));
}
int result = AckermannRecurs(InputValue("Задайте значение M:"), InputValue("Задайте значение N:"));
Console.Write($"Результат вычисления функции Аккермана = {result}");