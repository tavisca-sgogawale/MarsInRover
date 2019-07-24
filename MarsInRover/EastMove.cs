namespace MarsInRover
{
    public class EastMove:IMovemonet
    {
        public void MoveForward(Rover rover)
        {
            Mars m = new Mars();
            if (rover.currentCoordinates.x== m.mapSize.x)
                rover.currentCoordinates.x = rover.currentCoordinates.x;
            else
                rover.currentCoordinates.x = rover.currentCoordinates.x + 1;
        }
    }
}
