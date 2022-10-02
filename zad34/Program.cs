// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] array = new int [8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100,999);
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
void CountEven(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int count = 0;
    while (index < length)
    {
       if (collection[index]%2 == 0) count++;
        index++;
    }
    Console.WriteLine($"Количетво чётных чисел в массиве - {count}");
}
FillArray(array);
PrintArray(array);
CountEven(array);
