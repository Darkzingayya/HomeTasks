Console.Clear();
Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ( a / 10 % 10); //Вывод второй цыфры в числе