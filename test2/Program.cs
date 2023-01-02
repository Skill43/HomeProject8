// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений:");
int m = inputNumber("Введите m: ");
int n = inputNumber("Введите n: ");
int rand = inputNumber("Введите диапазон: от 1 до ");

int[,] matrix = new int[m, n];
RandMatrix(matrix);
PrintMatrix(matrix);

int MinSum = 0;
int sum = ResSumElem(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSum = ResSumElem(matrix, i);
    if (sum > tempSum)
    {
        sum = tempSum;
        MinSum = i;
    }
}

Console.WriteLine($"\n{MinSum + 1} - строкa с наименьшей суммой ({sum}) элементов ");

int ResSumElem(int[,] matrix, int i)
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i, j];
    }
    return sumLine;
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

