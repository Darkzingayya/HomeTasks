Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32 (Console.ReadLine());

int result = a;
   if(b> result) result = b;
   if(c> result) result = c;
Console.WriteLine(); // Просто чтобы отделить ответ от введённых чисел
Console.Write("Максимальное число: " + result);