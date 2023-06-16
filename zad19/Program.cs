// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Введите пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10000 || N > 99999)
{
    System.Console.WriteLine("Это не пятизначное число !");
}
else
{
    string str = Convert.ToString(N); 
    if(str[0]==str[4] && str[1] == str[3])
    {
        System.Console.WriteLine("      -> Да, это - палиндром");
    }
    else
    {
        System.Console.WriteLine("      -> Нет, это не палиндром");
    }
}
