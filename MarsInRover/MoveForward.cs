namespace MarsInRover
{
    internal class MoveForward
    {
        public Coordinate coordinate;
        
        public Direction direction;
       

        public MoveForward(Coordinate coordinate, Direction direction)
        {
            this.coordinate = coordinate;
            
            this.direction = direction;
        }
    }
}