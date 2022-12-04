//Вывести таблицу кубов от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());

for (int i = 1; i <= a; i++) 
    Console.WriteLine(Math.Pow(i,3));