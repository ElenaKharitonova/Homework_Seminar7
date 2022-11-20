//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArrayTwo(int[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]}");
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            System.Console.Write($" {arrNums[i, j]}");
        }
        System.Console.WriteLine("");
    }
}

void PrintArray(double[] array)//печать одномерного массива
{
    System.Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

double [] MidArithmetColumn(int[,] array)
{
    int n = array.GetLength(1);
    double[] midArithmetic = new double[n];
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double tempSumColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           {
               tempSumColumn = tempSumColumn + array[i,j];;
           }
        }
        midArithmetic[j] = tempSumColumn/array.GetLength(0); 
    }
    return midArithmetic;
}

System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк): ");
int n = PromptInt("Введите n (кол-во столбцов): ");
int[,] matrix = FillArray(m, n);
PrintArrayTwo(matrix);
double[] arr = MidArithmetColumn(matrix);
System.Console.WriteLine($" Среднее арифметическое элементов в каждом столбце матрицы равно:  ");
PrintArray(arr);
