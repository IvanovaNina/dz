// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//С помощью рекурсии.

// Например, 
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int m, int n)
{
    if (m <= n) return m + SumNumber(m + 1, n);
    else return 0;
}
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber(m, n);

Console.WriteLine($"Сумма элементов от {m} до {n} равна {sum}");
