namespace AntApp
{
    public class AntApp
    {
        private readonly char[,] grid;

        public AntApp(int gridSize)
        {
            if (gridSize % 2 == 0)
            {
                throw new CanNotBuildEvenSizedGridException();
            }
            grid = new char[gridSize, gridSize];

            grid[1, 1] = 'A';
        }

        public char[,] GetGrid()
        {
            return grid;
        }
    }
}