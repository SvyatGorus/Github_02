using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Random;

namespace GitHub_HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Write("Введите номер задания от 1 до 3 (для выхода введите 0): ");
                while (!int.TryParse(ReadLine(), out choice) || choice < 0 || choice > 3)
                {
                    Write("Неверный ввод! Повторите ещё раз: ");
                }
                switch (choice)
                {
                    case 1:
                        {
                            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 4, 6, 8, 10, 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 6, 7, 8, 9 };
                            int val, count = 0;
                            Write("Введите целое число: ");
                            int.TryParse(ReadLine(), out val);
                            foreach (int elem in arr)
                            {
                                if (elem == val)
                                    count++;
                                Write(elem + " ");
                            }
                            WriteLine(String.Format("\nЗначение {0} встречается в массиве {1} раз(а).", val, count));
                            break;
                        }
                    case 2:
                        {
                            const int M = 5, N = 6;
                            int tmp, a, b;
                            int[,] arr = new int[M, N] { { 0, 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9, 0 }, { 0, 9, 8, 7, 6, 5 }, { 5, 4, 3, 2, 1, 0 }, { 5, 3, 4, 2, 1, 0 } };
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = 0; j < N; j++)
                                {
                                    Write(arr[i, j] + " ");
                                }
                                WriteLine();
                            }
                            while (true)
                            {
                                Write("Введите номер 1-го столбца (0 - 6): ");
                                int.TryParse(ReadLine(), out a);
                                if (a < 0 || a > 6)
                                {
                                    Write("Введите корректное значение. ");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            while (true)
                            {
                                Write("Введите номер 2-го столбца (0 - 6): ");
                                int.TryParse(ReadLine(), out b);
                                if (b < 0 || b > 6)
                                {
                                    Write("Введите корректное значение. ");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            WriteLine("Меняем местами " + a + " столбец и " + b + " столбец: ");
                            for (int i = 0; i < M; i++)
                            {
                                tmp = arr[i, a - 1];
                                arr[i, a - 1] = arr[i, b - 1];
                                arr[i, b - 1] = tmp;
                            }
                            for (int i = 0; i < M; i++)
                            {
                                for (int j = 0; j < N; j++)
                                {
                                    Write(arr[i, j] + " ");
                                }
                                WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            int str, col;
                            Write("Введите количество строк: ");
                            int.TryParse(ReadLine(), out str);
                            Random rnd = new Random();
                            int[][] arr = new int[str][];
                            for (int i = 0; i < str; i++)
                            {

                                Write("Введите количество столбцов в " + (i + 1) + " -й строке: ");
                                int.TryParse(ReadLine(), out col);
                                arr[i] = new int[col];
                            }
                            for (int i = 0; i < arr.Length; i++)
                            {
                                for (int j = 0; j < arr[i].Length; j++)
                                {
                                    arr[i][j] = rnd.Next(1, 100);
                                }
                            }
                            for (int i = 0; i < arr.Length; i++)
                            {
                                for (int j = 0; j < arr[i].Length; j++)
                                {
                                    Write(arr[i][j] + " ");
                                }
                                WriteLine();
                            }
                            break;
                        }
                }
            } while (choice != 0);
        }
    }
}