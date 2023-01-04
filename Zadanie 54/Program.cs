//54 Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void SwapMatrix(int[,] matrix)
{  
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {       
           for (int a = 0; a < matrix.GetLength(1)-1;a++)
           {
             if (matrix[i, a] < matrix[i, a + 1])
               {int cup = matrix[i, a+1];
                matrix[i, a + 1] = matrix[i, a];
                matrix[i, a] = cup;
               }
           }
           //Console.Write($"{matrix[i, j]} \t");
        }
        //Console.WriteLine();
    }
    
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив: ");
inputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Конечный массив: ");
SwapMatrix(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)            //Пробовал выводить в "SwapMatrix" после завершения сортировки,
    {                                                    // Но не всегда корректно выводило 
        for (int j = 0; j < matrix.GetLength(1); j++)    // (появлялись цифры, которых изначально не было)
            Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
    }
