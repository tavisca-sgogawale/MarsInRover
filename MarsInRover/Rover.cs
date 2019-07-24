using System;
using System.Collections.Generic;
using System.Text;

namespace MarsInRover
{
    public class Rover
    {
        public Coordinate currentCoordinates;
        public Direction currentDirection;
        public readonly List<char> validInputs = new List<char>() { 'L', 'R', 'M' };

        public Rover(Coordinate corr, Direction direction )
        {
            this.currentCoordinates = corr;
            this.currentDirection = direction;
        }

        public Rover()
        {
        }

        public enum Directions{
            N=0,
            E=1,
            W=3,
            S=2
            }

        public void ExecuteInstructions(char instruction , Rover rover)
        {
            if(instruction == 'M')
            {
                //new MoveForward(Coordinate corr = rover.currentCoordinates, Direction dirr = rover.currentDirection);
            }

        }
    }
}
