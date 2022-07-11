// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ArrayRandom(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
        if(min>99 && max<1000) array[i] = new Random().Next(min, max);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenNumbers(int[] Array)
{
    int count = 0;
    for(int i = 0; i < Array.Length; i++) 
    if(Array[i] % 2 == 0) count++;
    return count;
}


Console.Write("Введите колличество элементов в массиве ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное трехзначное число массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное трехзначное число массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] Array = ArrayRandom(size, min, max);

ShowArray(Array);

int even = EvenNumbers(Array);
Console.WriteLine("Колличество четных чисел в массиве равно " + even);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Эта задача выполняется по методам "int[] ArrayRandom(int size, int min, int max)" и "void ShowArray(int[] array)" если на 7 строчке поставить /*if(min>99 && max<1000)*/ и закомитить 38 и 39.

int Sum(int[] Array)
{
    int sum = 0;
    for(int i = 0; i < Array.Length; i++)
        if(i % 2 != 0) sum += Array[i];
    return sum;
}

int sum = Sum(Array);
Console.WriteLine("Сумма элементов на нечетных позициях массива равна " + sum);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomArray(int S)
{
    double[] array = new double[S];
    for(int i = 0; i < S; i++)
    { 
        
        double tempA= new Random().NextDouble();
        int tempB = new Random().Next();
        array[i] = tempB + tempA;
    }
    return array;
}

void DoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
    Console.WriteLine();
}

double RealNumbers(double[] array)
{
    
    double max = 0;
    double min = 0;
    
    for(int i = 0; array[i] > max; max = array[i], i++) 
    {
        if(array[i] < min) min = array[i];
    }
    
    double result = max - min;
    
    return result;
}
Console.Write("Введите размер массива ");
int S = Convert.ToInt32(Console.ReadLine());
double[] ARRAY = RandomArray(S);
DoubleArray(ARRAY);

double difference = RealNumbers(RandomArray(S));
Console.WriteLine("Разница между максимальным и минимальным элементом равна" + difference);
