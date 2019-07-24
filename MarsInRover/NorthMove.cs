namespace MarsInRover
{
    public class NorthMove : IMovemonet
    {
        public void MoveForward(Rover rover)
        {
            Mars m = new Mars();
            if (rover.currentCoordinates.y >= m.mapSize.y)
                rover.currentCoordinates.y = rover.currentCoordinates.y;
            else
                rover.currentCoordinates.y = rover.currentCoordinates.y + 1;
        }
    }
}
