Console.WriteLine("Введите два целых числа через пробел: "); 
string line = Console.ReadLine();
string[] splitString = line.Split(' ');

int x1 = int.Parse(splitString[0]);
int x2 = int.Parse(splitString[1]);
    
if (x1 > x2)
{
    Console.WriteLine(x1);
}
else
{
    Console.WriteLine(x2);
}