namespace Lesson5
{
    public class FilledArray
    {
        private int[,] array;
        private int rowCount;
        private int columnCount;
        private Cell currentCell;

        public FilledArray(int row, int column)
        {
            rowCount = row;
            columnCount = column;
            array = new int[rowCount, columnCount];
            currentCell = new Cell(0, 0, DirectionMovement.Right);
            int value = 1;

            // Заполняем массив, пока не заполним все ячейки
            while (value <= rowCount * columnCount)
            {
                // Заполняем текущую ячейку
                array[currentCell.row, currentCell.column] = value++;

                // Пытаемся перейти к следующей ячейке
                Cell nextCell = currentCell.GetNextCell();

                // Если следующая ячейка недоступна, меняем направление
                if (!CellIsGood(nextCell))
                {
                    currentCell.ChangeDirectionMovement();
                    nextCell = currentCell.GetNextCell();
                }

                // Переходим к следующей ячейке
                currentCell = nextCell;
            }
        }

        private bool CellIsGood(Cell cell)
        {
            int row = cell.row;
            int column = cell.column;
            return (row >= 0 && column >= 0 && row < rowCount && column < columnCount && array[row, column] == 0);
        }

        public int[,] GetArray() => array;
    }

    public enum DirectionMovement
    {
        Right,
        Down,
        Left,
        Up
    }

    public struct Cell
    {
        public int row { get; }
        public int column { get; }
        private DirectionMovement direction;

        public Cell(int row, int column, DirectionMovement direction)
        {
            this.row = row;
            this.column = column;
            this.direction = direction;
        }

        public Cell GetNextCell()
        {
            int nextRow = row;
            int nextColumn = column;

            switch (direction)
            {
                case DirectionMovement.Right:
                    nextColumn++;
                    break;
                case DirectionMovement.Down:
                    nextRow++;
                    break;
                case DirectionMovement.Left:
                    nextColumn--;
                    break;
                case DirectionMovement.Up:
                    nextRow--;
                    break;
            }

            return new Cell(nextRow, nextColumn, direction);
        }

        public void ChangeDirectionMovement()
        {
            switch (direction)
            {
                case DirectionMovement.Right:
                    direction = DirectionMovement.Down;
                    break;
                case DirectionMovement.Down:
                    direction = DirectionMovement.Left;
                    break;
                case DirectionMovement.Left:
                    direction = DirectionMovement.Up;
                    break;
                case DirectionMovement.Up:
                    direction = DirectionMovement.Right;
                    break;
            }
        }
    }
}