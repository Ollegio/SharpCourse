using lec5.Entities;
using System;

namespace lec5
{
    public enum Mark
    {
        O,
        X,
        NotSet
    }

    public class Game : IGame
    {
        public Mark CurrentTurn { get; private set; }
        protected readonly Mark[,] Field;
        protected readonly int[] Rows, Cols;
        protected int MainDiag { get; set; }
        protected int CollatDiag { get; set; }
        protected int Size { get; }

        public Game(int size = 3, Mark beginningTurn = Mark.X)
        {
            Size = size;
            Field = new Mark[Size, Size];
            Rows = new int[Size];
            Cols = new int[Size];
            for (var i = 0; i < Size; i++)
                for (var j = 0; j < Size; j++)
                    Field[i, j] = Mark.NotSet;

            for (var i = 0; i < Size; i++)
            {
                Cols[i] = 0;
                Rows[i] = 0;
            }
            MainDiag = CollatDiag = 0;

            CurrentTurn = beginningTurn;
        }

        public bool MakeMove(int x, int y)
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

        private bool Check(int x, int y)
        {
            if (Rows[x] == Size || Rows[x] == -Size)
            {
                return true;
            }

            if (Cols[y] == Size || Cols[y] == -Size)
            {
                return true;
            }

            if (MainDiag == Size || MainDiag == -Size)
            {
                return true;
            }

            return CollatDiag == Size || CollatDiag == -Size;
        }

        private void Fill(int x, int y, int current)
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
