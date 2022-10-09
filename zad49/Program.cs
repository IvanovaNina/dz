// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
} }
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
}
}
int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("Введите строку ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колонку ");
int col = Convert.ToInt32(Console.ReadLine());

if ((row>=0 && row<matrix.GetLength(0))&& (col>=0 && col<matrix.GetLength(1))) 
{
    Console.WriteLine($"Элемент на заданной позиции имеет значение {matrix[row,col]}");
}
else
{
    Console.WriteLine("Такого элемента нет в заданном массиве ");
}