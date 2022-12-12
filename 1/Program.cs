Console.Write("Введите число A от 0 до 10: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B от 0 до 10: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;

if(a > 0 && a < 10 && b > 0 && b < 10)
{
    for(int i = 1; i < b; i++)
    {
        result = result * a;
    }
}
else
{
    Console.WriteLine("Введено неверное число");
}

Console.Write(result);