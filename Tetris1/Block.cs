using System.Collections.Generic;

namespace Tetris1
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles {get;}
        protected abstract Position StartOffset {get;}
        public abstract int Id {get;}
        private int rotationState;
        private Position offest;
        public Block()
        {
            offest = new Position(StartOffset.Row,StartOffset.Column);
        }
        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offest.Row,p.Column + offest.Column);
            }
        }

        public void RotateCS()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCCW()
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }
        public void Move(int rows, int columns)
        {
            offest.Row += rows;
            offest.Column += columns;
        }

        public void Reset()
        {
            rotationState = 0;
            offest.Row = StartOffset.Row;
            offest.Column = StartOffset.Column;
        }

    }

}