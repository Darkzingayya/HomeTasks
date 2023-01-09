// 66 Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.


int Summ(int n, int m, int sum)
{
   sum += n;
   if (n == m)
      return sum;
   return Summ ( n + 1, m, sum);
}

Console.Clear();
int sum = 0;
Console.WriteLine("Введите начало интервала: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец интервала: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n < m && 0 <n)
Console.WriteLine(Summ(n, m, sum));
else
Console.WriteLine("Не корректный ввод!");