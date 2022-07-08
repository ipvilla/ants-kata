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
        public void create_grid_with_specified_dimension(int dimension)
        {
            var antApp = new AntApp.AntApp(dimension);

            var grid = antApp.GetGrid();
            grid.Length.Should().Be(dimension * dimension);
            grid.GetLength(0).Should().Be(dimension);
            grid.GetLength(1).Should().Be(dimension);
        }

        [Test]
        public void throw_grid_can_not_build_even_sized_grid_exception_when_size_is_2()
        {
            Action action = () => new AntApp.AntApp(2);

            action.Should().Throw<CanNotBuildEvenSizedGridException>();
        }

        [Test]
        public void throw_grid_can_not_build_even_sized_grid_exception_when_size_is_4()
        {
            Action action = () => new AntApp.AntApp(4);

            action.Should().Throw<CanNotBuildEvenSizedGridException>();
        }
    }
}