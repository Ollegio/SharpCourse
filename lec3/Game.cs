using System;

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
        public static Mark CurrentTurn { get; private set; }
        private static readonly Mark[,] Field;
        private static readonly int[] Rows, Cols;
        private static int MainDiag { get; set; }
        private static int CollatDiag { get; set; }
        private static int Size => 3;

        static Game()
        {
            Field = new Mark[Size, Size];
            Rows = new int[Size];
            Cols = new int[Size];
        }

        public static void Init()
        {
            for (var i = 0; i < Size; i++)
            for (var j = 0; j < Size; j++)
                Field[i, j] = Mark.NotSet;

            for (var i = 0; i < Size; i++)
            {
                Cols[i] = 0;
                Rows[i] = 0;
            }
            MainDiag = CollatDiag = 0;

            CurrentTurn = Mark.X;
        }

        public static bool MakeMove(int x, int y)
        {
            var input = CurrentTurn == Mark.O ? -1 : 1;

            Field[x, y] = CurrentTurn;
            Fill(x, y, input);
            if (Check(x, y))
            {
                return true;
            }

            CurrentTurn = CurrentTurn == Mark.X ? Mark.O : Mark.X;
            return false;
        }

        private static bool Check(int x, int y)
        {
            if (Rows[x] == Size || Rows[x] == -Size)
            {
                Console.WriteLine(@"Заполнена строка");
                return true;
            }

            if (Cols[y] == Size || Cols[y] == -Size)
            {
                Console.WriteLine(@"Заполнен столбец");
                return true;
            }

            if (MainDiag == Size)
            {
                Console.WriteLine(@"Заполнена диагональ");
                return true;
            }

            if (CollatDiag != Size) return false;
            Console.WriteLine(@"Заполнена вторая диагональ");
            return true;

        }

        private static void Fill(int x, int y, int current)
        {
            Rows[x] += current;
            Cols[y] += current;
            if (x == y)
                MainDiag += current;
            if (x == Size - 1 - y)
                CollatDiag += current;
        }
    }
}
