// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,10);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       Console.Write($" {collection[index]}");
        index++;
    }
    Console.WriteLine();
}
void SumUnevenPos(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int sum = 0;
    while (index < length)
    {
       if (index%2 == 1) sum= sum + collection[index];
        index++;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {sum}");
}
void SumUnevenPos1(int[] collection)
{
    int length = collection.Length;
    int sum = 0;
    for (int i = 1; i < length; i = i + 2) 
    {
        sum= sum + collection[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {sum}");
}
FillArray(array);
PrintArray(array);
SumUnevenPos(array);
SumUnevenPos1(array);