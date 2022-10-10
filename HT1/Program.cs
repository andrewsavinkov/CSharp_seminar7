/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

// функция, которая выводит двухмерный массив в консоль
void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// генератор массива случайных положительных вещественных чисел от 0 до 10 (1), 100(2), 1000(3) и т.д.
double[,] ArrayGenerator(int lines, int columns, int digitNumber)
{
    double[,] result = new double[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double factor = new Random().Next(-1, 2); // для создания возможности появления отрицательных чисел
            result[i, j] = Math.Round((new Random().NextDouble() * Math.Pow(10, digitNumber) * factor), 2);
        }
    }
    return result;
}

int m = 3;
int n = 4;
int p = 1;
double[,] myArr = ArrayGenerator(m, n, p);
PrintArray(myArr);