/* Задача 50. Напишите программу, которая на вход принимает число и возвращает позицию (i, j) этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

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

void ReturnPosition(double[,] inputArray)
{
    Console.WriteLine("Enter the number to search within the array: ");
    bool correctInput = false;
    bool isFound = false;
    double number = 0;
    correctInput = double.TryParse(Console.ReadLine(), out number);
    if (!correctInput)
        Console.WriteLine("enter a valid number!");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] == number)

            {
                Console.WriteLine($"Index is: {i}, {j}");
                isFound = true;
            }
        }
    }
    if(!isFound)
        Console.WriteLine("No such element within the array!");
}

int m = 3;
int n = 4;
int p = 1;
double[,] myArr = ArrayGenerator(m, n, p);
PrintArray(myArr);
ReturnPosition(myArr);