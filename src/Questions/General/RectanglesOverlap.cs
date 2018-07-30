using System;
using System.Drawing;

namespace NetCore.Questions.General
{
    public class RectanglesOverlap : IQuestion
    {
        public void Run()
        {
            AnswerQuestion(
                new Point(2,2), new Point(4,4),
                new Point(0,1), new Point(3,3)
            );

            AnswerQuestion(
                new Point(2,2), new Point(4,4),
                new Point(5,5), new Point(10,10)
            );
        }

        public void AnswerQuestion(Point bl1, Point tr1, Point bl2, Point tr2)
        {
            Console.WriteLine("Comparing rectangles");
            Console.WriteLine(DoesOverlap(bl1, tr1, bl2, tr2));
        }


        public bool DoesOverlap(Point bl1, Point tr1, Point bl2, Point tr2)
        {
            // Check up/down
            if (bl1.Y > tr2.Y || tr1.Y < bl2.Y)
            {
                return false;
            }

            // Check left/right
            if (bl1.X > tr2.X || tr1.X < bl2.X)
            {
                return false;
            }

            return true;
        }
    }


}