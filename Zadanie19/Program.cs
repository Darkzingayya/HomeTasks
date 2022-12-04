// Палиндром или нет?
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32 (Console.ReadLine());

if (9999 < n && n < 100000){
    if (n / 10000 == n % 10){
         n = n /10; n = n % 1000; // отрезаем первую и последнюю цифру
         if (n/100 == n%10)
            Console.Write("Число палиндром");
         else Console.Write("Число не палиндром");}
      else Console.Write("Число не палиндром");}
else Console.Write("Число не пятизначное!");
