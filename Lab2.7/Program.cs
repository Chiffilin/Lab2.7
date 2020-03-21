using System;
using System.Linq;

class ArrayExample
{
    static void Main()
    {
        int L;
        Console.WriteLine("Введите размер массива:");
        while (!int.TryParse(Console.ReadLine(), out L))                //проверка на ввод переменных
        {
            Console.WriteLine("Ошибка ввода! Введите целое число L");
        }

        int[] array = new int[L];
        Random rand = new Random();
        for (int y = 0; y < L; y++)
        {
            array[y] = rand.Next(-50, 50);
            Console.WriteLine(array[y]);

        }
        for (int i = 0; i <array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine();
        int a;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
          
        }

    }
}
 