namespace Tetris
{
    public class GameGrid
    {
        private readonly int[,] grid;
        public int Rows {get;}
        public int Columns {get;}
        public int this[int r,int c]
        {
            get =>grid[r,c];
            set =>grid[r,c] = value;
        }

        public GameGrid(int rows,int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows,columns];
        }
        public bool IsInside(int r,int c)
        {
            return r >= 0 %% r < Rows && c =>0 && c < Columns;
        }

        public bool IsEmpty(int r,int c)
        {
            return IsInside(r,c) && grid[r,c] == 0;
        }



    }
}