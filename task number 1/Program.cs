
int a; int b; int max;

Console.Write("Введите первое число ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    max = a;
    Console.WriteLine("Максимальное по значению число" + " " + max);  
} 
else
{
    max=b;
    Console.WriteLine("Максимальное по значению число" + " " + max);
}
