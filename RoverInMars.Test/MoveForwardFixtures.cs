using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using MarsInRover;

namespace RoverInMars.Test
{
    public class MoveForwardFixtures
    {
        [Fact]
        public void Test_For_Move_Forward_When_Direction_Is_West()
        {
            Rover rover = new Rover(new Coordinate() { x = 2, y = 1 }, new Direction( 'S'));
            WestMove w = new WestMove();
            w.MoveForward(rover);
            rover.currentCoordinates.x.Should().Be(1);
        }
        [Fact]
        public void Test_For_Move_Forward_At_Edge_When_Direction_Is_West()
        {
            Rover rover = new Rover(new Coordinate() { x = 2, y = 1 }, new Direction('S'));
            WestMove w = new WestMove();
            w.MoveForward(rover);
            w.MoveForward(rover);
            w.MoveForward(rover);
            w.MoveForward(rover);
            rover.currentCoordinates.x.Should().Be(0);
        }
        [Fact]
        public void Test_For_Move_Forward_When_Direction_Is_North()
        {
            Rover rover = new Rover(new Coordinate() { x = 2, y = 1 }, new Direction('S'));
            NorthMove w = new NorthMove();
            w.MoveForward(rover);
            rover.currentCoordinates.y.Should().Be(2);
        }
        [Fact]
        public void Test_For_Move_Forward_At_Edge_When_Direction_Is_North()
        {
            Rover rover = new Rover(new Coordinate() { x = 2, y = 10 }, new Direction('S'));
            NorthMove w = new NorthMove();
            w.MoveForward(rover);
            rover.currentCoordinates.y.Should().Be(10);
        }
        [Fact]
        public void Test_For_Move_Forward_When_Direction_Is_South()
        {
            Rover rover = new Rover(new Coordinate() { x = 2, y = 1 }, new Direction('S'));
            SouthMove w = new SouthMove();
            w.MoveForward(rover);
            rover.currentCoordinates.y.Should().Be(0);
        }
        [Fact]
        public void Test_For_Move_Forward_At_Edge_When_Direction_Is_South()
        {
            Rover rover = new Rover(new Coordinate() { x = 2, y = 0 }, new Direction('S'));
            SouthMove w = new SouthMove();
            w.MoveForward(rover);
            rover.currentCoordinates.y.Should().Be(0);
        }
        [Fact]
        public void Test_For_Move_Forward_When_Direction_Is_East()
        {
            Rover rover = new Rover(new Coordinate() { x = 2, y = 1 }, new Direction('S'));
            EastMove w = new EastMove();
            w.MoveForward(rover);
            rover.currentCoordinates.x.Should().Be(3);
        }

        [Fact]
        public void Test_For_Move_Forward_At_Edge_When_Direction_Is_East()
        {
            Rover rover = new Rover(new Coordinate() { x = 10, y = 1 }, new Direction('S'));
            EastMove w = new EastMove();
            w.MoveForward(rover);
            rover.currentCoordinates.x.Should().Be(10);
        }

    }
}
