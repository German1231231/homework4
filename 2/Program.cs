Console.Write("Введите число от 10 до 1000: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n > 9 && n < 100)
{
    int a = n / 10;
    int b = n % 10;

    if(n % a == 0 && n % b == 0)
    {
        int sum = a + b;
        Console.Write($"{n} --> {sum}");
    }

    else if(n % a == 0 && n / b != 0)
    {
        Console.Write($"{n} --> {a}");
    }

    else if(n % b == 0 && n / a != 0)
    {
        Console.Write($"{n} --> {b}");
    }

    else if(n / b != 0 && n / a != 0)
    {
        Console.Write($"{n} Ошибка");
    }
}

else if(n > 99 && n < 1000)
{
    int a = n / 100;
    int b = (n / 10) % 10;
    int c = n % 10;

    if(n % a == 0 && n % b == 0 && n % c == 0)
    {
        int sum = a + b + c;
        Console.Write($"{n} --> {sum}");
    }

    else if(n % a == 0 && n % b == 0 && n / c != 0)
    {
        int sum = a + b;
        Console.Write($"{n} --> {sum}");
    }

    else if(n % a == 0 && n / b != 0 && n % c == 0)
    {
        int sum = a + c;
        Console.Write($"{n} --> {sum}");
    }

    else if(n / a != 0 && n % b == 0 && n % c == 0)
    {
        int sum = b + c;
        Console.Write($"{n} --> {sum}");
    }

    else if(n % a == 0 && n / b != 0 && n / c != 0)
    {
        Console.Write($"{n} --> {a}");
    }

    else if(n / a != 0 && n % b == 0 && n / c != 0)
    {
        Console.Write($"{n} --> {b}");
    }

    else if(n / a != 0 && n / b != 0 && n % c == 0)
    {
        Console.Write($"{n} --> {c}");
    }

    else if(n / a != 0 && n / b != 0 && n / c != 0)
    {
        Console.Write($"{n} Ошибка");
    }
}

else
{
    Console.Write("Введенно неверное число");
}