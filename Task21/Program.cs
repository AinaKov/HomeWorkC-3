/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Write("Введите координату Х первого числа: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первого числа: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первого числа: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х второго числа: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второго числа: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второго числа: ");
int z2 = Convert.ToInt32(Console.ReadLine());
int x = x1-x2;
int y = y1-y2;
int z = z1-z2;
double xy = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
double xyz = Math.Sqrt(Math.Pow(xy,2)+Math.Pow(z,2));
//double xyz = (Math.Round(xyz),2); не удается округлить, не понимаю в чем ошибка
Console.WriteLine(xyz);