// Написать программу, которая на вход принимает 2 числа и выдает какое число больше, а какое меньше

Console.WriteLine("Введите число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > num1)
{
    Console.WriteLine ($"Наибольшее число - {num2}, наименьшее число- {num1}");
}
else
{
    Console.WriteLine ($"Наибольшее число - {num1}, наименьшее число- {num2}");
}
