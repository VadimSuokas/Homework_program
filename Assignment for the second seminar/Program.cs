/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. */
/*
int SecondNumber()
{
    Console.WriteLine("Введите число от 100 до 1000 ");
    int num = Convert.ToInt32(Console.ReadLine());
    

    int sotni = num / 10;
    int des = sotni % 10;

    int result = des;
    return result;
}

int s = SecondNumber();
Console.Write("Результат" + " " + s); */

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
/*
int ThirdNumber()
{
    Console.WriteLine("Введите число ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if(num<100) Console.Write(" " + "Введено число в котором нет третьего символа");
    while(num > 1000)
    {
        num = num / 10;
    }    
    int third = num % 10;
    int result = third;
    return result;  
}

int t = ThirdNumber();
Console.Write(" " + t); */

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

/*
int dayoftheweek(int d)
{
    
    int result = 1;

    if(d>=5 && d<8) result = -1;
    if(d<5 && d>0)  result = 0;
    return result;
}

   
    Console.WriteLine("Введите число от 1 до 7 ");
    int d = Convert.ToInt32(Console.ReadLine());

    int v = dayoftheweek(d);
    if(v == -1) Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочий");
    */
    

    

