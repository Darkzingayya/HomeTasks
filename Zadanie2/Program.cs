Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(); // Просто чтобы отделить ответ от введённых чисел

if(a == b) 
   {Console.WriteLine("Числа равны!");}
else{
  if(a > b) 
    {
    Console.WriteLine("Первое число " + a + " больше второго " + b);
    }  
  else 
   {
   Console.WriteLine("Второе число " + b + " больше первого " + a);
    }
      }
