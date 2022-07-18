//Доп. задача


Console.WriteLine("Введите число");
string n = Console.ReadLine();
int[] x = new int[n.Length];
for(int i = 0; i < n.Length; i++)
{
    x[i] = int.Parse(n[i].ToString());
}

int index = 0;
int find = 0;

while (x[index] != 0)
{
    index++;
}
find = index;

int[] y = new int[find];
for(int i = 0; i < find; i++)
{
    y[i] = int.Parse(x[i].ToString());
}

int index1 = 0;
int max = 0;
int max1 = 0;
while(index1 < y.Length)
{
    if(y[index1] > max)
    {
        max1 = max;
        max = y[index1];
    }
        
index1++;
}
    
Console.WriteLine(max1);

