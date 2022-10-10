// Написать программу вычисления произведения чисел от 1 до N

Console.Write("enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int result=1;
for (int i=1;i<=number;i++)
{
   result=result*i;
   Console.WriteLine(result);
}




// Console.Write("Vvedite числo:");
// int Chislo = int.Parse(Console.ReadLine() ?? "0");
// int sch = 1;
// for (int i=1; i<=Chislo;i++)
// {
// sch = sch * i;
// Console.WriteLine(sch);
// }