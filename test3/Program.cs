// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
int m = inputNumber("Введите число строк 1-й матрицы: ");
int n = inputNumber("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = inputNumber("Введите число столбцов 2-й матрицы: ");
int rand = inputNumber("Введите диапазон случайных чисел: от 1 до ");

int[,] OneMartr = new int[m, n];
RandMatrix(OneMartr);
Console.WriteLine($"\nПервая матрица:");
PrintMatrix(OneMartr);

int[,] TwoMartr = new int[n, p];
RandMatrix(TwoMartr);
Console.WriteLine($"\nВторая матрица:");
PrintMatrix(TwoMartr);

int[,] ResMatr = new int[m, p];

WorkMatrix(OneMartr, TwoMartr, ResMatr);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintMatrix(ResMatr);

void WorkMatrix(int[,] OneMartrix, int[,] TwoMartrix, int[,] ResMatrix)
{
    for (int i = 0; i < ResMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < OneMartr.GetLength(1); k++)
            {
                sum += OneMartr[i, k] * TwoMartr[k, j];
            }
            ResMatrix[i, j] = sum;
        }
    }
}
void RandMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(rand);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
