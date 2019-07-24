namespace MarsInRover
{
    public class WestMove : IMovemonet
    {
        public void MoveForward(Rover rover)
        {
            Mars m = new Mars();
            if (rover.currentCoordinates.x <= 0)
                rover.currentCoordinates.x = rover.currentCoordinates.x;
            else       
                rover.currentCoordinates.x = rover.currentCoordinates.x - 1;
        }
    }
}
