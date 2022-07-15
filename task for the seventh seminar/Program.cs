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
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


