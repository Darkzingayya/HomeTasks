Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32 (Console.ReadLine());
if ( a > 0 && a < 8) {
   if ( a > 5) Console.WriteLine("Выходной!");
   else Console.WriteLine("Будний день");
}
else Console.WriteLine("В недели 7 дней!");