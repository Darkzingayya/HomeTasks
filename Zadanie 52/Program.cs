// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void InputMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         matrix[i, j] = new Random().Next(1, 11);
         Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
      }
}


void MidlArf(int[,] matrix)
{ 
   for (int j = 0; j < matrix.GetLength(1); j++)
      { double midl = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
         midl += matrix[i, j];
        }
         Console.Write($"{midl/matrix.GetLength(0)} \t");
   
      }
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
InputMatrix(matrix);
MidlArf(matrix);
