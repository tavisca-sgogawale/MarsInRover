namespace MarsInRover
{
    public class Direction
    {
        public char direction;

        public Direction()
        {
        }

        public Direction(char c)
        {
            this.direction = c;
        }

        public char GetDirection()
        {
            return this.direction;
        }
        void SetDirection(char direction)
        {
            this.direction = direction;
        }
    }

    public class SouthDirection : Direction
    {
        new char direction;
        public char GetDirection()
        {
            return 'S';
        }

        public void SetDirection(char direction)
        {
            this.direction = direction;
        }
    }
    public class NorthDirection : Direction
    {
        char direction;
        public char GetDirection()
        {
            return 'N';
        }
        public void SetDirection(char direction)
        {
            this.direction = direction;
        }
    }
    public class EastDirection : Direction
    {
        char direction ;
        public char GetDirection()
        {
            return 'E';
        }
        public void SetDirection(char direction)
        {
            this.direction = direction;
        }
    }
    public class WestDirection : Direction
    {
        char direction ;
        public char GetDirection()
        {
            return 'W';
        }
        public void SetDirection(char direction)
        {
            this.direction = direction;
        }

    }
}