// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Array2d(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(min,max);
    
    return array;

}

void ShowArray2d(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] DescendingOrder(int[,] array)
{   
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int y = j + 1; y < array.GetLength(1); y++)
            {
                if(array[i, j] < array[i, y])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, y];
                    array[i, y] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Input number of rows ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] Array = Array2d(x, y, minValue, maxValue);
ShowArray2d(Array);
Console.WriteLine();
int[,] Arr = DescendingOrder(Array);
ShowArray2d(Arr);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void MinElementRows(int[,] array)
{
    int sum = 0;
    int iSum = 0;
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(sum < iSum)
        {
            iSum = sum;
            sum = 0;
            count = i;
        }
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        sum += array[i,j];
    }
    Console.WriteLine("Строка " + (count + 1) + " с наименьшей суммой элементов " );
}

Console.Write("Input number of rows ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of value ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] Array = Array2d(x, y, minValue, maxValue);
ShowArray2d(Array);
MinElementRows(Array);

// Задача 62. Заполните спирально массив 4 на 4.

int[,] SpiralArray(int n)
{
    int[,] array = new int[n,n]; 
    int count = 1;
    int i =0;
    int j =0;

    while(count <= n*n)
    {
        array[i,j] = count;
        count++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}

int[,] Arr2d = SpiralArray(4);

ShowArray2d(Arr2d);
