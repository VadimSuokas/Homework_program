/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */
/*
void palindrome()
{
    int num = Convert.ToInt32(Console.ReadLine());
    if(num / 10000 == num % 10)
    {
        num = num / 10;
        num = num % 1000;
            if(num / 100 == num % 10)
            Console.WriteLine("Число является палиндромом ");
    }
    else Console.WriteLine("Число не является палиндромом ");
}

Console.Write("Введите число ");

palindrome();
*/



void cube(int N)
{
    int current = 1;
    while(current<=N)
    {
        Console.WriteLine(current*current*current);
        current++;
    }
}

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

cube(N);
