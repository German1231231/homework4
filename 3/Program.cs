void FillArray(int[] rand)
{
    int length = rand.Length;
    for(int i = 0; i < length; i++)
    {
        rand[i] = new Random().Next(10, 1000);
        if(rand[i] > 0 && rand[i] < 100)
        {
            int a = rand[i] / 10;
            int b = rand[i] % 10;
            int multiplication = a * b;
            int sum = a + b;
            if(multiplication % sum == 0)
            {
                Console.WriteLine("Интересное число: " + rand[i]);
                Console.WriteLine("Индекс интересного числа в массиве: " +i);
            }
            //Можно так же добавить "иначе", чтобы выводились неинтересные числа
            /*else
            {
                Console.WriteLine("Неинтересное число: " + rand[i]);
            }*/
        }

        else if(rand[i] > 99 && rand[i] < 1000)
        {
            int a = rand[i] / 100;
            int b = (rand[i] / 10) % 10;
            int c = rand[i] % 10;
            int multiplication = a * b * c;
            int sum = a + b + c;
            if(multiplication % sum == 0)
            {
                Console.WriteLine("Интересное число: " + rand[i]);
                Console.WriteLine("Индекс интересного числа в массиве: " +i);
            }
            //Можно так же добавить "иначе", чтобы выводились неинтересные числа
            /*else
            {
                Console.WriteLine("Неинтересное число: " + rand[i]);
            }*/
        }
    }
}

int[] array = new int[10];

FillArray(array);
Console.WriteLine("[{0}]", string.Join(", ", array));