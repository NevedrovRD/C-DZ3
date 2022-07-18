//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите точку x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку z1");
int z1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите точку x2");
int x2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите точку y2");
int y2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите точку z2");
int z2 = Convert.ToInt32(Console.ReadLine()); 

double distance = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1)));

Console.WriteLine("Расстояние между точками равно " + distance);