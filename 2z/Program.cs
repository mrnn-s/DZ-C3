// Подсчитать сумму цифр в числе
Console.Write("enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
int result=0;
int index=0;
// if(number<=0)
// {
//    result = number%10;
//     sum = sum + result;
//     number = number/10; 
// }
if (number<0)
    number=number*(-1);
while (number>0)
{
    result = number%10;
    sum = sum + result;
    number = number/10;
    index++;
}
Console.WriteLine($"сумма чисел {sum}");