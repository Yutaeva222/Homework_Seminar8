// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Укажите число строк первого массива:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число столбцов первого массива (и строк второго):  ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число столбцов второго массива:  ");
int p = Convert.ToInt32(Console.ReadLine());


int[,] numbers1 = new int[rows, columns];
FillArray(numbers1);
Console.WriteLine("Первая матрица:");
PrintArray(numbers1);
int[,] numbers2 = new int[columns,p];
FillArray(numbers2);
Console.WriteLine("Вторая матрица:");
PrintArray(numbers2);

int[,] resultMatrix = new int[rows, p];

MultiplyMatrix(numbers1, numbers2, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц: ");
PrintArray(resultMatrix);

void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] numbers1, int[,] numbers2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < numbers1.GetLength(1); k++)
      {
        sum += numbers1[i,k] * numbers2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
