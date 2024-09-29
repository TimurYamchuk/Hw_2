/*
2. Заполнить квадратную матрицу размером N x N по спирали (N –
нечётное число). Число 1 ставится в центр матрицы, а затем массив
заполняется по спирали против часовой стрелки значениями по
возрастанию.
*/

using System;
using static System.Console;

class Hw_2_2
{
    static void Main()
    {
        try
        {
            WriteLine("Введите нечётное число N:");
            int N = int.Parse(ReadLine());
            if (N % 2 == 0)
            {
                WriteLine("N должно быть нечётным!");
                return;
            }

            int[,] matrix = new int[N, N];
            int value = 1;
            int x = N / 2, y = N / 2;
            matrix[x, y] = value++;

            int step = 1;
            while (step < N)
            {
                // <
                for (int i = 0; i < step; i++) matrix[--x, y] = value++;
                // /\
                for (int i = 0; i < step; i++) matrix[x, --y] = value++;
                step++;
                // >
                for (int i = 0; i < step; i++) matrix[++x, y] = value++;
                // \/
                for (int i = 0; i < step; i++) matrix[x, ++y] = value++;
                step++;
            }

            for (int i = 0; i < N - 1; i++) matrix[--x, y] = value++;

            WriteLine("Матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Write($"{matrix[i, j],3} ");
                }

                WriteLine();
            }
        }
        catch (Exception ex)
        {
            WriteLine($"Ошибка: {ex.Message}");
        }
    }
}