// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int [] array = new int [8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,99);
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
FillArray(array);
PrintArray(array);

