// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// int readint(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void checkq(int x)
// {
// if(x == 1)
// {
//     System.Console.WriteLine("Координаты четверти: х > 0, y > 0");
// }
// else if(x == 2)
// {
//     System.Console.WriteLine("Координаты четверти: х > 0, y < 0");
// }
// else if(x ==3)
// {
//     System.Console.WriteLine("Координаты четверти: х < 0, y < 0");
// }
// else if(x == 4)
// {
//     System.Console.WriteLine("Координаты четверти: х > 0, y < 0");
// }
// else
// {
//     System.Console.WriteLine("нет такой четверти");
// }
// }

// int q = readint("Введите номер четверти");
// checkq(q);

// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
System.Console.Write("Введите номер четверти: ");
int qw = Convert.ToInt32(Console.ReadLine());
string[] message = { "x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0" };

if (qw > 0 && qw < 5)
{
    System.Console.WriteLine(message[qw - 1]);
}
else
{
    System.Console.WriteLine("Такой четверти не существует!");
}