int num; 

Console.Write(" Введите число ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.Write(" Число является четным ");
else
    Console.Write(" Число является нечетным ");