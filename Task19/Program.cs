// я так и не поняла: для чего мы пишем using System и class Program. У меня не работает с ними.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <0)
{
    number = number * -1;
}

if (number > 9999 & number < 100000)
{
    if (number.ToString()[0] == number.ToString()[4] & number.ToString()[1] == number.ToString()[3])
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}
else
{
    Console.WriteLine("Не пятизначное");
}
