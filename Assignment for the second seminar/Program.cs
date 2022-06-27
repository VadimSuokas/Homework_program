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
Console.Write("Результат" + " " + s);