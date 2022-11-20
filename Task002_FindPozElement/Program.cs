//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

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

bool FindPositionElement (int[,]array, int x, int y)
{
    if (x < array.GetLength(0) && y < array.GetLength(1))
    {
        return true;
    }
    return false;
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



System.Console.WriteLine("Задайте размерность массива");
int m = PromptInt("Введите m (кол-во строк): ");
int n = PromptInt("Введите n (кол-во столбцов): ");
int[,] matrix = FillArray(m, n);
PrintArrayTwo(matrix);
System.Console.WriteLine("Внимание: первая строка/первый столбец расположены в 0-вой позиции");
int coor1 = PromptInt("Введите позицию строки, в которой расположен искомый элемент: ");
int coor2 = PromptInt("Введите позицию столбца, в которой расположен искомый элемент: ");
if (FindPositionElement(matrix, coor1, coor2))
{
System.Console.WriteLine($" Значение элемента с позициями [{coor1};{coor2}] равно {matrix[coor1, coor2]}");
}
else
{
System.Console.WriteLine($" Элемента с позициями [{coor1};{coor2}] в массиве нет");
}