using System;
using AntApp;
using FluentAssertions;
using NUnit.Framework;

namespace AntAppSpecs
{
    public class AntAppShould
    {
        [TestCase(3)]
        [TestCase(5)]
        public void create_grid_with_specified_size(int gridSize)
        {
            var antApp = new AntApp.AntApp(gridSize);

            var grid = antApp.GetGrid();
            grid.Length.Should().Be(gridSize * gridSize);
            grid.GetLength(0).Should().Be(gridSize);
            grid.GetLength(1).Should().Be(gridSize);
        }

        [TestCase(2)]
        [TestCase(4)]
        public void throw_grid_can_not_build_even_sized_grid_exception_when_size_is_even(int gridSize)
        {
            Action action = () => new AntApp.AntApp(gridSize);

            action.Should().Throw<CanNotBuildEvenSizedGridException>();
        }

        [Test]
        public void initialize_grid_with_the_ant_in_the_middle_for_grid_of_size_3()
        {
            var antApp = new AntApp.AntApp(3);

            var grid = antApp.GetGrid();

            grid[1, 1].Should().Be('A');
        }

        [Test]
        public void initialize_grid_with_the_ant_in_the_middle_for_grid_of_size_7()
        {
            var antApp = new AntApp.AntApp(7);

            var grid = antApp.GetGrid();

            grid[3, 3].Should().Be('A');
        }
    }
}