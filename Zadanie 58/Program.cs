//58  Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


int[,] NewMatrix(int[,] matrix, int[,] matrix1)
{
    int[,] proizv = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            proizv[i, j] = matrix[i, j] * matrix1[i, j];
    }
    return proizv;
}


Console.Clear();
Console.Write("Введите размер матриц: "); 
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[,] matrix1 = new int[coord[0], coord[1]];
InputMatrix(matrix);
InputMatrix(matrix1);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Результат:");
PrintMatrix(NewMatrix(matrix, matrix1));