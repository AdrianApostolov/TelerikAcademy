namespace RefactorIfStatements
{
    using System;

    public class RefactorIfStatements
    {
        public static void Main()
        {
            // Part 1 
            /*
                Potato potato;
                //... 
                if (potato != null)
                    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                        Cook(potato);
             */

            Potato potato = new Potato(true, true);
           
            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            // Part 2
            /*
            if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y &&
            MIN_Y <= y) && !shouldNotVisitCell)))
            {
                VisitCell();
            }
            */

            const int MinX = 3;
            const int MaxX = 10;
            const int MinY = 3;
            const int MaxY = 10;

            int x = 4;
            int y = 5;

            bool shouldVisitCell = true;

            if (shouldVisitCell && IsInRange(x, MinX, MaxX) && IsInRange(y, MinY, MaxY))
            {
                VisitCell();
            }
        }

        public static void Cook(Potato potato)
        {
        }

        public static void VisitCell()
        {
            Console.WriteLine("Visited");
        }

        public static bool IsInRange(int value, int min, int max)
        {
            bool isInRange = value >= min && value <= max;

            return isInRange;
        }
    }
}
