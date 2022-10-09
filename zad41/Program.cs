// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Если с массивом, то так: 
//Console.WriteLine("Введите количество чисел, которое вы собираетесь ввести ");
// int M = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [M];
// Console.WriteLine("Введите числа ");

// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//      array [i] = Convert.ToInt32(Console.ReadLine());
//     if (array [i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество чисел больше нуля:  {count}");



Console.WriteLine("Введите количество чисел, которое вы собираетесь ввести ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите числа ");

int count = 0;

for (int i = 0; i < M; i++)
{
     int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше нуля:  {count}");
