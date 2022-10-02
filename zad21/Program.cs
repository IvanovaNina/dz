// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между неми в 3D пространстве
// Например, А (3,6,8); В (2,1,7) -> 15,84
Console.WriteLine("Введите коотринату x для первой точки: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коотринату y для первой точки: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коотринату z для первой точки: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коотринату x для второй точки: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коотринату y для второй точки: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коотринату z для второй точки: ");
int zb = Convert.ToInt32(Console.ReadLine());
double l = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));
Console.WriteLine($"Расстояние между точками равно {Math.Round(l,2)}");

