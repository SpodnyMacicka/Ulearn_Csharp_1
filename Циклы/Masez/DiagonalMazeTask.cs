using System;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int aspectRatio;
            while (robot.Finished == false)
            {
                if (width > height)
                {
                    aspectRatio = (width - 2) / (height - 2);
                    Move(robot, aspectRatio, Direction.Right, Direction.Down);
                }
                else
                {
                    aspectRatio = (height - 2) / (width - 2);
                    Move(robot, aspectRatio, Direction.Down, Direction.Right);
                }
            }
        }
        public static void Move(Robot robot, int aspectRatio, Direction direction, Direction directionTwo)
        {
            if (!robot.Finished) for (var i = 0; i < aspectRatio; i++) robot.MoveTo(direction);
            if (!robot.Finished) robot.MoveTo(directionTwo);
        }
    }
}