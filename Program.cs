using System;

class Program
{
    static int Akerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return Akerman(m - 1, 1);
        }
        else
        {
            return Akerman(m - 1, Akerman(m, n - 1));
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите неотрицательные числа m и n для функции Аккермана:");
        Console.Write("m = ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m < 0 || n < 0)
        {
            Console.WriteLine("Числа должны быть неотрицательными.");
        }
        else
        {
            int result = Akerman(m, n);
            Console.WriteLine($"Результат функции Аккермана A({m}, {n}) = {result}");
        }
    }
}





using System;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        int[] myArray = new int[10]; // Задаем размер массива
        FillArrayRecursively(myArray, 0);
        PrintArrayRecursively(myArray, 0);
    }

    static void FillArrayRecursively(int[] array, int index)
    {
        if (index < array.Length)
        {
            array[index] = random.Next(100); // Заполняем массив случайными числами до 100
            FillArrayRecursively(array, index + 1);
        }
    }

    static void PrintArrayRecursively(int[] array, int index)
    {
        if (index < array.Length)
        {
            Console.Write(array[index] + " ");
            PrintArrayRecursively(array, index + 1);
        }
        else
        {
            Console.WriteLine();
        }
    }
}


