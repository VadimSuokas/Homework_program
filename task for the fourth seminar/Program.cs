// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int n)
{
    int sum = 0;
    while(n > 0)
    {
        sum = sum + n % 10;
        n = n/10;
    }
    return sum;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(num));

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] ArrayElements(int m, int min, int max)
{
    int[] array = new int[m];
    
    for(int i = 0; i < m; i++) 
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }       
    return array;
}

Console.Write("Введите колличество элементов в массиве ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение числа в массиве ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение числа в массиве ");
int max = Convert.ToInt32(Console.ReadLine());

ArrayElements(size, min, max);




