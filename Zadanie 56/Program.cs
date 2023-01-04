// 56 Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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


int SummMatrix(int[,] matrix)
{
    int minstring = 0, m = 0;
    for (int a = 0; a < matrix.GetLength(1); a++)
        minstring += matrix[0, a];

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
           {
                sum += matrix[i, j];
            }
        if (minstring > sum)
           { minstring = sum;
            m = i;} //сохранение индекса строки
     }
    return m;
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив: ");
inputMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой: {SummMatrix(matrix)+1}");