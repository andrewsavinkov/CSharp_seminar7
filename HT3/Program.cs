/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GenerateIntArray (int rows, int columns)
{
    int[,] outputArr = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            outputArr[i, j]=new Random().Next(0, 11);
    }
    return outputArr;
}

void PrintMatrix (int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
            Console.Write($"{inputMatrix[i,j]} \t");
        Console.WriteLine();
    }
}
double Average(int[] inputArray)
{
    double sum = 0;
    for (int i = 0; i < inputArray.Length; i++)
        sum = sum + inputArray[i];
    return Math.Round(sum / Convert.ToDouble(inputArray.Length), 2);
}

int[] ColumnExtractor (int colNumber, int[,] inputMat)
{
    int[] column = new int[inputMat.GetLength(0)];
    for (int i = 0; i < inputMat.GetLength(0); i++)
        column[i]=inputMat[i, colNumber];
    return column;
}

double[] ColumnAverage (int[,] inputMatr)
{
    double[] avgArray = new double[inputMatr.GetLength(1)];
    for (int i = 0; i < inputMatr.GetLength(1); i++)
    {
        avgArray[i]=Average(ColumnExtractor(i, inputMatr));
    }
    return avgArray;
}

void VectorPrint(double[] inputVec)
{
    for (int i = 0; i < inputVec.Length; i++)
        Console.Write($"{inputVec[i]} \t");
}

int[,] testArr = GenerateIntArray(3, 4);
PrintMatrix(testArr);
Console.WriteLine();
double[] avgVector = ColumnAverage(testArr);
VectorPrint(avgVector);
