// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
      for (int i = 0; i < array.Length; i++ )
         array[i] = new Random().Next(-999, 1000);
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine()), kol = 0;
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
   {
      if (array[i]%2 == 0)
      kol++;
   }
   Console.WriteLine(kol);