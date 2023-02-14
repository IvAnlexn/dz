Console.WriteLine("Введите три целых числа через пробел: "); 
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

int x1 = int.Parse(splitString[0]);
int x2 = int.Parse(splitString[1]);
int x3 = int.Parse(splitString[2]);
    
if (x1 > x2)
{
    if (x1>x3)
    {
        Console.WriteLine(x1);
    }
}
if (x2>x1)
{
    if (x2>x3)
    {
        Console.WriteLine(x2);
    }
}
if (x3>x1)
{
    if (x3>x2)
    {
        Console.WriteLine(x3);
    }
}