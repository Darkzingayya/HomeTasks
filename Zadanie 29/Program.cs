// Напишите программу, которая задаёт массив из 8 элементов, 
// предоставить возможность пользователю ввести числа и вывести их на экран.
Console.Clear();
int[] array = new int[8];
int index = 0;
for (int i = 0; i < 8; i++)
{
   Console.Write($"Введите {i} элемент массива: ");
   array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вывод массива: ");
while (index < 8)
{
   Console.Write(array[index]+ " ");
   index++;
}