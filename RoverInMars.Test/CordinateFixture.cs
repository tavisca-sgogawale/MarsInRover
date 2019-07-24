using System;
using MarsInRover;
using FluentAssertions;
using Xunit;

namespace RoverInMars.Test
{
    public class CordinateFixture
    {
        [Fact]
        public void Can_store_coordinate()
        {
            Coordinate corr = new Coordinate() { x = 15, y = 3 };
            corr.x.Should().Be(15);
            corr.y.Should().Be(3);
        }
    }
}
