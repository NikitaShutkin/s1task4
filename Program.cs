Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int num3 = Convert.ToInt32(Console.ReadLine());
int m = 0;

if (num1 > num2)
{
    if (num1 > num3)
    {
        m = num1;
    }

}
else if (num2 > num3)
{
    m = num2;
}
else
{
    m = num3;
}
Console.WriteLine($"Максимальное число {m}");

