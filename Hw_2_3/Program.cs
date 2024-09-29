/*
3. Дан двумерный массив размерностью N x M, заполненный
случайными числами из диапазона от 0 до 100. Выполнить
циклический сдвиг массива на заданное количество столбцов.
Направление сдвига задаёт пользователь.
*/

using System;
using static System.Console;

class Hw_2_3
{
    static void Main()
    {
        try
        {
            WriteLine("Введите количество строк N:");
            int N = int.Parse(ReadLine());

            WriteLine("Введите количество столбцов M:");
            int M = int.Parse(ReadLine());

            int[,] matrix = new int[N, M];
            Random rand = new Random();

            WriteLine("Исходный массив:");
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = rand.Next(0, 101);
                    Write("{0,4}", matrix[row, col]);
                }

                WriteLine();
            }

            WriteLine("Введите количество столбцов для сдвига:");
            int shift = int.Parse(ReadLine());

            WriteLine("Введите направление сдвига (L - влево, R - вправо):");
            char direction = char.ToUpper(ReadKey().KeyChar);
            WriteLine();

            if (direction != 'L' && direction != 'R')
            {
                WriteLine("Неверное направление сдвига!");
                return;
            }

            shift = shift % M;

            WriteLine("Массив после сдвига:");
            for (int row = 0; row < N; row++)
            {
                int[] tempRow = new int[M];

                for (int col = 0; col < M; col++)
                {
                    int newCol;

                    if (direction == 'L')
                    {
                        newCol = (col + M - shift) % M;
                    }
                    else 
                    {
                        newCol = (col + shift) % M;
                    }

                    tempRow[newCol] = matrix[row, col];
                }

                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = tempRow[col];
                    Write("{0,4}", matrix[row, col]);
                }

                WriteLine();
            }
        }
        catch (FormatException ex)
        {
            WriteLine("Ошибка ввода: " + ex.Message);
        }
        catch (Exception ex)
        {
            WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}