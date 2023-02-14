// Console.WriteLine("Введите целое число: "); 
// int x = int.Parse(Console.ReadLine());
// int count = 1;

// while (x>=count)
// {
//     if (count%2==0)
//     {
//         Console.WriteLine(count);
//     }
//     count++;
// }
// Console.WriteLine("Введите трехзначное число: "); 
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(num/10%10);

// Console.WriteLine("Введите трехзначное число: "); 
// string num1 = Console.ReadLine();
// Console.WriteLine(num1[1]);

// Console.WriteLine("Введите число от 1 до 7: "); 
// int num = int.Parse(Console.ReadLine());
// if (num>7)
// {
//     Console.WriteLine("Вы ввели число больше 7...");
// }
// else
// {
//     Console.WriteLine("Является ли ваш день недели выходным?");
//     if (num == 6 || num == 7)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// Console.Write("Введите X1: ");
// double x1 = double.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// double y1 = double.Parse(Console.ReadLine());
// Console.Write("Введите Z1: ");
// double z1 = double.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// double x2 = double.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// double y2 = double.Parse(Console.ReadLine());
// Console.Write("Введите Z2: ");
// double z2 = double.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

// Console.WriteLine($"d={d:f2}");

// Console.WriteLine("Введите число: "); 
// int num = int.Parse(Console.ReadLine());
// int count = 1;

// {

// }
// Console.Write("Введите положительное число: ");
// int N = int.Parse(Console.ReadLine());
// int[] nums = new int[N+1];
// for (int i = 1; i<=N; i++)
// {
//     nums[i]=i*i*i;
// }
// Console.Write("Таблица кубов: "); 
// for (int i = 1; i<=N; i++)
// {
//     Console.Write($"{nums[i]} "); 
// }
 
// Console.WriteLine("Введите 5-ти значное число: ");
// string text = Console.ReadLine();
// char[] obrtext = text.ToCharArray();
// Array.Reverse(obrtext);
// string finaltext = new string(obrtext);
// if(text==finaltext)
// {
//     Console.WriteLine("Данная запись является палиндромом");
// }
// else
// {
//     Console.WriteLine("Данная запись не является палиндромом");
// }

// Console.WriteLine("Введите число: ");
// int z = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите степень числа: ");
// int x = int.Parse(Console.ReadLine());
// int c = z;
// for (int i = 1; i<x; i++)
// {
//     c *= z;
// }
// Console.WriteLine(c);

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int count = 0;
// while (num>0)
// {
//     count += num%10;
//     num /= 10;
// }
// Console.WriteLine(count);

// Console.WriteLine("Введите 8 чисел через пробел: ");
// string text = Console.ReadLine();
// string[ ] array = text.Split(" ");
// Console.WriteLine(array[0]);

// Random random = new Random();
// int randomNum = random.Next(1, 8);
// Console.WriteLine($"Введите массив состоящий из трехзначных {randomNum} чисел: ");
// int[] array = GetArray(randomNum);
// Console.WriteLine($"[{String.Join(", ", array)}]");


// int[] GetArray(int size){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++){
//         Console.WriteLine($"Введите {i+1} число: ");
//         result[i] = int.Parse(Console.ReadLine());
//     }
//     return result;
// }
// int count = 0;
// for (int i = 0; i < array.Length; i++){
//     if (array[i]%2==0){
//         count++;
//     }
// }
// Console.WriteLine($"В этом массиве {count} четных числа.");

Random random = new Random();
int randomNum = random.Next(3, 9);
Console.WriteLine($"Будет выведен массив из {randomNum} чисел: ");
int[] array = GetArray(randomNum);
Console.WriteLine($"[{String.Join(", ", array)}]");
if (array.Length%2==1){
    int[] array2 = GetArray2(array.Length/2+1);
    Console.WriteLine("Складываем начало с концом");
    Console.WriteLine($"[{String.Join(", ", array2)}]");
}
else{
    int[] array3 = GetArray3(array.Length/2);
    Console.WriteLine("Складываем начало с концом");
    Console.WriteLine($"[{String.Join(", ", array3)}]");
}
int[] GetArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = random.Next(0, 100);
    }
    return result;
}
int[] GetArray2(int size){
    int[] result = new int[size];
    for (int i = 0; i < size-1; i++){
        int max = array.Length-1;
        result[i] = array[i]+array[max-i];
    }
    result[size-1] = array[array.Length/2];
    return result;
}
int[] GetArray3(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        int max = array.Length-1;
        result[i] = array[i]+array[max-i];
    }
    return result;
}

// int count = 0;
// for (int i = 0; i < array.Length/2; i++){
//     if (array[i]<=99 && array[i]>=10){
//         count++;
//     }
// }
// Console.WriteLine($"Количество чисел в массиве в диапазоне [10, 99] = {count}.");

// Random random = new Random();
// int randomNum = random.Next(3, 9);
// Console.WriteLine($"Будет выведен массив из {randomNum} чисел: ");
// double[] array = GetArray(randomNum);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// double[] GetArray(int size){
//     double[] result = new double[size];
//     for (int i = 0; i < size; i++){
//         double minValue = 1.0;
//         double maxValue = 20.0;
//         double randomNumber = random.NextDouble() * (maxValue - minValue) + minValue;
//         result[i] = randomNumber;
//     }
//     return result;
// }
// Console.WriteLine($"Разница между максимальным и минимальным числом в массиве равна = {Math.Round((array.Max()-array.Min()), 2)}.");
