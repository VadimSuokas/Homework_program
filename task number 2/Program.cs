
int a; int b; int c; int max;

Console.Write("Введите первое число ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
c = Convert.ToInt32(Console.ReadLine());
max=0;
if(a>max)
    max=a;
if(b>max);
    max=b;
if(c>max);
    max=c;

Console.WriteLine("Максимальное по значению число" + " " + max);