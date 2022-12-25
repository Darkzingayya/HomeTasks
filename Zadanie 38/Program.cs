// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(int[] array)
{
      for (int i = 0; i < array.Length; i++ )
         array[i] = new Random().Next(0, 100); 
}

int ReleaseArray (int[] array)
{
   int min = array[0], max = array[0];
   for (int i = 1; i < array.Length; i++)
   {
      if (array[i] > max)
         max = array[i];
      else if (array[i] < min) 
         min = array[i];
   }
   return max-min;
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
