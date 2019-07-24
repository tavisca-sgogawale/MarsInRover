using System;
using System.Collections.Generic;
using System.Text;

namespace MarsInRover
{
    public interface IAction
    {

    }
    public interface IRotate : IAction
    {
       void RoverTurn( Rover rover);
    }
}
