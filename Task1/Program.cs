// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число");

int n = Convert.ToInt32(Console.ReadLine());

if (n > 10000 && n < 1000000)
{
    int n1 = (n/10000);
    int n2 = (n/1000%10);
    int n4 = (n/10%10);
    int n5 = (n%10);

    if (n1 == n5 && n2 == n4)
    {
        Console.WriteLine("Это число палиндром");
    }
    else Console.WriteLine("Это число НЕ палиндром");
}
else Console.WriteLine("НУЖНО ПЯТИЗНАЧНОЕ");
