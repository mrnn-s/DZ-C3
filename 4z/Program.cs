// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result=1;
for(int i=1;i<=number;i++)
{
    result=i*i*i;
if(result%2==0)
    Console.WriteLine(result);

}
