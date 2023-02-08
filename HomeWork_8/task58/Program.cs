/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();
int rowsMatrix1 = ReadInt("Введите количество строк первой матрицы: ");
int columnsMatrix1 = ReadInt("Введите количество столбцов первой матрицы: ");
int rowsMatrix2 = ReadInt("Введите количество строк второй матрицы: ");
int columnsMatrix2 = ReadInt("Введите количество столбцов второй матрицы: ");

int[,] matrix1 = new int[rowsMatrix1, columnsMatrix1];
int[,] matrix2 = new int[rowsMatrix2, columnsMatrix2];
int[,] resultMtrix = new int[rowsMatrix1,columnsMatrix2];
// проверка возможности перемножения двух матриц
if (columnsMatrix1 != rowsMatrix2)  Console.WriteLine("Матрицы с заданными параметрами невозможно перемножить (количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы)! Задайте другие парметры!");
else {
FillArray(matrix1);
Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArray(matrix1);
FillArray(matrix2);
Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);
MultiplyMatrix(matrix1, matrix2, resultMtrix);
Console.WriteLine("Результат произведения двух матриц:");
PrintArray(resultMtrix);
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j <array1.GetLength(1); j++)
        {
            Console.Write(array1[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
