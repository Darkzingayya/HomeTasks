Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0, i = Convert.ToString(n).Length;
while (i > 0)
{
   sum += n%10;
   n = n/10;
   i--;
   }
Console.WriteLine(sum);