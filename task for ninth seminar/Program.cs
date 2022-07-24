// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

int NumberOfDigits(int n)
{

    int count = 0;
    
    if(n % 10 > 0)
    {
        count++;
        return count + NumberOfDigits(n / 10);
    }
    else return count;
    
}

Console.Write("Input of numbers ");
int num = Convert.ToInt32(Console.ReadLine());

int result = NumberOfDigits(num);
Console.WriteLine("В введенном вами числе " + result + " цифр");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

