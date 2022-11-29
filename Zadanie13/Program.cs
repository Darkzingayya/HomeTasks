Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());
if (a < -99 || a > 99) {
   while (a < -999 || a > 999) a = a / 10; 
   if (a < 0) a = a * -1; // Отрицательных цифр не существует!
   Console.WriteLine ($"Третья цифра: {a%10}");
}
else Console.WriteLine("В числе нет третьей цифры!");