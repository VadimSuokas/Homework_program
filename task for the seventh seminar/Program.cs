// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
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
*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// P.S Долго думал как сделать чтобы результат else выводился только один раз, но к сожалению так и не придумал :(
int[,] ArrayMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(min,max);
    
    return array;
}
void ShowArrayRandom(int[,] array)
{
    for(int i= 0; i < array.GetLength(0); i++)
    {
        for(int j= 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
void ElementPosition(int[,] array, int element)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] == element)
                Console.WriteLine("Заданный элемент находится на " + (i+1) + " " + "строчке " + "в" + " " + (j+1) + " " + "столбце " );
            else Console.WriteLine("Заданный элемент в массиве отстутствует ");
}

Console.Write("Input number of rows ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] Arr = ArrayMatrix(m,n,min,max);
ShowArrayRandom(Arr);
Console.Write("Input number ");
int e = Convert.ToInt32(Console.ReadLine());
ElementPosition(Arr,e);
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] ArithmeticMean(int[,] array, int size)
{
    double[] Arr = new double[size];
    double current = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++) 
            Arr[i] = current/
            while(j==0)
            {
                current += array[i,j];   
            }



}
