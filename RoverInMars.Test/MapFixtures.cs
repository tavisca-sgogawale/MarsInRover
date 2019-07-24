using Xunit;
using FluentAssertions;
using MarsInRover;

namespace RoverInMars.Test
{
    public class MapFixtures
    {
        [Fact]
        public void Test_to_check_max_x_capacity()  
        {
        Mars mars = new Mars(new Coordinate() { x = 15, y = 20 }); 
            mars.mapSize.x.Should().Be(15);
        }
        [Fact]
        public void Test_to_check_default_max_y_capacity()
        {
            Mars mars = new Mars();
            mars.mapSize.y.Should().Be(10);

        }
         [Fact]
        public void Test_to_check_default_max_x_capacity()
        {
            Mars mars = new Mars();
            mars.mapSize.x.Should().Be(10);
        }
    }

}
