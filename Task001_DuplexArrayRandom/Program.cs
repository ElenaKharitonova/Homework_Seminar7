//Задайте двумерный массив размером mxn,
//заполненный случайными числами

int PromptInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double PromptDouble(string message)
{
    System.Console.Write(message);
    double temp = Convert.ToDouble(Console.ReadLine());
    return temp;
}

double[,] FillRandomArray(int m, int n, double minRandom, double maxRandom)
{
    double[,] array = new double[m, n];
    Random realRandom = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = realRandom.NextDouble() * (maxRandom - minRandom) + minRandom;;
        }
    Console.WriteLine();
    }
return array;
}

void PrintArrayTwo(double[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        for (int j = 0; j < arrNums.GetLength(1); j++)
        {
            Console.Write($"{arrNums[i, j]:F1}   ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк): ");
int n = PromptInt("Введите n (кол-во столбцов): ");
double minRandom = PromptDouble("Введите нижнюю границу дмапазона: ");
double maxRandom = PromptDouble("Введите верхнюю границу дмапазона: ");
double[,] matrix = FillRandomArray(m, n, minRandom,maxRandom);
PrintArrayTwo(matrix);
System.Console.WriteLine();
System.Console.WriteLine();