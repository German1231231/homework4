
void FullArray(int a, int b, int result)
{
    if(a > 0 && a < 10 && b > 0 && b < 10)
    {
        result = a;
        for(int i = 1; i < b; i++)
        {   
            result = result * a;
        }
    }
    else
    {
        Console.WriteLine("Введено неверное число");
    }
    Console.WriteLine(result);
}

Console.Write("Введите число A от 0 до 10: ");
int v = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B от 0 до 10: ");
int g = Convert.ToInt32(Console.ReadLine());

int l = v;

FullArray(v, g, l);