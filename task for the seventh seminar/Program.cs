// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] RealNumbers(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++) 
            newArray[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();

        return newArray;
}  

void ShowArrayRandom(double[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

Console.Write("Input number of rows ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = RealNumbers(m,n,min,max);
ShowArrayRandom(myArray);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] ArrayMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(min,max);
    
    return array;
}
void ShowArrayRandom2d(int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void ElementPosition(int[,] array, int x, int y)
{
    if(x-1 > array.GetLength(0) || x-1 < 0 || y-1 > array.GetLength(1) || y-1 < 0)
        Console.WriteLine("Элемента с заданными параметрами не существует в массиве ");
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(i == x - 1 && j == y - 1)
                Console.WriteLine("На заданной позиции значение элемента " + array[i,j]);   
           
}

Console.Write("Input number of rows ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int Min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int Max = Convert.ToInt32(Console.ReadLine());

int[,] Arr = ArrayMatrix(M,N,Min,Max);
ShowArrayRandom2d(Arr);
Console.Write("Position in rows ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Position in columns ");
int y = Convert.ToInt32(Console.ReadLine());

ElementPosition(Arr,x, y);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void ShowArrayRandom2(int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
void ArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double srArif = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            srArif += array[j, i];
    
        Console.WriteLine($"Cреднее арифметическое {i+1} столбца  = {srArif/array.GetLength(1)}");
    }
    
}

Console.Write("Input number of rows ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[,] Arr2d = ArrayMatrix(m1,n1,min1,max1);
ShowArrayRandom2(Arr2d);
Console.WriteLine();

ArithmeticMean(Arr);

