using FluentAssertions;
using NUnit.Framework;

namespace AntAppSpecs
{
    public class AntAppShould
    {
        [Test]
        public void create_grid_with_3x3_dimension()
        {
            var antApp = new AntApp(3);

            var grid = antApp.GetGrid();
            grid.Length.Should().Be(9);
            grid.GetLength(0).Should().Be(3);
            grid.GetLength(1).Should().Be(3);
            grid.GetLength(2).Should().Be(3);
        }
    }
}