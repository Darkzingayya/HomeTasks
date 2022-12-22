// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//НЕ ИСПОЛЬЗОВАТЬ MATH.POW
Console.Clear();
Console.Write("Введите число: ");
int m = 1, a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
   m = m * a;
}
Console.WriteLine(m);