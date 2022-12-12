void Function(int n)
{
    if(n > 9 && n < 100)
{
    int a = n / 10;
    int b = n % 10;
    int[] array = new int[2] {a, b};
    int lenght = array.Length;
    int per = 0;
    for(int i = 0; i < lenght; i++)
    {
        try
        {
            if(n % array[i] == 0)
            {
                per = per + array[i];
            }
        }

        catch (DivideByZeroException)
        {

        }
    }
    Console.Write($"{n} --> {per}");
}

else if(n > 99 && n < 1000)
{
    int a = n / 100;
    int b = (n / 10) % 10;
    int c = n % 10;
    int[] array = new int[3] {a, b, c};
    int lenght = array.Length;
    int per = 0;
    for(int i = 0; i < lenght; i++)
    {
        try
        {
            if(n % array[i] == 0)
            {
                per = per + array[i];
            }
        }
        catch (DivideByZeroException)
        {

        }
    }
    Console.Write($"{n} --> {per}");
}

else if(n > 999 && n < 10000)
{
    int a = n / 1000;
    int b = (n / 100) % 10;
    int c = (n / 10) % 10;
    int d = n % 10;
    int[] array = new int[4] {a, b, c, d};
    int lenght = array.Length;
    int per = 0;
    for(int i = 0; i < lenght; i++)
    {
        try
        {
            if(n % array[i] == 0)
            {
                per = per + array[i];
            }
        }
        catch (DivideByZeroException)
        {

        }
    }
    Console.Write($"{n} --> {per}");
}

else
{
    Console.Write($"{n} --> Ошибка");
}
}

Console.Write("Введите число от 10 до 10000: ");
int number = Convert.ToInt32(Console.ReadLine());
Function(number);