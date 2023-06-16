// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// заполняем массив при помощи строки, разделяя значения разделителем, в конце - в какой тип переводит
// int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(", "), int.Parse); //Заполняем массив при помощи строки
// System.Console.WriteLine(string.Join(" | ", numbers)); // Вывод массива через string.Join

// System.Console.WriteLine("Введите координаты точки А через пробел");
// int[] tA = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine("Введите координаты точки Б через пробел");
// int[] tB = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// double D = Math.Pow( (tB[0] - tA[0]) , 2) + Math.Pow( (tB[1] - tA[1]) , 2);

// double R = Math.Round(Math.Sqrt(D), 2);   
// // но лучше приводить к Int - меньше памяти
// System.Console.WriteLine(R);     

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
// int i=1;
// while(i <= number) 
// {
//     System.Console.Write(Math.Pow(i,2) + " ");
//     i++;
// }

for(int i = 1; i <= number; i++)
{
    System.Console.Write(Math.Pow(i,2) + " ");
}