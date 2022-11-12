/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10);
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
int[,] martrix1 = new int[3, 3];
CreateArray(martrix1);
Console.WriteLine($"\nПервая матрица:");
WriteArray(martrix1);

int[,] martrix2 = new int[3, 3];
CreateArray(martrix2);
Console.WriteLine($"\nВторая матрица:");
WriteArray(martrix2);

int[,] matrixResult = new int[3,3];

MultiplyMatrix(martrix1, martrix1, matrixResult);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(matrixResult);

void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] matrixResult)
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix1[i,k] * martrix2[k,j];
      }
      matrixResult[i,j] = sum;
    }
  }
}


