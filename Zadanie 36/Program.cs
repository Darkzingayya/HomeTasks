// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
      for (int i = 0; i < array.Length; i++ )
         array[i] = new Random().Next(-99, 100); // Ограничение просто для удобства, задача его не требует и можно убрать.
}


void ReleaseArray (int[] array, ref int sum)
{
for (int i = 1; i < array.Length; i+=2)
   {
      sum+= array[i];
   }
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine()), sum = 0;
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array, ref sum);
Console.WriteLine(sum);