namespace MarsInRover
{
    public class SouthMove : IMovemonet
    {
        public void MoveForward(Rover rover)
        {
            Mars m = new Mars();
            if (rover.currentCoordinates.y <= 0)
                rover.currentCoordinates.y = rover.currentCoordinates.y;
            else
                rover.currentCoordinates.y = rover.currentCoordinates.y - 1;
        }
    }
}
