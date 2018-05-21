using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lec3
{
    enum Mark
    {
        O,
        X,
        NotSet
    }

    static class Game
    {
        private static Mark currentTurn;
        private static Mark[,] field;
        private static int[] rows, cols;
        private static int mainDiag, collatDiag;
        private static int SIZE => 3;

        static Game()
        {
            field = new Mark[SIZE,SIZE];
            for (var i = 0; i < SIZE; i++)
            {
                for (var j = 0; j < SIZE; j++)
                {
                    field[i,j] = Mark.NotSet;
                }
            }
        }

        public static void Init()
        {
            currentTurn = Mark.X;
            var a = new int[5];
        }

        public static void Move(int x, int y)
        {
            var input = currentTurn == Mark.O ? -1 : 1;

            field[x, y] = currentTurn;
            Fill(x, y, input);
            if (Check(x, y))
            {
                
            }

            currentTurn = currentTurn == Mark.X ? Mark.O : Mark.X;
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
    }
}
