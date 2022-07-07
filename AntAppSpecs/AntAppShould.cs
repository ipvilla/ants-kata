using FluentAssertions;
using NUnit.Framework;

namespace AntAppSpecs
{
    public class AntAppShould
    {
        [TestCase(3)]
        [TestCase(5)]
        public void create_grid_with_specified_dimension(int dimension)
        {
            var antApp = new AntApp.AntApp(dimension);

            var grid = antApp.GetGrid();
            grid.Length.Should().Be(dimension * dimension);
            grid.GetLength(0).Should().Be(dimension);
            grid.GetLength(1).Should().Be(dimension);
        }
    }
}