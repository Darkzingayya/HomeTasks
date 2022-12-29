// 41 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();
Console.Write("Введите количество чисел: ");
int a = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < a; i++ )
  {
      Console.WriteLine("Введите число: ");
      int b = Convert.ToInt32(Console.ReadLine());
      if (b > 0) count++;
   } 
Console.WriteLine($"Было введено {count} чисел больше 0");