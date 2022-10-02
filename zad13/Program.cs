// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");

int x = Convert.ToInt32(Console.ReadLine());

if (x < 100)
{
    Console.WriteLine("Здесь нет третьей цифры");
}
else if (x>=100 && x<= 999)
{
    int y = x%10;
    Console.WriteLine($"Третья цифра {y}");
}
else if (x>999)
{
    while (x>1000)
    {
        x= x/10;
    }
    int z = x%10;

    Console.WriteLine($"Третья цифрa {z}");
}
