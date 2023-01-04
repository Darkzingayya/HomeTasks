//60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void InputMatrix(int[,,] matrix)
{
    int k = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
                matrix[i, j, z] = k++; 
        }
    }
}


void ReleaseMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
                Console.WriteLine($"{matrix[i, j, z]} ({i}, {j}, {z})");
        }
    }
}


Console.Clear();
Console.Write("Введите размер трехмерного массива : ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (coord[0] * coord[1] * coord[2] > 90)
    Console.Write("Размер слишком большой!");
else{
int[,,] matrix = new int[coord[0], coord[1], coord[2]];
InputMatrix(matrix);
ReleaseMatrix(matrix);}
