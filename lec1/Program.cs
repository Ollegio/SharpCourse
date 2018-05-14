using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lec1
{
    class Program
    {
        private static int[,] mat;
        private static int[] rows, cols;
        private static int mainDiag, collatDiag;
        private static int SIZE;
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Введите размер матрицы");
                while (!int.TryParse(Console.ReadLine(), out SIZE))
                {
                    Console.WriteLine("Неверный формат числа, попробуйте снова:");
                }

                mat = new int[SIZE, SIZE];
                rows = new int[SIZE];
                cols = new int[SIZE];
                mainDiag = 0;
                collatDiag = 0;
                for (var i = 0; i < SIZE; i++)
                {
                    for (var j = 0; j < SIZE; j++)
                    {
                        mat[i, j] = -1;
                    }
                }

                int current = 1, next = -1;
                while (true)
                {
                    int x, y;
                    var input = current == -1 ? 0 : current;
                    Console.WriteLine($"Ввод {input}. Введите пару координат в одной строке, x и y");
                    var temp = Console.ReadLine()?.Split(' ');
                    if (temp == null || temp.Length != 2 || !int.TryParse(temp[0], out x) || !int.TryParse(temp[1], out y))
                    {
                        Console.WriteLine("Неверный формат данных");
                        continue;
                    }

                    if (mat[x, y] != -1)
                    {
                        Console.WriteLine("Ячейка уже заполнена");
                        continue;
                    }
                    mat[x, y] = input;
                    Fill(x, y, current);
                    if (Check(x, y))
                    {
                        Console.WriteLine("Программа завершена. Продолжить? Y - да, N - нет");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                            break;
                        exit = true;
                        break;
                    }
                    PrintMatrix();

                    Swap(ref current, ref next);
                }
            }
        }

        private static void PrintMatrix()
        {
            for (var i = 0; i < SIZE; i++)
            {
                for (var j = 0; j < SIZE; j++)
                {
                    Console.Write(mat[i, j] == -1 ? "- " : mat[i, j] == 1 ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }

        private static bool Check(int x, int y)
        {
            if (rows[x] == SIZE || rows[x] == -SIZE)
            {
                Console.WriteLine("Заполнена строка");
                return true;
            }

            if (cols[y] == SIZE || cols[y] == -SIZE)
            {
                Console.WriteLine("Заполнен столбец");
                return true;
            }

            if (mainDiag == SIZE)
            {
                Console.WriteLine("Заполнена диагональ");
                return true;
            }

            if (collatDiag == SIZE)
            {
                Console.WriteLine("Заполнена вторая диагональ");
                return true;
            }

            return false;
        }

        private static void Fill(int x, int y, int current)
        {
            rows[x] += current;
            cols[y] += current;
            if (x == y)
                mainDiag += current;
            if (x == SIZE - 1 - y)
                collatDiag += current;
        }

        private static void Swap(ref int a, ref int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }
    }
}
