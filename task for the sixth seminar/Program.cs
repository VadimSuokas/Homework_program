// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Array(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) 
    {
        Console.Write("Введите число ");
        int temp = Convert.ToInt32(Console.ReadLine());
        array[i] = temp;
        
    }
    return array;
}

void ShowArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Сколько чисел вы хотели бы ввести ");
int s = Convert.ToInt32(Console.ReadLine());

int[] arr = Array(s);
ShowArr(arr);


int aboveZero(int[] Array)
{
    int sum = 0;

    for(int i = 0; i < Array.Length; i++)
        if(Array[i] > 0) sum++;
    
    return sum;
}


Console.WriteLine("Вы ввели " + aboveZero(arr) + " " + "чисел больше нуля");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.