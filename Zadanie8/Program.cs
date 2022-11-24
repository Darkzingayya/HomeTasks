Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine());
int count = 2;
if(n > 0) 
   {
      if(n%2 == 0) 
         {
          while (count <= n)
            {
            Console.WriteLine(count);
            count+=2;
               }
           }
      else {
         while(count <= n-1)
         {
            Console.WriteLine(count);
            count+=2;
         }

      }
}
else 
{
   Console.WriteLine("Число должно быть больше нуля!");
}
if(n == 1) 
   {
   Console.WriteLine("На промежутке между 0 и " + n + " чётных чисел нет!");
   }