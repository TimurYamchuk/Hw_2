/*
1. Создать массив из 10 случайных чисел в диапазоне от 0 до 5. Сжать
массив, удалив из него все 0, и заполнить освободившиеся справа
элементы значениями -1.
*/

using System;
using static System.Console;

class Hw_2_1
{
    static void Main()
    {
        try
        {
            int[] numbers = new int[10];
            Random rng = new Random();

            WriteLine("Исходный массив:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 6); 
                Write($"{numbers[i]} ");
            }

            
            int filledIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0) 
                {
                    numbers[filledIndex++] = numbers[i];
                }
            }

           
            for (int i = filledIndex; i < numbers.Length; i++)
            {
                numbers[i] = -1;
            }

            WriteLine("\nСжатый массив:");

            foreach (int num in numbers)
            {
                Write($"{num} ");
            }
        }
        catch (Exception error)
        {
            WriteLine($"Произошла ошибка: {error.Message}");
        }
    }
}
