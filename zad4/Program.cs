// Напишите программу, которая на вход принимает 3 числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");

int num3 = Convert.ToInt32(Console.ReadLine());

if (num3 > num1 && num3 > num2)
{
    Console.WriteLine ($"Наибольшее число - {num3}");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine ($"Наибольшее число - {num2}");
}
else 
{
    Console.WriteLine ($"Наибольшее число - {num1}");
}