// 62 Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер стороны ''квадрата'': ");
int coord = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[coord, coord];
int numbers = 1;
int i = 0;
int j = 0;

while (numbers <= coord * coord)
{
    matrix[i, j] = numbers;
    if (i <= j + 1 && i + j < coord - 1)
        j++;
    else if (i < j && i + j >= coord - 1)
        i++;
    else if (i >= j && i + j > coord - 1)
        j--;
    else
        i--;
    numbers++;
}
PrintMatrix(matrix);