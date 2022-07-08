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
    }
}