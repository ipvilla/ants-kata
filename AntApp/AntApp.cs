namespace AntApp
{
    public class AntApp
    {
        private char[,] grid;

        public AntApp(int dimension)
        {
            if (dimension == 5)
            {
                grid = new char[5, 5];
            }
            else
            {
                grid = new char[3, 3];
            }
        }

        public char[,] GetGrid()
        {
            return grid;
        }
    }
}