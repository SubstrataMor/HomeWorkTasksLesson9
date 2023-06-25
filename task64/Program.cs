// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputValue()
{
    Console.WriteLine("Задайте значение N: ");
    string? n = Console.ReadLine();
    if ((int.TryParse(n, out int value)) == false)
        {
            Console.WriteLine("Вы ввели не число");
        }
    return value;
}
void RecursN(int n)
{
    if (n > 0)
    {
        Console.Write($"{n}, ");
        RecursN(n-1);
    }
}
RecursN(InputValue());