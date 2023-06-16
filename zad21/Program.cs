// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите ТРИ координаты точки А через пробел");
int[] tA = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Введите ТРИ координаты точки Б через пробел");
int[] tB = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

double R = Math.Round(Math.Sqrt(Math.Pow( (tB[0] - tA[0]) , 2) + Math.Pow( (tB[1] - tA[1]) , 2) + Math.Pow( (tB[2] - tA[2]) , 2)), 2);   

System.Console.WriteLine($"РАсстояние между точкой А({tA[0]},{tA[1]},{tA[2]}) и точкой Б({tB[0]},{tB[1]},{tB[2]}) -> {R}");     

