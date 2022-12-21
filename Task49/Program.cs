// 1.Задайте думерный массив.
// 2.Оба индеса четных и заменить элемент на квадрат.
int[,] FillMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
int[,] FindIndexAndSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) matrix[i,j]*= matrix[i,j];
        }
    }
    return matrix;
}

int[,] newMatrix = FillMatrixRndInt(3, 4);
PrintMatrix(newMatrix);
int[,] newMatrixSqaure = FindIndexAndSquare(newMatrix);
Console.WriteLine();
PrintMatrix(newMatrixSqaure);