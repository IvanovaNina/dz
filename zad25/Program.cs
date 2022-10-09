// Напишите программу, которая принимает на вход два числа ( А и В) и возводит число А в натуральную степень числа В.
//Например, 2, 4 -> 16

Console.WriteLine("Введите число, которое вы хотите возвести в степень ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Теперь введите степень, в которую вы хотите возвести число {A} : ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < B; i++)
{
    result = result * A;
}
Console.WriteLine($"Число {A} в степени {B} равно {result}");
