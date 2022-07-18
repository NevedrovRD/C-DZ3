//Доп. задача

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max1 = 0;
while (n != 0)
{
    if (n > max)
    {
        max1 = max;
        max = n;
    }
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
}



Console.WriteLine(max1);

