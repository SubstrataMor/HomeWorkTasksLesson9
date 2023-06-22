// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
int RecursMtoN(int m, int n)
{
    if (m <= n)
    {
        return m + RecursMtoN(m + 1, n);
    }
    else return 0;
    
}
int result = RecursMtoN(InputValue("Задайте значение M:"), InputValue("Задайте значение N:"));
Console.Write($"Cумма натуральных элементов в промежутке от M до N = {result}");