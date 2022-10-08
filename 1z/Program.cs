// Найти кубы чисел от 1 до N
Console.Write("enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
int res=0;
while (count <= number)
{
    //*res = Math.Pow(count, 3);
    res = count*count*count;
    Console.WriteLine($"{count}^3={res}");
    count++;
}