namespace AntApp
{
    public class AntApp
    {
        private readonly char[,] grid;

        public AntApp(int dimension)
        {
            if (dimension == 2)
            {
                throw new CanNotBuildEvenSizedGridException();
            }
            grid = new char[dimension, dimension];
        }

        public char[,] GetGrid()
        {
            return grid;
        }
    }
}