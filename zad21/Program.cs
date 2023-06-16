// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
 int readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void checkquarter(int x, int y)
{
if(x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в 1-й четверти");
}
else if(x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится во 2-й четверти");
}
else if(x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится во 3-й четверти");
}
else if(x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находится во 4-й четверти");
}
else
{
    System.Console.WriteLine("Введены неправильные координаты");
}
}
// основной код
int[] coordinates = new int[2];

// System.Console.Write("Введите координату Х: ");
// coordinates[0] = Convert.ToInt32(Console.ReadLine());
coordinates[0] = readint("введите координату Х  "); // вместо верхнего кода - функция

// System.Console.Write("Введите координату Y: ");
// coordinates[1] = Convert.ToInt32(Console.ReadLine());
coordinates[1] = readint("ВВедите координату Y  ");

checkquarter(coordinates[0], coordinates[1]);

// if(coordinates[0] > 0 && coordinates[1] > 0)
// {
//     System.Console.WriteLine("Точка находится в 1-й четверти");
// }
// else if(coordinates[0] < 0 && coordinates[1] > 0)
// {
//     System.Console.WriteLine("Точка находится во 2-й четверти");
// }
// else if(coordinates[0] < 0 && coordinates[1] < 0)
// {
//     System.Console.WriteLine("Точка находится во 3-й четверти");
// }
// else if(coordinates[0] > 0 && coordinates[1] < 0)
// {
//     System.Console.WriteLine("Точка находится во 4-й четверти");
// }
// else
// {
//     System.Console.WriteLine("Введены неправильны координаты");
// }