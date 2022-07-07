namespace AntApp
{
    public class AntApp
    {
        private readonly char[,] grid;

        public AntApp(int dimension)
        {
            grid = new char[dimension, dimension];
        }

        public char[,] GetGrid()
        {
            return grid;
        }
    }
}