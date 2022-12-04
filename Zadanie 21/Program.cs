//Поиск расстояния между точками по координатам в 3D
Console.Clear();
Console.Write("Введите координату Х1: ");
double x1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату Z1: ");
double z1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату Х2: ");
double x2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble (Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)));