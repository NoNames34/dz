Console.Clear();
Console.WriteLine("Укажите размеры матриц a, b и диапазон случайных чисел: ");
    int a = InputNumbers("Введите число строк матрицы a: ");
    int b = InputNumbers("Введите число столбцов матрицы a (и строк матрицы b): ");
    int p = InputNumbers("Введите число столбцов матрицы b: ");
    int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] oneMartrix = new int[a, b];
CreateArray(oneMartrix);
Console.WriteLine($"Первая матрица-a:");
WriteArray(oneMartrix);

int[,] twoMartrix = new int[b, p];
CreateArray(twoMartrix);
Console.WriteLine($"Вторая матрица-b:");
WriteArray(twoMartrix);

int[,] resultMatrix = new int[a,p];

MultiplyMatrix(oneMartrix, twoMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] oneMartrix, int[,] twoMartrix, int[,] resultMatrix)
    {
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
            int sum = 0;
            for (int k = 0; k < oneMartrix.GetLength(1); k++)
                {
                    sum += oneMartrix[i,k] * twoMartrix[k,j];
                }
            resultMatrix[i,j] = sum;
            }
    }
    }

int InputNumbers(string input)
    {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }

void CreateArray(int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                array[i, j] = new Random().Next(range);
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