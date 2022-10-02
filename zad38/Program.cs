// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
void DiffMinMax(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int min = collection[0];
    int max = collection[0];
    while (index < length)
    {
       if (collection[index] < min) min = collection[index];
       if (collection[index] > max) max = collection[index];
        index++;
    }
    Console.WriteLine($"Разница между максимальным({max}) и минимальным({min}) элементов массива - {max - min}");
}
FillArray(array);
PrintArray(array);
DiffMinMax(array);

